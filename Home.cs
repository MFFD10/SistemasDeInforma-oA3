using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;

namespace Sistema_do_HotelA3
{
    public partial class Screen_Home : Form
    {
        public Screen_Home()
        {
            InitializeComponent();
        }

        private void button_Cadastro_Click(object sender, EventArgs e)
        {
            Screen_NovaReserva j2 = new Screen_NovaReserva();
            j2.Show();
        }

        private void button_Lista_Click(object sender, EventArgs e)
        {
            Screen_Listar j3 = new Screen_Listar();
            j3.Show();
        }
    }
}
