namespace Meu_estacionamento.Reports
{
    partial class FormRelReceitaDiaria
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
            this.gridReceitaDiaria = new System.Windows.Forms.DataGridView();
            this.lblTituloTela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReceitaTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridReceitaDiaria)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReceitaDiaria
            // 
            this.gridReceitaDiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReceitaDiaria.Location = new System.Drawing.Point(15, 39);
            this.gridReceitaDiaria.Name = "gridReceitaDiaria";
            this.gridReceitaDiaria.Size = new System.Drawing.Size(775, 401);
            this.gridReceitaDiaria.TabIndex = 23;
            // 
            // lblTituloTela
            // 
            this.lblTituloTela.AutoSize = true;
            this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTela.Location = new System.Drawing.Point(10, 10);
            this.lblTituloTela.Name = "lblTituloTela";
            this.lblTituloTela.Size = new System.Drawing.Size(159, 26);
            this.lblTituloTela.TabIndex = 22;
            this.lblTituloTela.Text = "Receita diária";
            this.lblTituloTela.Click += new System.EventHandler(this.lblTituloTela_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(577, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total:";
            // 
            // lblReceitaTotal
            // 
            this.lblReceitaTotal.AutoSize = true;
            this.lblReceitaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceitaTotal.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblReceitaTotal.Location = new System.Drawing.Point(654, 9);
            this.lblReceitaTotal.Name = "lblReceitaTotal";
            this.lblReceitaTotal.Size = new System.Drawing.Size(134, 26);
            this.lblReceitaTotal.TabIndex = 25;
            this.lblReceitaTotal.Text = "R$ 0000,00";
            // 
            // FormRelReceitaDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReceitaTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridReceitaDiaria);
            this.Controls.Add(this.lblTituloTela);
            this.Name = "FormRelReceitaDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receita Diária";
            ((System.ComponentModel.ISupportInitialize)(this.gridReceitaDiaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridReceitaDiaria;
        private System.Windows.Forms.Label lblTituloTela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReceitaTotal;
    }
}