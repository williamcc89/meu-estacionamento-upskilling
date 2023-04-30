namespace Meu_estacionamento.Reports
{
    partial class FormRelVeiculosEstacionados
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
            this.gridVeiculosEstacionados = new System.Windows.Forms.DataGridView();
            this.lblTituloTela = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculosEstacionados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVeiculosEstacionados
            // 
            this.gridVeiculosEstacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVeiculosEstacionados.Location = new System.Drawing.Point(15, 39);
            this.gridVeiculosEstacionados.Name = "gridVeiculosEstacionados";
            this.gridVeiculosEstacionados.Size = new System.Drawing.Size(775, 401);
            this.gridVeiculosEstacionados.TabIndex = 21;
            // 
            // lblTituloTela
            // 
            this.lblTituloTela.AutoSize = true;
            this.lblTituloTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTela.Location = new System.Drawing.Point(10, 10);
            this.lblTituloTela.Name = "lblTituloTela";
            this.lblTituloTela.Size = new System.Drawing.Size(250, 26);
            this.lblTituloTela.TabIndex = 20;
            this.lblTituloTela.Text = "Veículos estacionados";
            this.lblTituloTela.Click += new System.EventHandler(this.lblTituloTela_Click);
            // 
            // FormRelVeiculosEstacionados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridVeiculosEstacionados);
            this.Controls.Add(this.lblTituloTela);
            this.Name = "FormRelVeiculosEstacionados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veículos Estacionados";
            ((System.ComponentModel.ISupportInitialize)(this.gridVeiculosEstacionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVeiculosEstacionados;
        private System.Windows.Forms.Label lblTituloTela;
    }
}