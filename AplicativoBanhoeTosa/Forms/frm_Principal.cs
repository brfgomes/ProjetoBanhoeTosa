using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicativoBanhoeTosa
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void donoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Dono objfrm_Dono = new frm_Dono();
            objfrm_Dono.ShowDialog();
        }

        private void cachorroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cachorro objfrm_Cachorro = new frm_Cachorro();
            objfrm_Cachorro.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Servico objfrm_Servico = new frm_Servico();
            objfrm_Servico.ShowDialog();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void agendarTrabalhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Trabalho objfrm_Trabalho = new frm_Trabalho();
            objfrm_Trabalho.ShowDialog();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tim_Principal_Tick(object sender, EventArgs e)
        {
            tssLabel_DtAgora.Text = DateTime.Now.ToString("dd/mm/yyyy");
            tssLabel_HrAgora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
