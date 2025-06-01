using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.Data.SqlClient;

namespace AnygesDesktopTeste.Forms
{
    public partial class frmLocalDeDeposito : Form
    {
        private int idLocalDeposito;
        ClasseConexao con = new ClasseConexao();
        public frmLocalDeDeposito(int idLocal)
        {
            InitializeComponent();
            idLocalDeposito = idLocal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idFuncStr = txtIdFunc.Text.Trim();
            string dataStr = txtDataDoacao.Text.Trim();
            string pesoStr = txtPesoDoacao.Text.Trim();

            if (string.IsNullOrWhiteSpace(idFuncStr) || string.IsNullOrWhiteSpace(dataStr) || string.IsNullOrWhiteSpace(pesoStr))
            {
                MessageBox.Show("Preencha todos os campos antes de gerar o QR Code.");
                return;
            }

            int idFunc = Convert.ToInt32(idFuncStr);
            decimal peso = Convert.ToDecimal(pesoStr);
            DateTime dataDoacao = Convert.ToDateTime(dataStr);
            decimal pontuacao = peso;

            // Conteúdo do QR Code (e também da Label)
            string dadosQRCode =
                $"Funcionário: {txtNomeFunc.Text}\n" +
                $"ID Funcionário: {idFunc}\n" +
                $"Cargo: {txtCargoFunc.Text}\n" +
                $"Data: {dataDoacao:dd/MM/yyyy}\n" +
                $"Peso: {peso}g\n" +
                $"Pontuação: {pontuacao}";

            // Mostra o conteúdo na Label
            lblConteudoQRCode.Text = dadosQRCode;

            // Gera o QR Code na imagem
            QRCodeGenerator qrGerador = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGerador.CreateQrCode(dadosQRCode, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrImagem = qrCode.GetGraphic(20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = new Bitmap(qrImagem, pictureBox1.Width, pictureBox1.Height);

            // Salva no banco (sem o QR code)

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = @"INSERT INTO tblDoacao 
    (ID_funcionario, ID_local_deposito, dt_doacao, peso, pontuacao, descricao_doacao)
    VALUES (@idFunc, @idLocal, @data, @peso, @pontuacao, @descricao)";

            cmd.Parameters.AddWithValue("@idFunc", idFunc);
            cmd.Parameters.AddWithValue("@idLocal", idLocalDeposito);
            cmd.Parameters.AddWithValue("@data", dataDoacao);
            cmd.Parameters.AddWithValue("@peso", peso);
            cmd.Parameters.AddWithValue("@pontuacao", pontuacao);
            cmd.Parameters.AddWithValue("@descricao", DBNull.Value); 

            bool sucesso = con.manutencaoDB_Parametros(cmd) > 0;


            if (sucesso)
            {
                MessageBox.Show("Doação registrada com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao registrar a doação.");
            }

        }

    }
}
