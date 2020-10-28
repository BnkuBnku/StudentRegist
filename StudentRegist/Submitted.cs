using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegist
{
    public partial class FrmSubmitted : Form
    {
        private string name;

        public FrmSubmitted()
        {
            InitializeComponent();
        }

        public FrmSubmitted(string name) : this()
        {
            this.name = name;
        }

        private void FrmSubmitted_Load(object sender, EventArgs e)
        {
            lblTY.Text = name;
        }
    }
}
