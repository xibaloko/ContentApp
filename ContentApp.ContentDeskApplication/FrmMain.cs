using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContentApp.ContentDeskApplication
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(ServiceProvider serviceProvider)
        {
            InitializeComponent();
        }
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProdutos frm = new FrmCadastroProdutos();
            frm.ShowDialog();
        }
    }
}
