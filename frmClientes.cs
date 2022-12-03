using PANIFICADORACENTRAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PANIFICADORA_CENTRAL_2
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
            listaCliente();
        }
        int idAlterar; // variavel global
        private void LimpaCamposAlt()
        {
            textCPFClialt.Text = "";
            textNomeCliAlt.Text = "";
            textdataCliAlt.Text = "";
            textTelCliAlt.Text = "";
            textEmailCliAlt.Text = "";
            textCidadeCliAlt.Text = "";
            textEnderecoCliAlt.Text = "";
            textBairroCliAlt.Text = "";
            textCepCliAlt.Text = "";
            textUfCliAlt.Text = "";
            textCPFCliente.Focus();
        }
        private void LimpaCampos()
        {
            {
                textCPFCliente.Text = "";
                textNomeCliente.Text = "";
                textTelCliente.Text = "";
                textEmailCliente.Text = "";
                textCidadeCliente.Text = "";
                textEnderecoCliente.Text = "";
                textBairroCliente.Text = "";
                textCEPCliente.Text = "";
                textUFCliente.Text = "";
                textdataCliente.Text = "";
                textCPFCliente.Focus();
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                Cliente C = new Cliente();
                C.CPF = textCPFCliente.Text;
                C.Nome = textNomeCliente.Text;                
                C.cidade = textCidadeCliente.Text;
                C.uf = textUFCliente.Text;   
                C.endereco = textEnderecoCliente.Text;
                C.bairro = textBairroCliente.Text;
                C.cep = textCEPCliente.Text;
                C.email = textEmailCliente.Text;
                C.Telefone = textTelCliente.Text;
                C.data = textdataCliente.Text;
               
           
                // enviar para o banco
                conectaBanco conecta = new conectaBanco();
                bool retorno = conecta.insereCliente2(C);
                if (retorno == true)
                {
                    MessageBox.Show("Dados inseridos com sucesso");
                }
                else
                    MessageBox.Show("erro");
                LimpaCampos();
                listaCliente();
            }
        }

        private void CLIENTES_Click(object sender, EventArgs e)
        {

        }

        private void textCPFCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmaAltera_Click(object sender, EventArgs e)
        {

            Cliente C = new Cliente();
            C.CPF = textCPFClialt.Text;
            C.Nome = textNomeCliAlt.Text;
            C.cidade = textCidadeCliAlt.Text;
            C.uf = textUfCliAlt.Text;
            C.endereco = textEnderecoCliAlt.Text;
            C.bairro = textBairroCliAlt.Text;
            C.cep = textCepCliAlt.Text;
            C.email = textEmailCliAlt.Text;
            C.Telefone = textTelCliAlt.Text;
            C.data = textdataCliAlt.Text;
            // enviar os dados para alterar
            conectaBanco conecta = new conectaBanco();
            bool retorno = conecta.new_alteraClientes(C, idAlterar);
            LimpaCamposAlt();
            MessageBox.Show("Cliente Alterado");
            listaCliente();
        }
        void listaCliente()
        {
            conectaBanco con = new conectaBanco();
            dgClientes.DataSource = con.listaClientes();
        }

        private void txtBuscaCliente_TextChanged(object sender, EventArgs e)
        {
            (dgClientes.DataSource as DataTable).DefaultView.RowFilter = String.Format("nomeCliente like'%{0}%'", txtBuscaCliente.Text);
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            int linha = dgClientes.CurrentRow.Index; // pega linha selecionada 
            textCPFClialt.Text = dgClientes.Rows[linha].Cells["CPF"].Value.ToString();
            textNomeCliAlt.Text = dgClientes.Rows[linha].Cells["Nome"].Value.ToString();
            textdataCliAlt.Text = dgClientes.Rows[linha].Cells["Data_Nascimento"].Value.ToString();
            textTelCliAlt.Text = dgClientes.Rows[linha].Cells["Telefone"].Value.ToString();
            textEmailCliAlt.Text = dgClientes.Rows[linha].Cells["email"].Value.ToString();
            textCidadeCliAlt.Text = dgClientes.Rows[linha].Cells["cidade"].Value.ToString();
            textEnderecoCliAlt.Text = dgClientes.Rows[linha].Cells["Endereço"].Value.ToString();
            textBairroCliAlt.Text = dgClientes.Rows[linha].Cells["bairro"].Value.ToString();
            textCepCliAlt.Text = dgClientes.Rows[linha].Cells["cep"].Value.ToString();
            textUfCliAlt.Text = dgClientes.Rows[linha].Cells["uf"].Value.ToString();

            tabControlClientes.SelectedTab = tabPage1; // muda aba
            listaCliente();
        }

        private void textEmailCliAlt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemoveCliente_Click(object sender, EventArgs e)
        {
            int linha = dgClientes.CurrentRow.Index; // pega linha selecionada 
            string cpf = dgClientes.Rows[linha].Cells["cpf"].Value.ToString();
            DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remove Cliente", MessageBoxButtons.OKCancel);
            if (resp == DialogResult.OK)
            {
                conectaBanco conecta = new conectaBanco();
                bool retorno = conecta.new_deleteCliente(cpf);
                if (retorno == true)
                    MessageBox.Show("Cliente excluido");
                else
                    lblmsgerro.Text = conecta.mensagem;
                listaCliente();
            }// fim if ok
            else
                MessageBox.Show("Operacao cancelada");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
