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
    public partial class RestaUnaria : Form
    {
        private char[] listaCadena;
        private int currentState;
        private char currentToken;
        private List<char> listaValores = new List<char>();
        private int index;
        private int pasos = 0;
        public RestaUnaria()
        {
            InitializeComponent();
            cinta.MultiSelect = false;
            this.cinta.DefaultCellStyle.Font = new Font("Ubuntu Mono", 18);
            cinta.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Action()
        {
            currentToken = listaValores.ElementAt(index + 1);
            lblPasos.Text = (++pasos).ToString();
            //lblTokenActual.Text = currentToken.ToString();
            getNextState();
            if (currentState == 6)
            {
                picNext.Visible = false;
                lblResultado.Visible = true;
                acaptada.Visible = true;
                picRestart.Visible = true;
                timer1.Enabled = false;
            }
            if (currentState == -1)
            {
                picNext.Visible = false;
                lblResultado.Visible = true;
                NoAceptada.Visible = true;
                picRestart.Visible = true;
                timer1.Enabled = false;
                return;
            }
            else
            {
                lblState.Text = "q" + currentState.ToString();
            }
            cinta.Rows[0].Cells[index + 1].Selected = true;
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            picNext.Visible = false;
            timer1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            lblState.Text = "q0";
            textBox1.Text = "";
            lblResultado.Visible = false;
            NoAceptada.Visible = false;
            acaptada.Visible = false;
            lblPasos.Text = "0";
            pasos = 0;
            for (int i = 0; i < cinta.Columns.Count; i++)
            {
                cinta.Columns.RemoveAt(i);
            }
            cinta.Rows.RemoveAt(0);
            //cinta = new DataGridView();
            textBox1.Enabled = true;
            picRestart.Visible = false;
        }

        private void picStart_Click(object sender, EventArgs e)
        {
            picStart.Visible = false;
            textBox1.Enabled = false;
            picNext.Visible = true;
            string texto = textBox1.Text + "ß";
            char[] cadena = texto.ToCharArray();
            listaCadena = cadena;
            for (int i = 0; i < cadena.Length; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn();
                columna1.Name = (i + 1).ToString();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                columna1.CellTemplate = cell1;
                cinta.Columns.Add(columna1);
                listaValores.Add(cadena[i]);
            }
            cinta.Rows.Add();
            cinta.Rows[0].Height = 120;
            for (int i = 0; i < cadena.Length; i++)
            {
                cinta.Rows[0].Cells[i].Value = cadena[i].ToString();
            }
            currentState = 0;
            currentToken = listaCadena[0];
            //lblTokenActual.Text = currentToken.ToString();
            index = -1;
            cinta.Rows[0].Cells[0].Selected = true;
        }

        private void getNextState()
        {
            if (!Resta.isAccepted(currentToken))
            {
                currentState = -1;
                return;
            }
            if (currentState == 0)
            {
                switch (currentToken)
                {
                    case '|':
                        index++;
                        return;
                    case '-':
                        currentState = 1;
                        index++;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            if (currentState == 1)
            {
                switch (currentToken)
                {
                    case '|':
                        index++;
                        return;
                    case 'ß':
                        currentState = 2;
                        index--;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            if (currentState == 2)
            {
                switch (currentToken)
                {
                    case '|':
                        cinta.Rows[0].Cells[index + 1].Value = "X";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), 'X');
                        index--;
                        currentState = 3;
                        return;
                    case '-':
                        cinta.Rows[0].Cells[index + 1].Value = "ß";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), 'ß');
                        index--;
                        currentState = 6;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            if (currentState == 3)
            {
                switch (currentToken)
                {
                    case '|':
                        index--;
                        return;
                    case '-':
                        index--;
                        currentState = 4;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            if (currentState == 4)
            {
                switch (currentToken)
                {
                    case ' ':
                        index--;
                        return;
                    case '|':
                        cinta.Rows[0].Cells[index + 1].Value = " ";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), ' ');
                        currentState = 5;
                        index++;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            if (currentState == 5)
            {
                switch (currentToken)
                {
                    case ' ':
                        index++;
                        return;
                    case '|':
                        index++;
                        return;
                    case '-':
                        index++;
                        return;
                    case 'X':
                        cinta.Rows[0].Cells[index + 1].Value = "ß";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), 'ß');
                        currentState = 2;
                        index--;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            NoAceptada.Visible = false;
            acaptada.Visible = false;
            if (!textBox1.Text.ToString().Equals(""))
            {
                picStart.Visible = true;
                return;
            }
            picStart.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Action();
        }
    }
}
