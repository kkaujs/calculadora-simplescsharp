
namespace Estudoforms1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.soma = new System.Windows.Forms.Button();
            this.subtrai = new System.Windows.Forms.Button();
            this.multiplica = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.apaga = new System.Windows.Forms.Button();
            this.txtCalculo = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.Historico = new System.Windows.Forms.ListBox();
            this.igual = new System.Windows.Forms.Button();
            this.parcial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // soma
            // 
            this.soma.Location = new System.Drawing.Point(91, 94);
            this.soma.Name = "soma";
            this.soma.Size = new System.Drawing.Size(75, 23);
            this.soma.TabIndex = 0;
            this.soma.Text = "+";
            this.soma.UseVisualStyleBackColor = true;
            this.soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // subtrai
            // 
            this.subtrai.Location = new System.Drawing.Point(172, 94);
            this.subtrai.Name = "subtrai";
            this.subtrai.Size = new System.Drawing.Size(75, 23);
            this.subtrai.TabIndex = 1;
            this.subtrai.Text = "-";
            this.subtrai.UseVisualStyleBackColor = true;
            this.subtrai.Click += new System.EventHandler(this.subtrai_Click);
            // 
            // multiplica
            // 
            this.multiplica.Location = new System.Drawing.Point(91, 123);
            this.multiplica.Name = "multiplica";
            this.multiplica.Size = new System.Drawing.Size(75, 23);
            this.multiplica.TabIndex = 2;
            this.multiplica.Text = "x";
            this.multiplica.UseVisualStyleBackColor = true;
            this.multiplica.Click += new System.EventHandler(this.multiplica_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(10, 123);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(75, 23);
            this.divide.TabIndex = 3;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // apaga
            // 
            this.apaga.Location = new System.Drawing.Point(10, 94);
            this.apaga.Name = "apaga";
            this.apaga.Size = new System.Drawing.Size(75, 23);
            this.apaga.TabIndex = 4;
            this.apaga.Text = "C";
            this.apaga.UseVisualStyleBackColor = true;
            this.apaga.Click += new System.EventHandler(this.apaga_Click);
            // 
            // txtCalculo
            // 
            this.txtCalculo.Location = new System.Drawing.Point(12, 51);
            this.txtCalculo.Name = "txtCalculo";
            this.txtCalculo.Size = new System.Drawing.Size(395, 20);
            this.txtCalculo.TabIndex = 5;
            this.txtCalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(10, 161);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(91, 162);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(172, 162);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(10, 190);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(91, 191);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 23);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(172, 190);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 23);
            this.btn6.TabIndex = 11;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 219);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 23);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(91, 220);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 23);
            this.btn8.TabIndex = 13;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(172, 220);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 23);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // Historico
            // 
            this.Historico.FormattingEnabled = true;
            this.Historico.Location = new System.Drawing.Point(253, 97);
            this.Historico.Name = "Historico";
            this.Historico.Size = new System.Drawing.Size(154, 147);
            this.Historico.TabIndex = 15;
            // 
            // igual
            // 
            this.igual.Location = new System.Drawing.Point(172, 123);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(75, 23);
            this.igual.TabIndex = 16;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = true;
            this.igual.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // parcial
            // 
            this.parcial.AutoSize = true;
            this.parcial.Location = new System.Drawing.Point(384, 22);
            this.parcial.Name = "parcial";
            this.parcial.Size = new System.Drawing.Size(13, 13);
            this.parcial.TabIndex = 17;
            this.parcial.Text = "0";
            this.parcial.Click += new System.EventHandler(this.parcial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.parcial);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.Historico);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtCalculo);
            this.Controls.Add(this.apaga);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiplica);
            this.Controls.Add(this.subtrai);
            this.Controls.Add(this.soma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button soma;
        private System.Windows.Forms.Button subtrai;
        private System.Windows.Forms.Button multiplica;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button apaga;
        private System.Windows.Forms.TextBox txtCalculo;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Label parcial;
        private System.Windows.Forms.ListBox Historico;
    }
}

