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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using PdfiumViewer;


namespace AnygesDesktopTeste.Forms
{
    public partial class frmCentDistAprov : Form
    {

        ClasseConexao conexao = new ClasseConexao();
        PdfiumViewer.PdfViewer pdf;
        private PdfiumViewer.PdfDocument pdfDocument = null;
        private PdfViewer pdfViewer = null;
        public frmCentDistAprov()
        {
            InitializeComponent();
            pdf = new PdfiumViewer.PdfViewer();
            pdf.Dock = DockStyle.Fill;
            pdf.Visible = false; // invisível inicialmente
            this.Controls.Add(pdf);
        }

        private void frmCentDistAprov_Load(object sender, EventArgs e)
        {
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellClick += dataGridView1_CellClick;
            CarregarGrid();
            PreencherTextBoxes(0);
            BloquearTextBoxes();
            btnFecharPDF.Visible = false;
        }


        private void CarregarGrid()
        {
            string sql = "SELECT * FROM tblLocalDeposito WHERE aprovado_depo = 'S'";

            try
            {
                DataTable dtOriginal = conexao.executarSQL(sql);


                string[] colunasBinarias = { "CNPJ_depo", "certificacao_depo", "alvara_depo", "licenca_depo", "comprovante_depo" };


                DataTable dtConvertido = new DataTable();

                foreach (DataColumn col in dtOriginal.Columns)
                {
                    if (colunasBinarias.Contains(col.ColumnName))
                        dtConvertido.Columns.Add(col.ColumnName, typeof(string));
                    else
                        dtConvertido.Columns.Add(col.ColumnName, col.DataType);
                }

                foreach (DataRow rowOrig in dtOriginal.Rows)
                {
                    DataRow rowNovo = dtConvertido.NewRow();

                    foreach (DataColumn col in dtOriginal.Columns)
                    {
                        if (colunasBinarias.Contains(col.ColumnName))
                        {
                            if (rowOrig[col.ColumnName] != DBNull.Value)
                            {
                                byte[] bytes = (byte[])rowOrig[col.ColumnName];
                                rowNovo[col.ColumnName] = "0x" + BitConverter.ToString(bytes).Replace("-", "");
                            }
                            else
                            {
                                rowNovo[col.ColumnName] = null;
                            }
                        }
                        else
                        {
                            rowNovo[col.ColumnName] = rowOrig[col.ColumnName];
                        }
                    }

                    dtConvertido.Rows.Add(rowNovo);
                }

                dataGridView1.DataSource = dtConvertido;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }
        private void PreencherTextBoxes(int rowIndex)
        {
            if (dataGridView1.Rows.Count > 0 && rowIndex >= 0)
            {
                txtNome.Text = dataGridView1.Rows[rowIndex].Cells["nome_depo"].Value?.ToString();
                txtEmail.Text = dataGridView1.Rows[rowIndex].Cells["email_depo"].Value?.ToString();

                txtCnpj.Text = ConversorBytes.TratarValor(dataGridView1.Rows[rowIndex].Cells["CNPJ_depo"].Value);
                txtCertidao.Text = ConversorBytes.TratarValor(dataGridView1.Rows[rowIndex].Cells["certificacao_depo"].Value);
                txtAlvara.Text = ConversorBytes.TratarValor(dataGridView1.Rows[rowIndex].Cells["alvara_depo"].Value);
                txtLicenca.Text = ConversorBytes.TratarValor(dataGridView1.Rows[rowIndex].Cells["licenca_depo"].Value);
                txtComprovante.Text = ConversorBytes.TratarValor(dataGridView1.Rows[rowIndex].Cells["comprovante_depo"].Value);

                txtId.Text = dataGridView1.Rows[rowIndex].Cells["ID_local_deposito"].Value?.ToString();
                txtCodigo.Text = dataGridView1.Rows[rowIndex].Cells["codigo_depo"].Value?.ToString();
                txtSenha.Text = dataGridView1.Rows[rowIndex].Cells["senha_depo"].Value?.ToString();
                txtAprovado.Text = dataGridView1.Rows[rowIndex].Cells["aprovado_depo"].Value?.ToString();
            }
        }//comprovante_depo

        private void BloquearTextBoxes()
        {
            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCnpj.ReadOnly = true;
            txtCertidao.ReadOnly = true;
            txtAlvara.ReadOnly = true;
            txtLicenca.ReadOnly = true;
            txtComprovante.ReadOnly = true;
        }

        private void LiberarTextBoxes()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCnpj.ReadOnly = false;
            txtCertidao.ReadOnly = false;
            txtAlvara.ReadOnly = false;
            txtLicenca.ReadOnly = false;
            txtComprovante.ReadOnly = false;
            txtCodigo.ReadOnly = false;
            txtSenha.ReadOnly = false;
            txtAprovado.ReadOnly = false;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PreencherTextBoxes(e.RowIndex);
            }
        }




        public string ByteArrayToHexString(byte[] bytes)
        {
            return "0x" + BitConverter.ToString(bytes).Replace("-", "");
        }

        public byte[] HexStringToByteArray(string hex)
        {
            int length = hex.Length;
            byte[] bytes = new byte[length / 2];
            for (int i = 0; i < length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            LiberarTextBoxes();
        }

        private void BtnConcluido_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE tblLocalDeposito SET 
            nome_depo = @Nome,
            email_depo = @Email,
            CNPJ_depo = CONVERT(VARBINARY(MAX), @Cnpj, 1),
            certificacao_depo = CONVERT(VARBINARY(MAX), @Certidao, 1),
            alvara_depo = CONVERT(VARBINARY(MAX), @Alvara, 1),
            licenca_depo = CONVERT(VARBINARY(MAX), @Licenca, 1),
            comprovante_depo = CONVERT(VARBINARY(MAX), @Comprovante, 1),
            codigo_depo = @Codigo,
            senha_depo = @Senha,
            aprovado_depo = @Aprovado
            WHERE ID_local_deposito = @Id");

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("@Aprovado", txtAprovado.Text);
                cmd.Parameters.AddWithValue("@Id", txtId.Text);
                cmd.Parameters.AddWithValue("@Cnpj", HexStringToByteArray(txtCnpj.Text.Replace("0x", "")));
                cmd.Parameters.AddWithValue("@Certidao", HexStringToByteArray(txtCertidao.Text.Replace("0x", "")));
                cmd.Parameters.AddWithValue("@Alvara", HexStringToByteArray(txtAlvara.Text.Replace("0x", "")));
                cmd.Parameters.AddWithValue("@Licenca", HexStringToByteArray(txtLicenca.Text.Replace("0x", "")));
                cmd.Parameters.AddWithValue("@Comprovante", HexStringToByteArray(txtComprovante.Text.Replace("0x", "")));



                conexao.manutencaoDB_Parametros(cmd);
                CarregarGrid();
                BloquearTextBoxes();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PreencherTextBoxes(0);
            BloquearTextBoxes();

        }



        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.Value is byte[] bytes)
            {
                e.Value = ConversorBytes.ByteArrayToHexString(bytes);
                e.FormattingApplied = true;
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblLocalDeposito WHERE nome_depo LIKE @busca";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@busca", "%" + TxtFiltro.Text + "%");


            DataTable dt = conexao.executarSQL_Parametros(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                txtNome.Text = dt.Rows[0]["nome_depo"].ToString();
                txtEmail.Text = dt.Rows[0]["email_depo"].ToString();
                txtCnpj.Text = ConversorBytes.TratarValor(dt.Rows[0]["CNPJ_depo"]);
                txtCertidao.Text = ConversorBytes.TratarValor(dt.Rows[0]["certificacao_depo"]);
                txtAlvara.Text = ConversorBytes.TratarValor(dt.Rows[0]["alvara_depo"]);
                txtLicenca.Text = ConversorBytes.TratarValor(dt.Rows[0]["licenca_depo"]);
                txtComprovante.Text = ConversorBytes.TratarValor(dt.Rows[0]["comprovante_depo"]);
                txtId.Text = dt.Rows[0]["ID_local_deposito"].ToString();
                txtCodigo.Text = dt.Rows[0]["codigo_depo"].ToString();
                txtSenha.Text = dt.Rows[0]["senha_depo"].ToString();
                txtAprovado.Text = dt.Rows[0]["aprovado_depo"].ToString();



            }
            else
            {
                MessageBox.Show("Nenhum registro encontrado!");
            }
        }

        private static void AddCellToHeader(PdfPTable tableLayout, string cellText)
        {
            tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8)))
            {
                HorizontalAlignment = Element.ALIGN_CENTER,
                Padding = 10,
                BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
            });
        }



        private static void AddCellToBody(PdfPTable tableLayout, string cellText, int count) //Efeito fundo: cinza e claro
        {
            if (count % 2 == 0)
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(255, 255, 255)
                });
            }
            else
            {
                tableLayout.AddCell(new PdfPCell(new Phrase(cellText, FontFactory.GetFont(FontFactory.HELVETICA, 8, 1, iTextSharp.text.BaseColor.BLACK)))
                {
                    HorizontalAlignment = Element.ALIGN_LEFT,
                    Padding = 8,
                    BackgroundColor = new iTextSharp.text.BaseColor(230, 230, 230)
                });
            }
        }


        private void GerarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Salvar relatório em PDF";
            saveFileDialog.FileName = "RelatorioCentroDeDistribuição.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                        PdfWriter.GetInstance(document, stream);

                        document.Open();

                        PdfPTable tableLayout = new PdfPTable(10); 
                        tableLayout = corpo_documento(tableLayout); 

                        document.Add(tableLayout);
                        document.Close(); // <<< IMPORTANTE!
                        stream.Close();
                    }

                    MessageBox.Show("PDF gerado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao gerar PDF: " + ex.Message);
                }
            }
        }
        private List<Control> controlesVisiveisAntesPDF = new List<Control>();
        private void btnAbrirPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Fecha se já existe um PDF aberto
                    if (pdfDocument != null)
                    {
                        pdfViewer.Document.Dispose();
                        pdfDocument.Dispose();
                        pdfViewer.Dispose();
                        pdfDocument = null;
                        pdfViewer = null;
                    }

                    // Salva os controles visíveis
                    controlesVisiveisAntesPDF.Clear();
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl.Visible && ctrl != btnFecharPDF)
                            controlesVisiveisAntesPDF.Add(ctrl);
                    }

                    // Oculta todos os controles, exceto o botão de fechar
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl != btnFecharPDF)
                            ctrl.Visible = false;
                    }

                    // Cria novo visualizador
                    pdfViewer = new PdfViewer();
                    pdfViewer.Name = "visualizadorPDF";
                    pdfViewer.Dock = DockStyle.Fill;

                    pdfDocument = PdfiumViewer.PdfDocument.Load(ofd.FileName);
                    pdfViewer.Document = pdfDocument;

                    this.Controls.Add(pdfViewer);
                    pdfViewer.BringToFront();

                    btnFecharPDF.Visible = true;
                    btnFecharPDF.BringToFront();
                    btnFecharPDF.FlatStyle = FlatStyle.Popup;
                    btnFecharPDF.BackColor = Color.ForestGreen;
                    btnFecharPDF.ForeColor = Color.White;
                    btnFecharPDF.Font = new System.Drawing.Font("Inria Sans", 8.25f, FontStyle.Bold);


                }
            }

        }

        protected PdfPTable corpo_documento(PdfPTable tableLayout)
        {
            float[] headers = { 10, 30, 30, 20, 20, 15, 20, 20, 20, 20};
            tableLayout.SetWidths(headers);
            tableLayout.WidthPercentage = 100;
            tableLayout.HeaderRows = 1;

            AddCellToHeader(tableLayout, "Id");
            AddCellToHeader(tableLayout, "Nome");
            AddCellToHeader(tableLayout, "Email");
            AddCellToHeader(tableLayout, "Codigo");

            AddCellToHeader(tableLayout, "Aprovado");
            AddCellToHeader(tableLayout, "Cnpj");
            AddCellToHeader(tableLayout, "Certidao");
            AddCellToHeader(tableLayout, "Alvara");
            AddCellToHeader(tableLayout, "Licenca");
            AddCellToHeader(tableLayout, "Comprovante");



            // Corpo
            DataTable dt = conexao.executarSQL("SELECT * FROM tblLocalDeposito");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                AddCellToBody(tableLayout, dt.Rows[i]["ID_local_deposito"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["nome_depo"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["email_depo"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["codigo_depo"].ToString(), i);

                AddCellToBody(tableLayout, dt.Rows[i]["aprovado_depo"].ToString(), i);

                AddCellToBody(tableLayout, ByteArrayToHexString(dt.Rows[i]["CNPJ_depo"] as byte[]), i);
                AddCellToBody(tableLayout, ByteArrayToHexString(dt.Rows[i]["certificacao_depo"] as byte[]), i);
                AddCellToBody(tableLayout, ByteArrayToHexString(dt.Rows[i]["alvara_depo"] as byte[]), i);
                AddCellToBody(tableLayout, ByteArrayToHexString(dt.Rows[i]["licenca_depo"] as byte[]), i);
                AddCellToBody(tableLayout, ByteArrayToHexString(dt.Rows[i]["comprovante_depo"] as byte[]), i);

  

            }

            return tableLayout;
        }

        private void btnFecharPDF_Click(object sender, EventArgs e)
        {

            if (pdfViewer != null)
            {
                if (pdfDocument != null)
                {
                    pdfDocument.Dispose();
                    pdfDocument = null;
                }

                this.Controls.Remove(pdfViewer);
                pdfViewer.Dispose();
                pdfViewer = null;
            }

            // Restaura controles visíveis
            foreach (Control ctrl in controlesVisiveisAntesPDF)
            {
                ctrl.Visible = true;
            }

            btnFecharPDF.Visible = false;
        }

        private void btnFecharPDF_Click_1(object sender, EventArgs e)
        {

            if (pdfViewer != null)
            {
                if (pdfDocument != null)
                {
                    pdfDocument.Dispose();
                    pdfDocument = null;
                }

                this.Controls.Remove(pdfViewer);
                pdfViewer.Dispose();
                pdfViewer = null;
            }

            // Restaura controles visíveis
            foreach (Control ctrl in controlesVisiveisAntesPDF)
            {
                ctrl.Visible = true;
            }

            btnFecharPDF.Visible = false;
        }
    }
}
