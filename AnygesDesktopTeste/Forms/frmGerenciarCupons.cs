using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace AnygesDesktopTeste.Forms
{
    public partial class frmGerenciarCupons : Form
    {
        ClasseConexao conexao = new ClasseConexao();
        int idAssociacao;
        public frmGerenciarCupons(int idAssociacao)
        {
            InitializeComponent();
            this.idAssociacao = idAssociacao;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nomePesquisado = txtPesquisarCupom.Text;
            SqlConnection con = conexao.conectar();
            string query = "SELECT * FROM tblCupom WHERE nome_cupom LIKE @nome AND ID_associacao = @idAssoc";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nome", "%" + txtPesquisarCupom.Text + "%");
            cmd.Parameters.AddWithValue("@idAssoc", idAssociacao);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {

                txtId.Text = reader["ID_cupom"].ToString(); 
                txtNome.Text = reader["nome_cupom"].ToString();
                txtNome.Text = reader["nome_cupom"].ToString();
                txtTipo.Text = reader["tipo"].ToString();
                txtValor.Text = reader["valor"].ToString();
                txtDisponivel.Text = reader["disponivel"].ToString();
                txtDescricao.Text = reader["descricao_cupom"].ToString();
                txtDesconto.Text = reader["desconto"].ToString();
                txtAprovado.Text = reader["aprovado"].ToString();

              
                string caminhoRelativo = reader["imagem"].ToString();

         
                string pastaImagem = @"C:\Users\User\Documents\AnYges-Desktop";
                string caminhoCompleto = Path.Combine(pastaImagem, caminhoRelativo);

                if (File.Exists(caminhoCompleto))
                {
                    using (FileStream fs = new FileStream(caminhoCompleto, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxCupom.Image = Image.FromStream(fs);
                    }
                }
                else
                {
                    MessageBox.Show("Imagem não encontrada no caminho: " + caminhoCompleto);
                    pictureBoxCupom.Image = null;
                }
            }
            else
            {
                MessageBox.Show("Cupom não encontrado.");
            }

            reader.Close();
            conexao.desconectar();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Selecione um cupom para excluir.");
                return;
            }

            DialogResult confirmacao = MessageBox.Show("Deseja realmente excluir este cupom?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmacao != DialogResult.Yes) return;

            SqlConnection con = conexao.conectar();

            try
            {
                string caminhoRelativo = "";
                SqlCommand cmdSelect = new SqlCommand("SELECT imagem FROM tblCupom WHERE ID_cupom = @id", con);
                cmdSelect.Parameters.AddWithValue("@id", txtId.Text);
                object resultado = cmdSelect.ExecuteScalar();
                if (resultado != null)
                {
                    caminhoRelativo = resultado.ToString();
                }

                if (pictureBoxCupom.Image != null)
                {
                    pictureBoxCupom.Image.Dispose();
                    pictureBoxCupom.Image = null;
                }

                SqlCommand cmdDelete = new SqlCommand("DELETE FROM tblCupom WHERE ID_cupom = @id", con);
                cmdDelete.Parameters.AddWithValue("@id", txtId.Text);
                int linhasAfetadas = cmdDelete.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    string caminhoImagemCompleto = Path.Combine(@"C:\Users\User\Documents\AnYges-Desktop", caminhoRelativo);
                    if (File.Exists(caminhoImagemCompleto))
                    {
                        File.Delete(caminhoImagemCompleto);
                    }

                    MessageBox.Show("Cupom excluído com sucesso!");

                    txtId.Clear();
                    txtNome.Clear();
                    txtTipo.Clear();
                    txtValor.Clear();
                    txtDisponivel.Clear();
                    txtDescricao.Clear();
                    txtDesconto.Clear();
                    txtAprovado.Clear();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o cupom.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                conexao.desconectar();
            }
        }
    }
}
