using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using PANIFICADORA_CENTRAL_2;


namespace PANIFICADORACENTRAL
{
    internal class conectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=localhost;user id=root;password=;database=panificadoraCentral");
        public String mensagem;
        public DataTable listaClientes()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("listaCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }

        public bool insereCliente2(Cliente C )
        {
            MySqlCommand cmd = new MySqlCommand("insereCliente2", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cpfNovo", C.CPF);
            cmd.Parameters.AddWithValue("NomeNovo", C.Nome);
            cmd.Parameters.AddWithValue("cidadeClienteNovo", C.cidade);
            cmd.Parameters.AddWithValue("enderecoNovo", C.endereco);
            cmd.Parameters.AddWithValue("telefoneNovo", C.Telefone);
            cmd.Parameters.AddWithValue("BairroNovo", C.bairro);
            cmd.Parameters.AddWithValue("cepNovo", C.cep);
            cmd.Parameters.AddWithValue("dataNova", C.data);
            cmd.Parameters.AddWithValue("emailNovo", C.email); 
            cmd.Parameters.AddWithValue("ufNovo", C.uf);



            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereCliente

        public bool new_alteraClientes(Cliente C, int CPF)
        {
            MySqlCommand cmd = new MySqlCommand("new_alteraClientes", conexao);
            cmd.CommandType = CommandType.StoredProcedure;//chamando stores procedure
            cmd.Parameters.AddWithValue("cpfCodigo", C.CPF);
            cmd.Parameters.AddWithValue("NomeAlt", C.Nome);
            cmd.Parameters.AddWithValue("cidadeClienteAlt", C.cidade);
            cmd.Parameters.AddWithValue("enderecoAlt", C.endereco);
            cmd.Parameters.AddWithValue("telefoneAlt", C.Telefone);
            cmd.Parameters.AddWithValue("BairroAlt", C.bairro);
            cmd.Parameters.AddWithValue("cepAlt", C.cep);
            cmd.Parameters.AddWithValue("dataAlt", C.data);
            cmd.Parameters.AddWithValue("emailAlt", C.email);
            cmd.Parameters.AddWithValue("ufAlt", C.uf);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim new_alteraClientes

        public bool new_deleteCliente( String cpf)

        {
            MySqlCommand cmd = new MySqlCommand("new_deleteCliente", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cpfcodigo", cpf);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaCliente

        public DataTable listaFornecedores()
        {
            
            MySqlCommand cmd = new MySqlCommand("listaFornecedores", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }//FimListaFornecedores 

        public bool new_insereFornecedor(Fornecedores F)
        {
            MySqlCommand cmd = new MySqlCommand("new_insereFornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cnpjNovo", F.cnpj);
            cmd.Parameters.AddWithValue("NomeNovoForn", F.Nome);
            cmd.Parameters.AddWithValue("cidadeNovoForn", F.cidade);
            cmd.Parameters.AddWithValue("enderecoNovoForn", F.endereco);
            cmd.Parameters.AddWithValue("telefoneNovoForn",F.Telefone);
            cmd.Parameters.AddWithValue("BairroNovoForn", F.bairro);
            cmd.Parameters.AddWithValue("cepNovoForn", F.cep);
            cmd.Parameters.AddWithValue("emailNovoForn", F.email);
            cmd.Parameters.AddWithValue("ufNovoForn", F.uf);



            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim insereFornecedor

        public bool new_alteraFornecedor2(Fornecedores F, int CNPJ)
        {
            MySqlCommand cmd = new MySqlCommand("new_alteraFornecedor2", conexao);
            cmd.CommandType = CommandType.StoredProcedure;//chamando stores procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cnpjAlt", F.cnpj);
            cmd.Parameters.AddWithValue("NomeFornAlt", F.Nome);
            cmd.Parameters.AddWithValue("cidadeFornAlt", F.cidade);
            cmd.Parameters.AddWithValue("enderecoFornAlt", F.endereco);
            cmd.Parameters.AddWithValue("telefoneFornAlt", F.Telefone);
            cmd.Parameters.AddWithValue("BairroFornAlt", F.bairro);
            cmd.Parameters.AddWithValue("cepFornAlt", F.cep);
            cmd.Parameters.AddWithValue("emailFornAlt", F.email);
            cmd.Parameters.AddWithValue("ufFornAlt", F.uf);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim_new_alteraFornecedor2
        public bool new_deleteFornecedor(String cnpj)

        {
            MySqlCommand cmd = new MySqlCommand("new_deleteFornecedor", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("cnpjExcluir", cnpj);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deletaFornecedor
    }
}


