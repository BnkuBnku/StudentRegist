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
    public partial class FrmSR : Form
    {
        public FrmSR()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtFN.Clear();
            txtLN.Clear();
            txtMN.Clear();
            RtxtAdd.Clear();
            txtFN.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                txtFN.Text,
                txtLN.Text,
                txtMN.Text,
                Convert.ToInt32(txtA.Text),
                RtxtAdd.Text
                );
            FrmSubmitted frmSubmitted = new FrmSubmitted("Thank you for Registering, " + txtLN.Text + ".");
            frmSubmitted.Show();

            StudentInfo studentinfo = new StudentInfo(student);
            studentinfo.Show();
        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumber.NumberOnly(sender, e);
        }
    }
}
