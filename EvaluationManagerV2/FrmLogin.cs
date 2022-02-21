using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerV2
{
    public partial class FrmLogin : Form
    {
        private string username = "nastavnik";
        private string password = "test";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Unesite korisničke podatke!", "Upozorenje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    Hide();
                    var form = new FrmStudents();
                    form.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Neispravni korisnički podaci!");
                }
            }
        }
    }
}
