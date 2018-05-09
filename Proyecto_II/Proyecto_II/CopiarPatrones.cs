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
    public partial class CopiarPatrones : Form
    {

        private char[] listaCadena;
        private int currentState;
        private char currentToken;
        private int index;
        private List<string> listaValores = new List<string>();
        public CopiarPatrones()
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

        private void AddColumn()
        {
            DataGridViewColumn columna1 = new DataGridViewColumn();
            columna1.Name = (currentState).ToString();
            DataGridViewCell cell1 = new DataGridViewTextBoxCell();
            columna1.CellTemplate = cell1;
            cinta.Columns.Add(columna1);
        }

        private void getNextState()
        {
            if (!Copiar.isAccepted(currentToken))
            {
                currentState = -1;
                return;
            }
            if (currentState == 0)
            {
                switch (currentToken)
                {
                    case 'a':
                        currentState = 1;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index+1),"X");
                        cinta.Rows[0].Cells[index + 1].Value = "X";
                        index++;
                        return;
                    case 'b':
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "Y");
                        cinta.Rows[0].Cells[index + 1].Value = "Y";
                        currentState = 2;
                        index++;
                        return;
                    case 'c':
                        currentState = 3;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "Z");
                        cinta.Rows[0].Cells[index + 1].Value = "Z";
                        index++;
                        return;
                    case 'A':
                        currentState = 7;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "a");
                        cinta.Rows[0].Cells[index + 1].Value = "a";
                        index++;
                        return;
                    case 'B':
                        currentState = 7;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "b");
                        cinta.Rows[0].Cells[index + 1].Value = "b";
                        index++;
                        return;
                    case 'C':
                        currentState = 7;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "c");
                        cinta.Rows[0].Cells[index + 1].Value = "c";
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
                    case 'ß':
                        currentState = 4;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "A");
                        cinta.Rows[0].Cells[index + 1].Value = "A";
                        index--;
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
                    case 'ß':
                        currentState = 5;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "B");
                        cinta.Rows[0].Cells[index + 1].Value = "B";
                        index--;
                        return;
                    default:
                        index++;
                        return;
                }
            }
            if (currentState == 3)
            {
                switch (currentToken)
                {
                    case 'ß':
                        currentState = 6;
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "C");
                        cinta.Rows[0].Cells[index + 1].Value = "C";
                        index--;
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
                    case 'X':
                        currentState = 0;
                        cinta.Rows[0].Cells[index + 1].Value = "a";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "a");
                        index++;
                        return;
                    default:
                        index--;
                        return;
                }
            }
            if (currentState == 5)
            {
                switch (currentToken)
                {
                    case 'Y':
                        currentState = 0;
                        cinta.Rows[0].Cells[index + 1].Value = "b";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "b");
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
                    case 'Z':
                        currentState = 0;
                        cinta.Rows[0].Cells[index + 1].Value = "c";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "c");
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
                    case 'C':
                        cinta.Rows[0].Cells[index + 1].Value = "c";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "c");
                        index++;
                        return;
                    case 'A':
                        cinta.Rows[0].Cells[index + 1].Value = "a";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "a");
                        index++;
                        return;
                    case 'B':
                        cinta.Rows[0].Cells[index + 1].Value = "b";
                        listaValores.RemoveAt(index + 1);
                        listaValores.Insert((index + 1), "b");
                        index++;
                        return;
                    case 'ß':
                        currentState = 8;
                        index--;
                        return;
                    default:
                        currentState = -1;
                        return;
                }
            }
            return;
        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void picStart_Click(object sender, EventArgs e)
        {
            picStart.Visible = false;
            textBox1.Enabled = false;
            picNext.Visible = true;
            string texto = textBox1.Text+"ß";
            int espacio = texto.Length;
            for (int i = 0; i < espacio; i++)
            {
                texto = texto + "ß";
            }
            char[] cadena = texto.ToCharArray();
            listaCadena = cadena;
            for (int i = 0; i < cadena.Length; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn();
                columna1.Name = (i + 1).ToString();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                columna1.CellTemplate = cell1;
                cinta.Columns.Add(columna1);
                listaValores.Add(cadena[i].ToString());
            }
            /*for (int i = 0; i < espacio; i++)
            {
                listaValores.Add(" ");
            }*/
            /*for (int i = 0; i < 10; i++)
            {
                DataGridViewColumn columna1 = new DataGridViewColumn();
                columna1.Name = (i + 1).ToString();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                columna1.CellTemplate = cell1;
                cinta.Columns.Add(columna1);
            }*/
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

        private void picRestart_Click_1(object sender, EventArgs e)
        {
            lblState.Text = "q0";
            listaValores = new List<string>();
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

        private void picNext_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            picNext.Visible = false;
        }

        private void Action()
        {
            currentToken = listaValores.ElementAt(index + 1).ToString().ToCharArray()[0];
            lblPasos.Text = (++pasos).ToString();
            //lblTokenActual.Text = currentToken.ToString();
            getNextState();
            if (currentState == 8)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }

        private void CopiarPatrones_Load(object sender, EventArgs e)
        {

        }


        private void btnProcesarCadena_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnProcesarCadena_Click_1(object sender, EventArgs e)
        {
        }


        private void recorrerLaCinta()
        {

        }

        private void btnProcesarCadena_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private int pasos = 0;
        private void picNext_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Action();
        }
    }
}
