using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrewingLog
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void nBrewBtn_Click(object sender, EventArgs e)
        {
            Brew newBrew = new Brew();
            newBrew.Text = "New Brew";
            newBrew.ShowDialog();
        }

        private void ldBrewBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = Application.StartupPath + @"\brewing\";

            DialogResult res = op.ShowDialog();

            if (res == DialogResult.OK)
            {
                Beer loaded = new Beer(Serial<Beer>.Load(op.FileName));

                Brew loadBrew = new Brew(loaded);
                loadBrew.Text = "Batch number: " + loaded.ID;
                loadBrew.ShowDialog();
            }
        }
    }
}
