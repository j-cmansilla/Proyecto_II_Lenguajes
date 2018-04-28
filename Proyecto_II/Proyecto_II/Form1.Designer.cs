namespace Proyecto_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cinta = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picStart = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.acaptada = new System.Windows.Forms.PictureBox();
            this.NoAceptada = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.lblTokenActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cinta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaptada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoAceptada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            this.SuspendLayout();
            // 
            // cinta
            // 
            this.cinta.AllowUserToAddRows = false;
            this.cinta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Ubuntu Mono", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cinta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.cinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cinta.ColumnHeadersVisible = false;
            this.cinta.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cinta.Location = new System.Drawing.Point(16, 163);
            this.cinta.Name = "cinta";
            this.cinta.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Ubuntu Mono", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cinta.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.cinta.Size = new System.Drawing.Size(615, 124);
            this.cinta.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese una cadena:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(198, 314);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Máquina actual:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(463, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Estado actual:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblState.Location = new System.Drawing.Point(604, 23);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(27, 20);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "q0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(163, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Palabras palíndromas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // picStart
            // 
            this.picStart.BackColor = System.Drawing.Color.Transparent;
            this.picStart.Image = ((System.Drawing.Image)(resources.GetObject("picStart.Image")));
            this.picStart.Location = new System.Drawing.Point(17, 345);
            this.picStart.Name = "picStart";
            this.picStart.Size = new System.Drawing.Size(65, 71);
            this.picStart.TabIndex = 10;
            this.picStart.TabStop = false;
            this.picStart.Visible = false;
            this.picStart.Click += new System.EventHandler(this.btnProcesarCadena_Click_1);
            this.picStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProcesarCadena_MouseClick);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.Transparent;
            this.lblResultado.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResultado.Location = new System.Drawing.Point(13, 70);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(90, 20);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Aceptada:";
            this.lblResultado.Visible = false;
            // 
            // acaptada
            // 
            this.acaptada.BackColor = System.Drawing.Color.Transparent;
            this.acaptada.Image = ((System.Drawing.Image)(resources.GetObject("acaptada.Image")));
            this.acaptada.Location = new System.Drawing.Point(109, 79);
            this.acaptada.Name = "acaptada";
            this.acaptada.Size = new System.Drawing.Size(69, 65);
            this.acaptada.TabIndex = 12;
            this.acaptada.TabStop = false;
            this.acaptada.Visible = false;
            // 
            // NoAceptada
            // 
            this.NoAceptada.BackColor = System.Drawing.Color.Transparent;
            this.NoAceptada.Image = ((System.Drawing.Image)(resources.GetObject("NoAceptada.Image")));
            this.NoAceptada.Location = new System.Drawing.Point(109, 79);
            this.NoAceptada.Name = "NoAceptada";
            this.NoAceptada.Size = new System.Drawing.Size(69, 65);
            this.NoAceptada.TabIndex = 13;
            this.NoAceptada.TabStop = false;
            this.NoAceptada.Visible = false;
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.Image = ((System.Drawing.Image)(resources.GetObject("picNext.Image")));
            this.picNext.Location = new System.Drawing.Point(109, 345);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(69, 71);
            this.picNext.TabIndex = 14;
            this.picNext.TabStop = false;
            this.picNext.Visible = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // lblTokenActual
            // 
            this.lblTokenActual.AutoSize = true;
            this.lblTokenActual.BackColor = System.Drawing.Color.Transparent;
            this.lblTokenActual.Font = new System.Drawing.Font("Ubuntu Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenActual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTokenActual.Location = new System.Drawing.Point(408, 98);
            this.lblTokenActual.Name = "lblTokenActual";
            this.lblTokenActual.Size = new System.Drawing.Size(0, 20);
            this.lblTokenActual.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(647, 428);
            this.Controls.Add(this.lblTokenActual);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.NoAceptada);
            this.Controls.Add(this.acaptada);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.picStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cinta);
            this.Font = new System.Drawing.Font("Ubuntu Mono", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto II - Lenguajes Formales y autómatas";
            ((System.ComponentModel.ISupportInitialize)(this.cinta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acaptada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoAceptada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cinta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picStart;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox acaptada;
        private System.Windows.Forms.PictureBox NoAceptada;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.Label lblTokenActual;
    }
}

