
namespace AnygesDesktopTeste.Forms
{
    partial class frmGerenciarCupons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarCupons));
            this.painelMenu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNomeForm = new System.Windows.Forms.Label();
            this.txtPesquisarCupom = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDisponivel = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAprovado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBoxCupom = new System.Windows.Forms.PictureBox();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.painelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCupom)).BeginInit();
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
            this.painelMenu.Size = new System.Drawing.Size(814, 57);
            this.painelMenu.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(26)))), ((int)(((byte)(24)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(208, -3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 57);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lblNomeForm
            // 
            this.lblNomeForm.AutoSize = true;
            this.lblNomeForm.Font = new System.Drawing.Font("Inria Sans", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblNomeForm.ForeColor = System.Drawing.Color.White;
            this.lblNomeForm.Location = new System.Drawing.Point(281, 9);
            this.lblNomeForm.Name = "lblNomeForm";
            this.lblNomeForm.Size = new System.Drawing.Size(248, 34);
            this.lblNomeForm.TabIndex = 0;
            this.lblNomeForm.Text = "GERENCIAR CUPONS";
            this.lblNomeForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPesquisarCupom
            // 
            this.txtPesquisarCupom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarCupom.Location = new System.Drawing.Point(184, 65);
            this.txtPesquisarCupom.Name = "txtPesquisarCupom";
            this.txtPesquisarCupom.Size = new System.Drawing.Size(369, 20);
            this.txtPesquisarCupom.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnPesquisar.Font = new System.Drawing.Font("Inria Sans", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPesquisar.Location = new System.Drawing.Point(559, 61);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 27);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar 🔍";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inria Sans", 18F);
            this.label1.Location = new System.Drawing.Point(105, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtro:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(171, 97);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(172, 20);
            this.txtId.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label2.Location = new System.Drawing.Point(68, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID CUPOM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label3.Location = new System.Drawing.Point(35, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "NOME CUPOM:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 123);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label4.Location = new System.Drawing.Point(97, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "VALOR:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(171, 149);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(172, 20);
            this.txtValor.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label5.Location = new System.Drawing.Point(112, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "TIPO:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(171, 175);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(172, 20);
            this.txtTipo.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label6.Location = new System.Drawing.Point(50, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "DISPONÍVEL:";
            // 
            // txtDisponivel
            // 
            this.txtDisponivel.Location = new System.Drawing.Point(171, 201);
            this.txtDisponivel.Name = "txtDisponivel";
            this.txtDisponivel.Size = new System.Drawing.Size(172, 20);
            this.txtDisponivel.TabIndex = 26;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(171, 227);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(172, 20);
            this.txtDesconto.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label7.Location = new System.Drawing.Point(62, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "DESCONTO:";
            // 
            // txtAprovado
            // 
            this.txtAprovado.Location = new System.Drawing.Point(171, 253);
            this.txtAprovado.Name = "txtAprovado";
            this.txtAprovado.Size = new System.Drawing.Size(172, 20);
            this.txtAprovado.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label9.Location = new System.Drawing.Point(61, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 24);
            this.label9.TabIndex = 30;
            this.label9.Text = "APROVADO:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(171, 279);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(172, 142);
            this.txtDescricao.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inria Sans", 14.25F);
            this.label8.Location = new System.Drawing.Point(59, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 32;
            this.label8.Text = "DESCRIÇÃO:";
            // 
            // pictureBoxCupom
            // 
            this.pictureBoxCupom.Location = new System.Drawing.Point(431, 97);
            this.pictureBoxCupom.Name = "pictureBoxCupom";
            this.pictureBoxCupom.Size = new System.Drawing.Size(359, 313);
            this.pictureBoxCupom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCupom.TabIndex = 34;
            this.pictureBoxCupom.TabStop = false;
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnVoltar.Font = new System.Drawing.Font("Inria Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnVoltar.Location = new System.Drawing.Point(417, 436);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(267, 38);
            this.BtnVoltar.TabIndex = 37;
            this.BtnVoltar.Text = "VOLTAR PARA GERAR CUPONS";
            this.BtnVoltar.UseVisualStyleBackColor = false;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Inria Sans", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(116, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 38);
            this.button1.TabIndex = 38;
            this.button1.Text = "DELETAR CUPOM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGerenciarCupons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 498);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.pictureBoxCupom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAprovado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtDisponivel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisarCupom);
            this.Controls.Add(this.painelMenu);
            this.Name = "frmGerenciarCupons";
            this.Text = "frmGerenciarCupons";
            this.painelMenu.ResumeLayout(false);
            this.painelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCupom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblNomeForm;
        private System.Windows.Forms.TextBox txtPesquisarCupom;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDisponivel;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAprovado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBoxCupom;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Button button1;
    }
}