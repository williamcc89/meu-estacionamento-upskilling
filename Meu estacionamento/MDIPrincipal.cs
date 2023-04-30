using Meu_estacionamento.Forms;
using Meu_estacionamento.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_estacionamento
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void openFormClientes(object sender, EventArgs e)
        {
            FormClientes formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void openFormEntradaSaida(object sender, EventArgs e)
        {
            FormEntradaSaida formEntradaSaida = new FormEntradaSaida();
            formEntradaSaida.MdiParent = this;
            formEntradaSaida.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEstacionadosAtalho_Click(object sender, EventArgs e)
        {
            FormRelVeiculosEstacionados formEstacionados = new FormRelVeiculosEstacionados();
            formEstacionados.MdiParent = this;
            formEstacionados.Show();
        }

        private void btnReceitaDiariaAtalho_Click(object sender, EventArgs e)
        {
            FormRelReceitaDiaria formReceita = new FormRelReceitaDiaria();
            formReceita.MdiParent = this;
            formReceita.Show();
        }

        private void btnConfigurarPreco_Click(object sender, EventArgs e)
        {
            FormConfigurarPreco formConfigPreco = new FormConfigurarPreco();
            formConfigPreco.MdiParent = this;
            formConfigPreco.Show();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormSobre formSobre = new FormSobre();
            formSobre.MdiParent = this;
            formSobre.Show();
        }
    }
}
