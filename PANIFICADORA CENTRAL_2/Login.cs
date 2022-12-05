using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANIFICADORA_CENTRAL_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textUser.Text.Equals("Adm") &&
               textSenha.Text.Equals("123"))
            {
                FrmPrincipal Sis = new FrmPrincipal();
                this.Hide();
                Sis.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("Usuario ou senha incorreta");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
