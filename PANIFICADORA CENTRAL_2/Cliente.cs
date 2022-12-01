using MySql.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANIFICADORA_CENTRAL_2
{
    public class Cliente
    {
        string nomeNovo, cpf, cidadeNova,enderecoNovo, ufNovo,cepNovo,
           emailNovo,bairroNovo, telefoneNovo, dataNova;
            
            public string Nome { get => nomeNovo; set => nomeNovo = value; }

            public string CPF { get => cpf; set => cpf = value; }

            public string cidade { get => cidadeNova; set => cidadeNova = value; }    

            public string uf { get => ufNovo; set => ufNovo = value; }

            public string endereco { get => enderecoNovo; set => enderecoNovo = value; }
            
            public string bairro { get => bairroNovo; set => bairroNovo = value; }

            public string cep { get => cepNovo; set => cepNovo = value; }   

            public  string data { get => dataNova; set => dataNova = value; }    

            public string email { get => emailNovo; set => emailNovo = value; } 
            
            public string Telefone { get => telefoneNovo; set => telefoneNovo = value; }



    }
}
