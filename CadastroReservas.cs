using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class CadastroReservas
    {
        private int ID;
        private string Hotel;
        private int dataReserva;
        private string Responsavel;
        private string PAGAMENTO;

        public int ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string Hotel
        {
            get { return Hotel; }
            set { Hotel = value; }
        }

        public int dataReserva
        {
            get { return dataReserva; }
            set { dataReserva = value; }
        }

        public string Responsavel
        {
            get { return Responsavel; }
            set { Responsavel = value; }
        }

        public string PAGAMENTO
        {
            get { return PAGAMENTO}
            set { PAGAMENTO = value; }
        }


    }
}
