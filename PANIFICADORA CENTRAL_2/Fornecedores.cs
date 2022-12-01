using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANIFICADORA_CENTRAL_2
{
    internal class Fornecedores
    {
        string cnpjNovo, nomeNovo, telefoneNovo, emailNovo,
            enderecoNovo, bairroNovo, cidadeNova, cepNovo, ufNovo;

        public string Nome { get => nomeNovo; set => nomeNovo = value; }

        public string cnpj{ get => cnpjNovo; set => cnpjNovo= value; }

        public string cidade { get => cidadeNova; set => cidadeNova = value; }

        public string uf { get => ufNovo; set => ufNovo = value; }

        public string endereco { get => enderecoNovo; set => enderecoNovo = value; }

        public string bairro { get => bairroNovo; set => bairroNovo = value; }

        public string cep { get => cepNovo; set => cepNovo = value; }

        public string email { get => emailNovo; set => emailNovo = value; }

        public string Telefone { get => telefoneNovo; set => telefoneNovo = value; }

    }
}
