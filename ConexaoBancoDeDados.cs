using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    static class ConexaoBancoDeDados
    {
     // variaveis passando informações para conexão com o banco de dados.
        private const string servidor = "MySQL Estudos";
        private const string bancoDeDados = "agenda_reservas";
        private const string usuario = "root";
        private const string senha = "123456";

        // declarando a variável conexao onde a conexão será estabelecida/conectada.
        static public string conexaobdd = $"server ={servidor}; user ID={usuario}; database={bancoDeDados}; password={senha}";

    }
}
