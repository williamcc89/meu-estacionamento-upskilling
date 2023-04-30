namespace Meu_estacionamento.Forms
{
    partial class FormEntradaSaida
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
            this.lblTituloTela = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.btnCadastrarEntrada = new System.Windows.Forms.Button();
            this.btnCadastrarSaida = new System.Windows.Forms.Button();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.edtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTempoPermanencia = new System.Windows.Forms.Label();
            this.lblPermanencia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarMovimentacao = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTituloTela
            // 
            this.lblTituloTela.AutoSize = true;
            this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTela.Location = new System.Drawing.Point(12, 9);
            this.lblTituloTela.Name = "lblTituloTela";
            this.lblTituloTela.Size = new System.Drawing.Size(278, 26);
            this.lblTituloTela.TabIndex = 19;
            this.lblTituloTela.Text = "Entrada/Saída de veículo";
            this.lblTituloTela.Click += new System.EventHandler(this.lblTituloTela_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(65, 42);
            this.txtPlaca.Mask = "#######";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(225, 20);
            this.txtPlaca.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Placa:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(19, 72);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(249, 13);
            this.lblNomeCliente.TabIndex = 25;
            this.lblNomeCliente.Text = "William Cleisson de Carvalho - CPF 123.456.789-09";
            // 
            // btnCadastrarEntrada
            // 
            this.btnCadastrarEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarEntrada.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnCadastrarEntrada.Location = new System.Drawing.Point(36, 99);
            this.btnCadastrarEntrada.Name = "btnCadastrarEntrada";
            this.btnCadastrarEntrada.Size = new System.Drawing.Size(107, 23);
            this.btnCadastrarEntrada.TabIndex = 26;
            this.btnCadastrarEntrada.Text = "Entrada";
            this.btnCadastrarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarSaida
            // 
            this.btnCadastrarSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarSaida.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnCadastrarSaida.Location = new System.Drawing.Point(152, 99);
            this.btnCadastrarSaida.Name = "btnCadastrarSaida";
            this.btnCadastrarSaida.Size = new System.Drawing.Size(107, 23);
            this.btnCadastrarSaida.TabIndex = 27;
            this.btnCadastrarSaida.Text = "Saída";
            this.btnCadastrarSaida.UseVisualStyleBackColor = true;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntrada.Location = new System.Drawing.Point(16, 138);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(55, 13);
            this.lblEntrada.TabIndex = 28;
            this.lblEntrada.Text = "Entrada:";
            // 
            // edtEntrada
            // 
            this.edtEntrada.Location = new System.Drawing.Point(77, 135);
            this.edtEntrada.Mask = "##/##/#### ##:##";
            this.edtEntrada.Name = "edtEntrada";
            this.edtEntrada.Size = new System.Drawing.Size(213, 20);
            this.edtEntrada.TabIndex = 29;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(77, 161);
            this.maskedTextBox1.Mask = "##/##/#### ##:##";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(213, 20);
            this.maskedTextBox1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Saída:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTempoPermanencia
            // 
            this.lblTempoPermanencia.AutoSize = true;
            this.lblTempoPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoPermanencia.Location = new System.Drawing.Point(13, 192);
            this.lblTempoPermanencia.Name = "lblTempoPermanencia";
            this.lblTempoPermanencia.Size = new System.Drawing.Size(199, 13);
            this.lblTempoPermanencia.TabIndex = 32;
            this.lblTempoPermanencia.Text = "Tempo de Permanência (minutos):";
            this.lblTempoPermanencia.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPermanencia
            // 
            this.lblPermanencia.AutoSize = true;
            this.lblPermanencia.Location = new System.Drawing.Point(16, 209);
            this.lblPermanencia.Name = "lblPermanencia";
            this.lblPermanencia.Size = new System.Drawing.Size(19, 13);
            this.lblPermanencia.TabIndex = 33;
            this.lblPermanencia.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "R$ 000,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Valor total a pagar:";
            // 
            // btnCadastrarMovimentacao
            // 
            this.btnCadastrarMovimentacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMovimentacao.Location = new System.Drawing.Point(16, 304);
            this.btnCadastrarMovimentacao.Name = "btnCadastrarMovimentacao";
            this.btnCadastrarMovimentacao.Size = new System.Drawing.Size(274, 23);
            this.btnCadastrarMovimentacao.TabIndex = 36;
            this.btnCadastrarMovimentacao.Text = "Salvar Entrada/Saída";
            this.btnCadastrarMovimentacao.UseVisualStyleBackColor = true;
            this.btnCadastrarMovimentacao.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Forma de Pagamento:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 38;
            // 
            // FormEntradaSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 337);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrarMovimentacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPermanencia);
            this.Controls.Add(this.lblTempoPermanencia);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtEntrada);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.btnCadastrarSaida);
            this.Controls.Add(this.btnCadastrarEntrada);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTituloTela);
            this.Name = "FormEntradaSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada/Saída de veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloTela;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Button btnCadastrarEntrada;
        private System.Windows.Forms.Button btnCadastrarSaida;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.MaskedTextBox edtEntrada;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTempoPermanencia;
        private System.Windows.Forms.Label lblPermanencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCadastrarMovimentacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}