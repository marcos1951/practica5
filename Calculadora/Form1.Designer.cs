namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(126, 24);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(133, 20);
            this.numero1.TabIndex = 0;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(126, 89);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(133, 20);
            this.numero2.TabIndex = 1;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(126, 148);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(133, 20);
            this.resultado.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "numero1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "numero2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "resultado";
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(12, 213);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(49, 20);
            this.suma.TabIndex = 6;
            this.suma.Text = "suma";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.button1_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(80, 213);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(49, 20);
            this.resta.TabIndex = 7;
            this.resta.Text = "resta";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // multi
            // 
            this.multi.Location = new System.Drawing.Point(151, 213);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(49, 20);
            this.multi.TabIndex = 8;
            this.multi.Text = "multi";
            this.multi.UseVisualStyleBackColor = true;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // div
            // 
            this.div.Location = new System.Drawing.Point(223, 213);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(49, 20);
            this.div.TabIndex = 9;
            this.div.Text = "div.";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.div);
            this.Controls.Add(this.multi);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button div;
    }
}

