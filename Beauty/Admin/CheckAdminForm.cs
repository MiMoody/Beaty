using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beauty
{
    public partial class CheckAdminForm : Form
    {
        public CheckAdminForm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            new Mainform().Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            TxtPass.Text.Trim();
            if (!string.IsNullOrEmpty(TxtPass.Text) && TxtPass.Text == "0000")
            {
                new ClientForm(true).Show();
                this.Close();
            }
            else MessageBox.Show("Пароль не верный!!!");
        }
    }
}
