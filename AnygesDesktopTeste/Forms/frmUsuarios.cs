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
    public partial class frmUsuarios : Form
    {
        ClasseConexao conexao = new ClasseConexao();
        DataTable dt;
        PdfiumViewer.PdfViewer pdf;
        private PdfiumViewer.PdfDocument pdfDocument = null;
        private PdfViewer pdfViewer = null;
        public frmUsuarios()
        {
            InitializeComponent();
            pdf = new PdfiumViewer.PdfViewer();
            pdf.Dock = DockStyle.Fill;
            pdf.Visible = false;
            this.Controls.Add(pdf);
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.CellClick += dataGridView1_CellClick;
            CarregarGrid();
            PreencherTextBoxes(0);
            BloquearTextBoxes();
            btnFecharPDF.Visible = false;
        }
        private void CarregarGrid()
        {

            string sql = "SELECT * FROM tblUsuario";

            try
            {
                DataTable dt = conexao.executarSQL(sql);
                dataGridView1.DataSource = dt;
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
                txtId.Text = dataGridView1.Rows[rowIndex].Cells["ID_usuario"].Value?.ToString();
                txtNome.Text = dataGridView1.Rows[rowIndex].Cells["nome_usuario"].Value?.ToString();
                txtSobrenome.Text = dataGridView1.Rows[rowIndex].Cells["sobrenome_usuario"].Value?.ToString();
                txtCpf.Text = dataGridView1.Rows[rowIndex].Cells["cpf"].Value?.ToString();
                txtTelefone.Text = dataGridView1.Rows[rowIndex].Cells["telefone_usuario"].Value?.ToString();
                txtEmail.Text = dataGridView1.Rows[rowIndex].Cells["email_usuario"].Value?.ToString();
                txtSenha.Text = dataGridView1.Rows[rowIndex].Cells["senha_usuario"].Value?.ToString();

                if (dataGridView1.Rows[rowIndex].Cells["dt_nascimento"].Value != DBNull.Value)
                {
                    DateTime dataNascimento = (DateTime)dataGridView1.Rows[rowIndex].Cells["dt_nascimento"].Value;
                    txtDataNascimento.Text = dataNascimento.ToString("yyyy-MM-dd");
                }
            }
        }


        private void BtnConcluido_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                SqlCommand cmd = new SqlCommand(@"UPDATE tblUsuario SET 
            nome_usuario = @Nome,
            sobrenome_usuario = @Sobrenome,
            cpf = @Cpf,
            telefone_usuario = @Telefone,
            email_usuario = @Email,
            senha_usuario = @Senha,
            dt_nascimento = @DataNascimento
            WHERE ID_usuario = @Id");

                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Sobrenome", txtSobrenome.Text);
                cmd.Parameters.AddWithValue("@Cpf", txtCpf.Text);
                cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                if (DateTime.TryParse(txtDataNascimento.Text, out DateTime dtNasc))
                    cmd.Parameters.AddWithValue("@DataNascimento", dtNasc);
                else
                    cmd.Parameters.AddWithValue("@DataNascimento", DBNull.Value);

                cmd.Parameters.AddWithValue("@Id", txtId.Text);

                conexao.manutencaoDB_Parametros(cmd);
                CarregarGrid();
                BloquearTextBoxes();
            }
        }
        private void BloquearTextBoxes()
        {

            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtDataNascimento.ReadOnly = true;
            txtId.ReadOnly = true;
            txtSenha.ReadOnly = true;
        }

        private void LiberarTextBoxes()
        {
            txtNome.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtCpf.ReadOnly = false;
            txtTelefone.ReadOnly = false;
            txtDataNascimento.ReadOnly = false;
            txtId.ReadOnly = false;
            txtSenha.ReadOnly = false;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            PreencherTextBoxes(0);
            BloquearTextBoxes();
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {

            LiberarTextBoxes();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                PreencherTextBoxes(e.RowIndex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tblUsuario WHERE nome_usuario LIKE @busca";
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Parameters.AddWithValue("@busca", "%" + TxtFiltro.Text + "%");

            ClasseConexao con = new ClasseConexao();
            DataTable dt = con.executarSQL_Parametros(cmd);

            if (dt != null && dt.Rows.Count > 0)
            {
                txtNome.Text = dt.Rows[0]["nome_usuario"].ToString();
                txtEmail.Text = dt.Rows[0]["email_usuario"].ToString();
                txtCpf.Text = dt.Rows[0]["cpf"].ToString();
                txtSobrenome.Text = dt.Rows[0]["sobrenome_usuario"].ToString();
                txtTelefone.Text = dt.Rows[0]["telefone_usuario"].ToString();
                txtDataNascimento.Text = dt.Rows[0]["dt_nascimento"].ToString();
                txtId.Text = dt.Rows[0]["Id_usuario"].ToString();
                txtSenha.Text = dt.Rows[0]["senha_usuario"].ToString();


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
        protected PdfPTable corpo_documento(PdfPTable tableLayout)
        {
            float[] headers = { 10, 30, 30, 20, 20, 15, 20 };
            tableLayout.SetWidths(headers);
            tableLayout.WidthPercentage = 100;
            tableLayout.HeaderRows = 1;

            AddCellToHeader(tableLayout, "Id");
            AddCellToHeader(tableLayout, "Nome");
            AddCellToHeader(tableLayout, "Sobrenome");
            AddCellToHeader(tableLayout, "Email");
            AddCellToHeader(tableLayout, "CPF");
            AddCellToHeader(tableLayout, "Telefone");
            AddCellToHeader(tableLayout, "Data de Nascimento");
            
         


            // Corpo
            DataTable dt = conexao.executarSQL("SELECT * FROM tblUsuario ");

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                AddCellToBody(tableLayout, dt.Rows[i]["Id_usuario"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["nome_usuario"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["sobrenome_usuario"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["email_usuario"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["cpf"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["telefone_usuario"].ToString(), i);
                AddCellToBody(tableLayout, dt.Rows[i]["dt_nascimento"].ToString(), i);
            }

            return tableLayout;
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
            saveFileDialog.FileName = "RelatorioUsuários.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);
                        PdfWriter.GetInstance(document, stream);

                        document.Open();

                        PdfPTable tableLayout = new PdfPTable(7);
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
    }

}