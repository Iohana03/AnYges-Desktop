
namespace AnygesDesktopTeste.Forms
{
    partial class A
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A));
            this.painelMenu = new System.Windows.Forms.Panel();
            this.lblNomeForm = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtIdAssoc = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDisponivel = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtAprovado = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSelecionarImagem = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnGerencia = new System.Windows.Forms.Button();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.painelMenu.Controls.Add(this.lblNomeForm);
            this.painelMenu.Controls.Add(this.pictureBox2);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(814, 58);
            this.painelMenu.TabIndex = 3;
            // 
            // lblNomeForm
            // 
            this.lblNomeForm.AutoSize = true;
            this.lblNomeForm.Font = new System.Drawing.Font("Inria Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForm.ForeColor = System.Drawing.Color.White;
            this.lblNomeForm.Location = new System.Drawing.Point(328, 9);
            this.lblNomeForm.Name = "lblNomeForm";
            this.lblNomeForm.Size = new System.Drawing.Size(159, 34);
            this.lblNomeForm.TabIndex = 10;
            this.lblNomeForm.Text = "ASSOCIAÇÃO";
            this.lblNomeForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(255, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 57);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // txtIdAssoc
            // 
            this.txtIdAssoc.Location = new System.Drawing.Point(173, 70);
            this.txtIdAssoc.Name = "txtIdAssoc";
            this.txtIdAssoc.Size = new System.Drawing.Size(172, 20);
            this.txtIdAssoc.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(173, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(173, 128);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(172, 20);
            this.txtValor.TabIndex = 10;
            // 
            // txtDisponivel
            // 
            this.txtDisponivel.Location = new System.Drawing.Point(173, 183);
            this.txtDisponivel.Name = "txtDisponivel";
            this.txtDisponivel.Size = new System.Drawing.Size(172, 20);
            this.txtDisponivel.TabIndex = 11;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(173, 157);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(172, 20);
            this.txtTipo.TabIndex = 12;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(173, 209);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(172, 20);
            this.txtDesconto.TabIndex = 13;
            // 
            // txtAprovado
            // 
            this.txtAprovado.Location = new System.Drawing.Point(173, 237);
            this.txtAprovado.Name = "txtAprovado";
            this.txtAprovado.Size = new System.Drawing.Size(172, 20);
            this.txtAprovado.TabIndex = 14;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(173, 271);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(172, 130);
            this.txtDescricao.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID ASSOCIAÇÃO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "NOME CUPOM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label3.Location = new System.Drawing.Point(99, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "VALOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label4.Location = new System.Drawing.Point(52, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "DISPONÍVEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label5.Location = new System.Drawing.Point(114, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "TIPO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label6.Location = new System.Drawing.Point(61, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "DESCRIÇÃO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label7.Location = new System.Drawing.Point(64, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 23;
            this.label7.Text = "DESCONTO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label8.Location = new System.Drawing.Point(520, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 24);
            this.label8.TabIndex = 24;
            this.label8.Text = "IMAGEM CUPOM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label9.Location = new System.Drawing.Point(64, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 25;
            this.label9.Text = "APROVADO:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Inria Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 38);
            this.button1.TabIndex = 26;
            this.button1.Text = "GERAR CUPOM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(417, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 313);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnSelecionarImagem
            // 
            this.btnSelecionarImagem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSelecionarImagem.Font = new System.Drawing.Font("Inria Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSelecionarImagem.Location = new System.Drawing.Point(529, 406);
            this.btnSelecionarImagem.Name = "btnSelecionarImagem";
            this.btnSelecionarImagem.Size = new System.Drawing.Size(136, 33);
            this.btnSelecionarImagem.TabIndex = 33;
            this.btnSelecionarImagem.Text = "ADICIONAR IMAGEM";
            this.btnSelecionarImagem.UseVisualStyleBackColor = false;
            this.btnSelecionarImagem.Click += new System.EventHandler(this.btnSelecionarImagem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnGerencia
            // 
            this.BtnGerencia.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnGerencia.Font = new System.Drawing.Font("Inria Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGerencia.Location = new System.Drawing.Point(417, 445);
            this.BtnGerencia.Name = "BtnGerencia";
            this.BtnGerencia.Size = new System.Drawing.Size(273, 38);
            this.BtnGerencia.TabIndex = 34;
            this.BtnGerencia.Text = "GERENCIAR CUPONS";
            this.BtnGerencia.UseVisualStyleBackColor = false;
            this.BtnGerencia.Click += new System.EventHandler(this.BtnGerencia_Click);
            // 
            // A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 487);
            this.Controls.Add(this.BtnGerencia);
            this.Controls.Add(this.btnSelecionarImagem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtAprovado);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtDisponivel);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdAssoc);
            this.Controls.Add(this.painelMenu);
            this.Name = "A";
            this.Text = "Gerar Cupom";
            this.Load += new System.EventHandler(this.A_Load);
            this.painelMenu.ResumeLayout(false);
            this.painelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNomeForm;
        private System.Windows.Forms.TextBox txtIdAssoc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtDisponivel;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtAprovado;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSelecionarImagem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnGerencia;
    }
}