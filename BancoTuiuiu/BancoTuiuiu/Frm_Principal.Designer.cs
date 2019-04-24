namespace BancoTuiuiu
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_conta = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.tx_nome = new System.Windows.Forms.TextBox();
            this.txt_conta = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_saque = new System.Windows.Forms.Button();
            this.btn_deposito = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pnl_msg = new System.Windows.Forms.Panel();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(27, 129);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(38, 13);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_conta
            // 
            this.lbl_conta.AutoSize = true;
            this.lbl_conta.Location = new System.Drawing.Point(28, 208);
            this.lbl_conta.Name = "lbl_conta";
            this.lbl_conta.Size = new System.Drawing.Size(38, 13);
            this.lbl_conta.TabIndex = 1;
            this.lbl_conta.Text = "Conta:";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(27, 274);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(37, 13);
            this.lbl_saldo.TabIndex = 2;
            this.lbl_saldo.Text = "Saldo:";
            // 
            // tx_nome
            // 
            this.tx_nome.Location = new System.Drawing.Point(71, 129);
            this.tx_nome.Multiline = true;
            this.tx_nome.Name = "tx_nome";
            this.tx_nome.Size = new System.Drawing.Size(304, 25);
            this.tx_nome.TabIndex = 3;
            // 
            // txt_conta
            // 
            this.txt_conta.Location = new System.Drawing.Point(71, 205);
            this.txt_conta.Multiline = true;
            this.txt_conta.Name = "txt_conta";
            this.txt_conta.Size = new System.Drawing.Size(304, 25);
            this.txt_conta.TabIndex = 4;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(71, 271);
            this.txt_saldo.Multiline = true;
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(304, 25);
            this.txt_saldo.TabIndex = 5;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(16, 374);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // btn_saque
            // 
            this.btn_saque.Location = new System.Drawing.Point(149, 374);
            this.btn_saque.Name = "btn_saque";
            this.btn_saque.Size = new System.Drawing.Size(75, 23);
            this.btn_saque.TabIndex = 7;
            this.btn_saque.Text = "SAQUE";
            this.btn_saque.UseVisualStyleBackColor = true;
            // 
            // btn_deposito
            // 
            this.btn_deposito.Location = new System.Drawing.Point(300, 374);
            this.btn_deposito.Name = "btn_deposito";
            this.btn_deposito.Size = new System.Drawing.Size(75, 23);
            this.btn_deposito.TabIndex = 8;
            this.btn_deposito.Text = "DEPOSITO";
            this.btn_deposito.UseVisualStyleBackColor = true;
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.Color.OrangeRed;
            this.pnl_1.Controls.Add(this.pictureBox1);
            this.pnl_1.Controls.Add(this.lbl_logo);
            this.pnl_1.Location = new System.Drawing.Point(16, 12);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(408, 80);
            this.pnl_1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoSize = true;
            this.lbl_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_logo.Location = new System.Drawing.Point(126, 15);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(258, 37);
            this.lbl_logo.TabIndex = 0;
            this.lbl_logo.Text = "BANCO TUIUIU";
            // 
            // pnl_msg
            // 
            this.pnl_msg.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnl_msg.Controls.Add(this.lbl_msg);
            this.pnl_msg.Location = new System.Drawing.Point(16, 313);
            this.pnl_msg.Name = "pnl_msg";
            this.pnl_msg.Size = new System.Drawing.Size(408, 35);
            this.pnl_msg.TabIndex = 10;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_msg.Location = new System.Drawing.Point(173, 11);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(37, 16);
            this.lbl_msg.TabIndex = 0;
            this.lbl_msg.Text = "msg";
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 428);
            this.Controls.Add(this.pnl_msg);
            this.Controls.Add(this.pnl_1);
            this.Controls.Add(this.btn_deposito);
            this.Controls.Add(this.btn_saque);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txt_conta);
            this.Controls.Add(this.tx_nome);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_conta);
            this.Controls.Add(this.lbl_nome);
            this.Name = "Frm_Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_msg.ResumeLayout(false);
            this.pnl_msg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_conta;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox tx_nome;
        private System.Windows.Forms.TextBox txt_conta;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_saque;
        private System.Windows.Forms.Button btn_deposito;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.Panel pnl_msg;
        private System.Windows.Forms.Label lbl_msg;
    }
}

