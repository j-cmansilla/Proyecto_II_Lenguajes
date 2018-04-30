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
    public partial class Unaria : Form
    {
        private char[] listaCadena;
        private int currentState;
        private char currentToken;
        private int index;
        public Unaria()
        {
            InitializeComponent();
            cinta.MultiSelect = false;
            this.cinta.DefaultCellStyle.Font = new Font("Ubuntu Mono", 18);
            cinta.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void getNextState()
        {
            if (!MultUnaria.isAccepted(currentToken))
            {
                currentState = -1;
                return;
            }
            if (currentState == 0)
            {
                switch (currentToken)
                {
                    case '|':
                        currentState = 1;
                        listaCadena[index + 1] = 'X';
                        cinta.Rows[0].Cells[index + 1].Value = "X";
                        index++;
                        return;
                    case '*':
                        currentState = 7;
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
                    case '*':
                        currentState = 2;
                        index++;
                        return;
                    default:
                        index++;
                        return;
                }
            }
            if (currentState == 2)
            {
                switch (currentToken)
                {
                    case '|':
                        currentState = 3;
                        listaCadena[index + 1] = 'Y';
                        cinta.Rows[0].Cells[index + 1].Value = "Y";
                        index++;
                        return;
                    case '=':
                        currentState = 5;
                        index--;
                        return;
                    default:
                        //index++;
                        return;
                }
            }
            if (currentState == 3)
            {
                switch (currentToken)
                {
                    case '=':
                        currentState = 4;
                        index++;
                        return;
                    default:
                        index++;
                        return;
                }
            }
            if (currentState == 4)
            {
                switch (currentToken)
                {
                    case ' ':
                        currentState = 5;
                        cinta.Rows[0].Cells[index + 1].Value = "|";
                        listaCadena[index + 1] = '|';
                        index--;
                        return;
                    default:
                        index++;
                        return;
                }
            }
            if (currentState == 5)
            {
                switch (currentToken)
                {
                    case '*':
                        currentState = 6;
                        index--;
                        return;
                    case 'Y':
                        currentState = 2;
                        cinta.Rows[0].Cells[index + 1].Value = "|";
                        listaCadena[index + 1] = '|';
                        index++;
                        return;
                    default:
                        index--;
                        return;
                }
            }
            if (currentState == 6)
            {
                switch (currentToken)
                {
                    case 'X':
                        currentState = 0;
                        cinta.Rows[0].Cells[index + 1].Value = "|";
                        listaCadena[index + 1] = '|';
                        index++;
                        return;
                    default:
                        index--;
                        return;
                }
            }
            if (currentState == 7)
            {
                switch (currentToken)
                {
                    case 'ß':
                        currentState = 8;
                        index--;
                        return;
                    default:
                        index++;
                        return;
                }
            }
            return;
        }

        private int pasos = 0;

        private void picNext_Click(object sender, EventArgs e)
        {
            currentToken = listaCadena[index + 1];
            lblPasos.Text = (++pasos).ToString();
            //lblTokenActual.Text = currentToken.ToString();
            getNextState();
            if (currentState == 8)
            {
                picNext.Visible = false;
                lblResultado.Visible = true;
                acaptada.Visible = true;
                picRestart.Visible = true;
            }
            if (currentState == -1)
            {
                picNext.Visible = false;
                lblResultado.Visible = true;
                NoAceptada.Visible = true;
                picRestart.Visible = true;
                return;
            }
            else
            {
                lblState.Text = "q" + currentState.ToString();
            }
            cinta.Rows[0].Cells[index + 1].Selected = true;
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
            string texto = textBox1.Text;
            char[] calcular = texto.ToCharArray();
            int contador = 0;
            int contador2 = 0;
            bool asteristo = false;
            int igual = 0;
            for (int i = 0; i < calcular.Length; i++)
            {
                if (calcular[i].ToString().Equals("|"))
                {
                    contador++;
                }
                if (calcular[i].ToString().Equals("*"))
                {
                    asteristo = true;
                }
                if (asteristo)
                {
                    if (calcular[i].ToString().Equals("|"))
                    {
                        contador2++;
                    }
                }
            }
            igual = (contador - (contador2))*(contador2);
            for (int i = 0; i < igual; i++)
            {
                texto = texto + " ";
            }
            texto = texto + "ß";
            char[] cadena = texto.ToCharArray();
            listaCadena = cadena;
            for (int i = 0; i < cadena.Length; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn();
                columna1.Name = (i + 1).ToString();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                columna1.CellTemplate = cell1;
                cinta.Columns.Add(columna1);
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
    }
}
