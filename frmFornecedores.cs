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

namespace PANIFICADORA_CENTRAL_2
{
    public partial class frmFornecedores : Form
    {
        public frmFornecedores()
        {
            InitializeComponent();
            listaFornecedor();
        }
        int idAlterarFor; // variavel global
        private void LimpaCamposFor()
        {
            textCnpj.Text = "";
            textNomeFor.Text = "";
            textTelFor.Text = "";
            textEmailFor.Text = "";
            textCidadeFor.Text = "";
            textEnderecoFor.Text = "";
            textBairroFor.Text = "";
            textCepFor.Text = "";
            textUfFor.Text = "";
            textCnpj.Focus();
        }
        private void LimpaCamposForAlt()
        {
            textCnpjAlt.Text = "";
            textNomeForAlt.Text = "";
            textTelForAlt.Text = "";
            textEmailForAlt.Text = "";
            textCidadeForAlt.Text = "";
            textEnderecoForAlt.Text = "";
            textBairroForAlt.Text = "";
            textCepForAlt.Text = "";
            textUfForAlt.Text = "";
            textCnpjAlt.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmaFor_Click(object sender, EventArgs e)
        {

            {
                Fornecedores F = new Fornecedores();
                F.cnpj = textCnpj.Text;
                F.Nome = textNomeFor.Text;
                F.cidade = textCidadeFor.Text;
                F.uf = textUfFor.Text;
                F.endereco = textEnderecoFor.Text;
                F.bairro = textBairroFor.Text;
                F.cep = textCepFor.Text;
                F.email = textEmailFor.Text;
                F.Telefone = textTelFor.Text;
               


                // enviar para o banco
                conectaBanco conecta = new conectaBanco();
                bool retorno = conecta.new_insereFornecedor(F);
                if (retorno == true)
                {
                    MessageBox.Show("Dados inseridos com sucesso");
                }
                else
                    MessageBox.Show("erro");
                 LimpaCamposFor();
                 listaFornecedor();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Fornecedores F = new Fornecedores();
                F.cnpj = textCnpjAlt.Text;
                F.Nome = textNomeForAlt.Text;
                F.cidade = textCidadeForAlt.Text;
                F.uf = textUfForAlt.Text;
                F.endereco = textEnderecoForAlt.Text;
                F.bairro = textBairroForAlt.Text;
                F.cep = textCepForAlt.Text;
                F.email = textEmailForAlt.Text;
                F.Telefone = textTelForAlt.Text;
                // enviar os dados para alterar
                conectaBanco conecta = new conectaBanco();
                bool retorno = conecta.new_alteraFornecedor2(F, idAlterarFor);
                LimpaCamposForAlt();
                MessageBox.Show("Fornecedor Alterado");
                listaFornecedor();
            }
        }
        void listaFornecedor()
        {
            conectaBanco con = new conectaBanco();
            dgFornecedor.DataSource = con.listaFornecedores();
        }
        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRemoveForn_Click(object sender, EventArgs e)
        {
            {
                int linha = dgFornecedor.CurrentRow.Index; // pega linha selecionada 
                string cnpj = dgFornecedor.Rows[linha].Cells["cnpj"].Value.ToString();
                DialogResult resp = MessageBox.Show("Confirma exclusão?", "Remove Fornecedor", MessageBoxButtons.OKCancel);
                if (resp == DialogResult.OK)
                {
                    conectaBanco conecta = new conectaBanco();
                    bool retorno = conecta.new_deleteFornecedor(cnpj);
                    if (retorno == true)
                        MessageBox.Show("Fornecedor excluido");
                    else
                        //lblmsgerro.Text = conecta.mensagem;
                        listaFornecedor();
                }// fim if ok
                else
                    MessageBox.Show("Operacao cancelada");
                listaFornecedor();
            }
        }

        private void btnAlterarForn_Click(object sender, EventArgs e)
        {
            int linha = dgFornecedor.CurrentRow.Index; // pega linha selecionada 
            textCnpjAlt.Text = dgFornecedor.Rows[linha].Cells["cnpj"].Value.ToString();
            textNomeForAlt.Text = dgFornecedor.Rows[linha].Cells["Nome_Empresarial"].Value.ToString();
            textCidadeForAlt.Text = dgFornecedor.Rows[linha].Cells["Cidade"].Value.ToString();
            textUfForAlt.Text = dgFornecedor.Rows[linha].Cells["UF"].Value.ToString();
            textEnderecoForAlt.Text = dgFornecedor.Rows[linha].Cells["Endereço"].Value.ToString();
            textBairroForAlt.Text = dgFornecedor.Rows[linha].Cells["Bairro"].Value.ToString();
            textCepForAlt.Text = dgFornecedor.Rows[linha].Cells["Cep"].Value.ToString();
            textEmailForAlt.Text = dgFornecedor.Rows[linha].Cells["Email"].Value.ToString();
            textTelForAlt.Text = dgFornecedor.Rows[linha].Cells["Telefone"].Value.ToString();


            tabControlClientes.SelectedTab = tabPage1; // muda aba
            listaFornecedor();

            //Fim altera fornecedor
        }

        private void txtBuscaForn_TextChanged(object sender, EventArgs e)
        {
            (dgFornecedor.DataSource as DataTable).DefaultView.RowFilter = String.Format("Nome_Empresarial like'%{0}%'", txtBuscaForn.Text);
        }
    }
}
