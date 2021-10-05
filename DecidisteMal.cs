using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Te_juzgo_el_helado
{
    public partial class DecidisteMal : Form
    {
        public DecidisteMal()
        {
            InitializeComponent();
        }

        private void DecidisteMal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Environment.Exit(1);
        }
    }
}
