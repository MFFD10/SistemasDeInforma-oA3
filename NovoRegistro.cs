using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_do_HotelA3
{
    public partial class Screen_NovaReserva : Form
    {
        public Screen_NovaReserva()
        {
            InitializeComponent();
        }

        private void Forma_Pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Concluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!textBox_Nome.Text.Equals("") && !textBox_Email.Text.Equals(""))
                {
                    Reservas reservas = new Reservas();
                    reservas.Nome = textBox_Nome.Text;
                    reservas.Email = textBox_Email.Text;
                    reservas.Data_Reserva = select_Data.Text;
                    reservas.Pagamento = Forma_Pagamento.Text;

                    if (reservas.novaReserva())
                    {
                        MessageBox.Show($"Reserva para o dia: {reservas.Data_Reserva} no nome de: {reservas.Nome} foi cadastrada.");
                        textBox_Nome.Clear();
                        textBox_Email.Clear();
                        textBox_Nome.Focus();
                    }
                }
                else {
                    MessageBox.Show("Preencha todos os campos corretamente!");
                    textBox_Nome.Clear();
                    textBox_Email.Clear();
                    textBox_Nome.Focus();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao cadastrar reserva" + ex.Message);
            }
        }
    }
}
