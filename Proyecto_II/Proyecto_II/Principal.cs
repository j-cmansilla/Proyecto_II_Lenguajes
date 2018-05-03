using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_II
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                //MessageBox.Show("Seleccione una máquina para continuar!");
                errorLabel.Visible = true;
                return;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0: //Palindromo
                    Form1 palindromo = new Form1();
                    palindromo.Show();
                    this.Hide();
                    break;
                case 1: //Copiar texto
                    CopiarPatrones copiarPatrones = new CopiarPatrones();
                    copiarPatrones.Show();
                    this.Hide();
                    break;
                case 2: //Multiplicar unario
                    Unaria multUnaria = new Unaria();
                    multUnaria.Show();
                    this.Hide();
                    break;
                case 3: //Suma unaria
                    SumaUnaria suma = new SumaUnaria();
                    suma.Show();
                    this.Hide();
                    break;
                case 4: //Resta unaria
                    RestaUnaria resta = new RestaUnaria();
                    resta.Show();
                    this.Hide();
                    break;
                default:
                    return;
            }
        }
    }
}
