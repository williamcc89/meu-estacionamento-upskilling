namespace Meu_estacionamento.Forms
{
    partial class FormConfigurarPreco
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
            this.btnSalvarConfiguracaoPreco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTituloTela = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalvarConfiguracaoPreco
            // 
            this.btnSalvarConfiguracaoPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarConfiguracaoPreco.Location = new System.Drawing.Point(17, 80);
            this.btnSalvarConfiguracaoPreco.Name = "btnSalvarConfiguracaoPreco";
            this.btnSalvarConfiguracaoPreco.Size = new System.Drawing.Size(297, 23);
            this.btnSalvarConfiguracaoPreco.TabIndex = 40;
            this.btnSalvarConfiguracaoPreco.Text = "Salvar Configuração";
            this.btnSalvarConfiguracaoPreco.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Valor (R$):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTituloTela
            // 
            this.lblTituloTela.AutoSize = true;
            this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTela.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTela.Name = "lblTituloTela";
            this.lblTituloTela.Size = new System.Drawing.Size(302, 26);
            this.lblTituloTela.TabIndex = 37;
            this.lblTituloTela.Text = "Configurar valor por minuto";
            this.lblTituloTela.Click += new System.EventHandler(this.lblTituloTela_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 41;
            // 
            // FormConfigurarPreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 119);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSalvarConfiguracaoPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloTela);
            this.Name = "FormConfigurarPreco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormConfigurarPreco";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvarConfiguracaoPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTituloTela;
        private System.Windows.Forms.TextBox textBox1;
    }
}