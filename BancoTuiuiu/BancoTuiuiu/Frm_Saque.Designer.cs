namespace BancoTuiuiu
{
    partial class Frm_Saque
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
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_confirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(23, 43);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_saldo.TabIndex = 0;
            this.lbl_saldo.Text = "Saldo";
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(64, 38);
            this.txt_saldo.Multiline = true;
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(181, 36);
            this.txt_saldo.TabIndex = 1;
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(23, 134);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(31, 13);
            this.lbl_valor.TabIndex = 2;
            this.lbl_valor.Text = "Valor";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(64, 127);
            this.txt_valor.Multiline = true;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(181, 34);
            this.txt_valor.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(26, 269);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(127, 54);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.Location = new System.Drawing.Point(244, 269);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(132, 54);
            this.btn_confirmar.TabIndex = 5;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.UseVisualStyleBackColor = true;
            // 
            // Frm_Saque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 346);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.lbl_saldo);
            this.Name = "Frm_Saque";
            this.Text = "Frm_Saque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_confirmar;
    }
}