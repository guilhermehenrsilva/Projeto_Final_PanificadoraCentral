using PANIFICADORACENTRAL;
using System.Drawing.Text;
using System.Windows.Forms;

namespace PANIFICADORA_CENTRAL_2
{
    public partial class FrmPrincipal : Form
    {
        private Form frmAtivo;    // vai controlar o form filho que esta aberto no form principal, que vai chamar fmrAtivo

        public FrmPrincipal() => InitializeComponent();

        private void formShow(Form frm)
        {
            activeFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void activeFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }
        private void activeButton (Button frmAtivo)
        {
            foreach (Control ctrl in panelPrincipal.Controls)
                ctrl.ForeColor = Color.White;
            frmAtivo.ForeColor = Color.Black;
        }
       private void btnHome_Click_1(object sender, EventArgs e)
       {
            activeButton(btnHome);
            activeFormClose();
        }
        private void btnClientes_Click_1(object sender, EventArgs e)
        
        {
            activeButton(btnClientes);
            formShow(new frmClientes());
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            activeButton(btnFornecedores);
            formShow(new frmFornecedores());
        }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            activeButton(btnSair);
            activeFormClose();
            Application.Exit();
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}