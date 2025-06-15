using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnygesDesktopTeste.Forms;
using System.Data.SqlClient;

namespace AnygesDesktopTeste
{
    public partial class FormLogin : Form
    {
        ClasseConexao con;
        DataTable dt;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            cmbTipoUsuario.Items.Add("Funcionário");
            cmbTipoUsuario.Items.Add("Associação");
            cmbTipoUsuario.Items.Add("Local de Depósito");
            cmbTipoUsuario.SelectedIndex = 0;

            CriarProcedures();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            string email = txtEmail.Text.Trim();
            string senha = txtSenha.Text.Trim();
            string tipo = cmbTipoUsuario.SelectedItem.ToString();
            string procedureName = "";

            if (tipo == "Funcionário")
                procedureName = "spLoginFuncionario";
            else if (tipo == "Associação")
                procedureName = "spLoginAssociacao";
            else if (tipo == "Local de Depósito")
                procedureName = "spLoginLocalDeposito";

            SqlCommand comando = new SqlCommand(procedureName, con.conectar());
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codigo", email);
            comando.Parameters.AddWithValue("@senha", senha);

            dt = con.executarSQL_Parametros(comando);

            if (dt != null && dt.Rows.Count > 0)
            {
                this.Hide();

                if (tipo == "Funcionário")
                {
                    MenuInicial menu = new MenuInicial();
                    menu.ShowDialog();
                }
                else if (tipo == "Associação")
                {
                    int idAssociacao = Convert.ToInt32(dt.Rows[0]["ID_associacao"]);
                    A assoc = new A(idAssociacao);
                    assoc.ShowDialog();
                }
                else if (tipo == "Local de Depósito")
                {
                    int idLocal = Convert.ToInt32(dt.Rows[0]["ID_local_deposito"]);
                    frmLocalDeDeposito LocalDepos = new frmLocalDeDeposito(idLocal);
                    LocalDepos.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CriarProcedures()
        {
            con = new ClasseConexao();
            SqlConnection conexao = con.conectar();

            string criarFuncionario = @"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'spLoginFuncionario')
                BEGIN
                    EXEC('
                        CREATE PROCEDURE spLoginFuncionario
                            @codigo NVARCHAR(100),
                            @senha NVARCHAR(100)
                        AS
                        BEGIN
                            SELECT codigo_func, senha_func
                            FROM tblFuncionario
                            WHERE codigo_func = @codigo AND senha_func = @senha
                        END
                    ')
                END";

            string criarAssociacao = @"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'spLoginAssociacao')
                BEGIN
                    EXEC('
                        CREATE PROCEDURE spLoginAssociacao
                            @codigo NVARCHAR(100),
                            @senha NVARCHAR(100)
                        AS
                        BEGIN
                            SELECT ID_associacao, codigo_assoc, senha_assoc
                            FROM tblAssociacao
                            WHERE codigo_assoc = @codigo AND senha_assoc = @senha
                        END
                    ')
                END";

            string criarDeposito = @"
                IF NOT EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'spLoginLocalDeposito')
                BEGIN
                    EXEC('
                        CREATE PROCEDURE spLoginLocalDeposito
                            @codigo NVARCHAR(100),
                            @senha NVARCHAR(100)
                        AS
                        BEGIN
                            SELECT ID_local_deposito, codigo_depo, senha_depo
                            FROM tblLocalDeposito
                            WHERE codigo_depo = @codigo AND senha_depo = @senha
                        END
                    ')
                END";

            SqlCommand cmd1 = new SqlCommand(criarFuncionario, conexao);
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = new SqlCommand(criarAssociacao, conexao);
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand(criarDeposito, conexao);
            cmd3.ExecuteNonQuery();

            con.desconectar();
        }
    }
}