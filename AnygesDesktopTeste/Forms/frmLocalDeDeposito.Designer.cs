
namespace AnygesDesktopTeste.Forms
{
    partial class frmLocalDeDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDeDeposito));
            this.painelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomeForm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPesoDoacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCargoFunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtDataDoacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.lblConteudoQRCode = new System.Windows.Forms.Label();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // painelMenu
            // 
            this.painelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.painelMenu.Controls.Add(this.pictureBox2);
            this.painelMenu.Controls.Add(this.lblNomeForm);
            this.painelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelMenu.Location = new System.Drawing.Point(0, 0);
            this.painelMenu.Name = "painelMenu";
            this.painelMenu.Size = new System.Drawing.Size(776, 58);
            this.painelMenu.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 57);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // lblNomeForm
            // 
            this.lblNomeForm.AutoSize = true;
            this.lblNomeForm.Font = new System.Drawing.Font("Inria Sans", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForm.ForeColor = System.Drawing.Color.White;
            this.lblNomeForm.Location = new System.Drawing.Point(227, 9);
            this.lblNomeForm.Name = "lblNomeForm";
            this.lblNomeForm.Size = new System.Drawing.Size(306, 34);
            this.lblNomeForm.TabIndex = 0;
            this.lblNomeForm.Text = "CENTRO DE TRATAMENTO";
            this.lblNomeForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(432, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 262);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Inria Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(214, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "GERAR QR-CODE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPesoDoacao
            // 
            this.txtPesoDoacao.Location = new System.Drawing.Point(224, 268);
            this.txtPesoDoacao.Name = "txtPesoDoacao";
            this.txtPesoDoacao.Size = new System.Drawing.Size(172, 20);
            this.txtPesoDoacao.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME FUNCIONÁRIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label4.Location = new System.Drawing.Point(59, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "PESO DA DOAÇÃO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label3.Location = new System.Drawing.Point(183, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID:";
            // 
            // txtCargoFunc
            // 
            this.txtCargoFunc.Location = new System.Drawing.Point(224, 136);
            this.txtCargoFunc.Name = "txtCargoFunc";
            this.txtCargoFunc.Size = new System.Drawing.Size(172, 20);
            this.txtCargoFunc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label2.Location = new System.Drawing.Point(146, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "CARGO:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(224, 90);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(172, 20);
            this.txtNomeFunc.TabIndex = 7;
            // 
            // txtDataDoacao
            // 
            this.txtDataDoacao.Location = new System.Drawing.Point(224, 225);
            this.txtDataDoacao.Name = "txtDataDoacao";
            this.txtDataDoacao.Size = new System.Drawing.Size(172, 20);
            this.txtDataDoacao.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label5.Location = new System.Drawing.Point(60, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "DATA DA DOAÇÃO:";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(224, 179);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(172, 20);
            this.txtIdFunc.TabIndex = 9;
            // 
            // lblConteudoQRCode
            // 
            this.lblConteudoQRCode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConteudoQRCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblConteudoQRCode.Location = new System.Drawing.Point(429, 329);
            this.lblConteudoQRCode.Name = "lblConteudoQRCode";
            this.lblConteudoQRCode.Size = new System.Drawing.Size(274, 100);
            this.lblConteudoQRCode.TabIndex = 22;
            // 
            // frmLocalDeDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 438);
            this.Controls.Add(this.lblConteudoQRCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDataDoacao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPesoDoacao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdFunc);
            this.Controls.Add(this.txtCargoFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.painelMenu);
            this.Name = "frmLocalDeDeposito";
            this.Text = " ";
            this.painelMenu.ResumeLayout(false);
            this.painelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.Label lblNomeForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPesoDoacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCargoFunc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDataDoacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.Label lblConteudoQRCode;
    }
}