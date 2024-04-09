namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnUno = new System.Windows.Forms.Button();
            this.btnDos = new System.Windows.Forms.Button();
            this.btnTres = new System.Windows.Forms.Button();
            this.btnSeis = new System.Windows.Forms.Button();
            this.btnCinco = new System.Windows.Forms.Button();
            this.btnCuatro = new System.Windows.Forms.Button();
            this.btnNueve = new System.Windows.Forms.Button();
            this.btnOcho = new System.Windows.Forms.Button();
            this.btnSiete = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnCero = new System.Windows.Forms.Button();
            this.bntSigno = new System.Windows.Forms.Button();
            this.btnPorcentaje = new System.Windows.Forms.Button();
            this.btnParentesisDerecho = new System.Windows.Forms.Button();
            this.btnParentesisIzquierdo = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnElevadoCuadrado = new System.Windows.Forms.Button();
            this.btnRaizCuadrada = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.DodgerBlue;
            this.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.ForeColor = System.Drawing.Color.White;
            this.txtResultado.Location = new System.Drawing.Point(13, 12);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtResultado.MaxLength = 21;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(392, 63);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            this.btnUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUno.Location = new System.Drawing.Point(12, 325);
            this.btnUno.Name = "btnUno";
            this.btnUno.Size = new System.Drawing.Size(75, 55);
            this.btnUno.TabIndex = 1;
            this.btnUno.Text = "1";
            this.btnUno.UseVisualStyleBackColor = true;
            this.btnUno.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnDos
            // 
            this.btnDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDos.Location = new System.Drawing.Point(88, 325);
            this.btnDos.Name = "btnDos";
            this.btnDos.Size = new System.Drawing.Size(75, 55);
            this.btnDos.TabIndex = 2;
            this.btnDos.Text = "2";
            this.btnDos.UseVisualStyleBackColor = true;
            this.btnDos.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnTres
            // 
            this.btnTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTres.Location = new System.Drawing.Point(164, 325);
            this.btnTres.Name = "btnTres";
            this.btnTres.Size = new System.Drawing.Size(75, 55);
            this.btnTres.TabIndex = 3;
            this.btnTres.Text = "3";
            this.btnTres.UseVisualStyleBackColor = true;
            this.btnTres.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnSeis
            // 
            this.btnSeis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeis.Location = new System.Drawing.Point(164, 264);
            this.btnSeis.Name = "btnSeis";
            this.btnSeis.Size = new System.Drawing.Size(75, 55);
            this.btnSeis.TabIndex = 6;
            this.btnSeis.Text = "6";
            this.btnSeis.UseVisualStyleBackColor = true;
            this.btnSeis.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnCinco
            // 
            this.btnCinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCinco.Location = new System.Drawing.Point(88, 264);
            this.btnCinco.Name = "btnCinco";
            this.btnCinco.Size = new System.Drawing.Size(75, 55);
            this.btnCinco.TabIndex = 5;
            this.btnCinco.Text = "5";
            this.btnCinco.UseVisualStyleBackColor = true;
            this.btnCinco.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnCuatro
            // 
            this.btnCuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuatro.Location = new System.Drawing.Point(12, 264);
            this.btnCuatro.Name = "btnCuatro";
            this.btnCuatro.Size = new System.Drawing.Size(75, 55);
            this.btnCuatro.TabIndex = 4;
            this.btnCuatro.Text = "4";
            this.btnCuatro.UseVisualStyleBackColor = true;
            this.btnCuatro.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnNueve
            // 
            this.btnNueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueve.Location = new System.Drawing.Point(164, 203);
            this.btnNueve.Name = "btnNueve";
            this.btnNueve.Size = new System.Drawing.Size(75, 55);
            this.btnNueve.TabIndex = 9;
            this.btnNueve.Text = "9";
            this.btnNueve.UseVisualStyleBackColor = true;
            this.btnNueve.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnOcho
            // 
            this.btnOcho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcho.Location = new System.Drawing.Point(88, 203);
            this.btnOcho.Name = "btnOcho";
            this.btnOcho.Size = new System.Drawing.Size(75, 55);
            this.btnOcho.TabIndex = 8;
            this.btnOcho.Text = "8";
            this.btnOcho.UseVisualStyleBackColor = true;
            this.btnOcho.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnSiete
            // 
            this.btnSiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiete.Location = new System.Drawing.Point(12, 203);
            this.btnSiete.Name = "btnSiete";
            this.btnSiete.Size = new System.Drawing.Size(75, 55);
            this.btnSiete.TabIndex = 7;
            this.btnSiete.Text = "7";
            this.btnSiete.UseVisualStyleBackColor = true;
            this.btnSiete.Click += new System.EventHandler(this.agregarnumero);
            // 
            // btnPunto
            // 
            this.btnPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPunto.Location = new System.Drawing.Point(164, 386);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(75, 55);
            this.btnPunto.TabIndex = 12;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnCero
            // 
            this.btnCero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCero.Location = new System.Drawing.Point(88, 386);
            this.btnCero.Name = "btnCero";
            this.btnCero.Size = new System.Drawing.Size(75, 55);
            this.btnCero.TabIndex = 11;
            this.btnCero.Text = "0";
            this.btnCero.UseVisualStyleBackColor = true;
            this.btnCero.Click += new System.EventHandler(this.agregarnumero);
            // 
            // bntSigno
            // 
            this.bntSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSigno.Location = new System.Drawing.Point(12, 386);
            this.bntSigno.Name = "bntSigno";
            this.bntSigno.Size = new System.Drawing.Size(75, 55);
            this.bntSigno.TabIndex = 10;
            this.bntSigno.Text = "+/-";
            this.bntSigno.UseVisualStyleBackColor = true;
            this.bntSigno.Click += new System.EventHandler(this.bntSigno_Click);
            // 
            // btnPorcentaje
            // 
            this.btnPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentaje.Location = new System.Drawing.Point(164, 142);
            this.btnPorcentaje.Name = "btnPorcentaje";
            this.btnPorcentaje.Size = new System.Drawing.Size(75, 55);
            this.btnPorcentaje.TabIndex = 15;
            this.btnPorcentaje.Text = "%";
            this.btnPorcentaje.UseVisualStyleBackColor = true;
            // 
            // btnParentesisDerecho
            // 
            this.btnParentesisDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentesisDerecho.Location = new System.Drawing.Point(88, 142);
            this.btnParentesisDerecho.Name = "btnParentesisDerecho";
            this.btnParentesisDerecho.Size = new System.Drawing.Size(75, 55);
            this.btnParentesisDerecho.TabIndex = 14;
            this.btnParentesisDerecho.Text = ")";
            this.btnParentesisDerecho.UseVisualStyleBackColor = true;
            // 
            // btnParentesisIzquierdo
            // 
            this.btnParentesisIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParentesisIzquierdo.Location = new System.Drawing.Point(12, 142);
            this.btnParentesisIzquierdo.Name = "btnParentesisIzquierdo";
            this.btnParentesisIzquierdo.Size = new System.Drawing.Size(75, 55);
            this.btnParentesisIzquierdo.TabIndex = 13;
            this.btnParentesisIzquierdo.Text = "(";
            this.btnParentesisIzquierdo.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Location = new System.Drawing.Point(164, 81);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 55);
            this.btnQuitar.TabIndex = 18;
            this.btnQuitar.Text = "<-";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTodo.Location = new System.Drawing.Point(88, 81);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(75, 55);
            this.btnBorrarTodo.TabIndex = 17;
            this.btnBorrarTodo.Text = "C";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            this.btnBorrarTodo.Click += new System.EventHandler(this.btnBorrarTodo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(12, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 55);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "CE";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnElevadoCuadrado
            // 
            this.btnElevadoCuadrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElevadoCuadrado.Location = new System.Drawing.Point(326, 81);
            this.btnElevadoCuadrado.Name = "btnElevadoCuadrado";
            this.btnElevadoCuadrado.Size = new System.Drawing.Size(75, 55);
            this.btnElevadoCuadrado.TabIndex = 20;
            this.btnElevadoCuadrado.Tag = "²";
            this.btnElevadoCuadrado.Text = "x²";
            this.btnElevadoCuadrado.UseVisualStyleBackColor = true;
            this.btnElevadoCuadrado.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnRaizCuadrada
            // 
            this.btnRaizCuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizCuadrada.Location = new System.Drawing.Point(250, 81);
            this.btnRaizCuadrada.Name = "btnRaizCuadrada";
            this.btnRaizCuadrada.Size = new System.Drawing.Size(75, 55);
            this.btnRaizCuadrada.TabIndex = 19;
            this.btnRaizCuadrada.Tag = "√";
            this.btnRaizCuadrada.Text = "√";
            this.btnRaizCuadrada.UseVisualStyleBackColor = true;
            this.btnRaizCuadrada.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacion.Location = new System.Drawing.Point(328, 142);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(75, 55);
            this.btnMultiplicacion.TabIndex = 22;
            this.btnMultiplicacion.Tag = "X";
            this.btnMultiplicacion.Text = "X";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnDividir
            // 
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(252, 142);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 55);
            this.btnDividir.TabIndex = 21;
            this.btnDividir.Tag = "/";
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnResta
            // 
            this.btnResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResta.Location = new System.Drawing.Point(326, 203);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(75, 55);
            this.btnResta.TabIndex = 24;
            this.btnResta.Tag = "-";
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(250, 203);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 55);
            this.btnSuma.TabIndex = 23;
            this.btnSuma.Tag = "+";
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btnResultado
            // 
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(252, 264);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(153, 55);
            this.btnResultado.TabIndex = 25;
            this.btnResultado.Tag = "";
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(416, 448);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnElevadoCuadrado);
            this.Controls.Add(this.btnRaizCuadrada);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnBorrarTodo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPorcentaje);
            this.Controls.Add(this.btnParentesisDerecho);
            this.Controls.Add(this.btnParentesisIzquierdo);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnCero);
            this.Controls.Add(this.bntSigno);
            this.Controls.Add(this.btnNueve);
            this.Controls.Add(this.btnOcho);
            this.Controls.Add(this.btnSiete);
            this.Controls.Add(this.btnSeis);
            this.Controls.Add(this.btnCinco);
            this.Controls.Add(this.btnCuatro);
            this.Controls.Add(this.btnTres);
            this.Controls.Add(this.btnDos);
            this.Controls.Add(this.btnUno);
            this.Controls.Add(this.txtResultado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button bntSigno;
        private System.Windows.Forms.Button btnPorcentaje;
        private System.Windows.Forms.Button btnParentesisDerecho;
        private System.Windows.Forms.Button btnParentesisIzquierdo;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnElevadoCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResultado;
    }
}

