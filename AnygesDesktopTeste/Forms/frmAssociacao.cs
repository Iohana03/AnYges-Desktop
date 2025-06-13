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
    public partial class A : Form
    {
        string caminhoRelativoImagem = "";
        int idAssociacao;
        ClasseConexao conexao = new ClasseConexao();

        public A(int idAssociacao)
        {
            InitializeComponent();
            this.idAssociacao = idAssociacao;

            // Evento para liberar a imagem ao fechar o formulário
            this.FormClosing += A_FormClosing;
        }

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imagens (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoAbsoluto = openFileDialog.FileName;
                string nomeArquivo = Path.GetFileName(caminhoAbsoluto);
                //string pastaDestino = @"C:\Users\User\Documents\AnYges-Desktop\src\imgs\cupons";
                string pastaDestino = @"C:\Users\Lab_ETESP\Documents\AnYges-Desktop\src\imgs\cupons";

                if (!Directory.Exists(pastaDestino))
                    Directory.CreateDirectory(pastaDestino);

                string caminhoFinal = Path.Combine(pastaDestino, nomeArquivo);
                File.Copy(caminhoAbsoluto, caminhoFinal, true);

                caminhoRelativoImagem = $"src/imgs/cupons/{nomeArquivo}";

                // Libera imagem anterior, se houver
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }

                // Carrega a imagem em memória para não travar o arquivo
                using (var imgTemp = Image.FromFile(caminhoFinal))
                {
                    pictureBox1.Image = new Bitmap(imgTemp); // Cópia segura
                }

                MessageBox.Show("Imagem selecionada e copiada com sucesso!");
            }
        }

        private void A_Load(object sender, EventArgs e)
        {
            txtIdAssoc.Text = idAssociacao.ToString();
            txtIdAssoc.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO tblCupom 
            (ID_associacao, nome_cupom, disponivel, valor, tipo, imagem, descricao_cupom, desconto, aprovado)
            VALUES 
            (@ID_associacao, @nome_cupom, @disponivel, @valor, @tipo, @imagem, @descricao, @desconto, @aprovado)";

            cmd.Parameters.AddWithValue("@ID_associacao", idAssociacao);
            cmd.Parameters.AddWithValue("@nome_cupom", txtNome.Text);
            cmd.Parameters.AddWithValue("@disponivel", txtDisponivel.Text);
            cmd.Parameters.AddWithValue("@valor", Convert.ToDecimal(txtValor.Text));
            cmd.Parameters.AddWithValue("@tipo", txtTipo.Text);
            cmd.Parameters.AddWithValue("@imagem", caminhoRelativoImagem);
            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
            cmd.Parameters.AddWithValue("@desconto", Convert.ToInt32(txtDesconto.Text));
            cmd.Parameters.AddWithValue("@aprovado", txtAprovado.Text);

            int resultado = conexao.manutencaoDB_Parametros(cmd);

            if (resultado > 0)
                MessageBox.Show("Cupom cadastrado com sucesso!");
            else
                MessageBox.Show("Erro ao cadastrar cupom.");
        }

        private void BtnGerencia_Click(object sender, EventArgs e)
        {
            frmGerenciarCupons frm = new frmGerenciarCupons(idAssociacao);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void A_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }
    }
}
