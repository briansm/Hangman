namespace Proyecto
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
            this.rt_entrada = new System.Windows.Forms.RichTextBox();
            this.bt_cargar = new System.Windows.Forms.Button();
            this.bt_analizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rt_entrada
            // 
            this.rt_entrada.Location = new System.Drawing.Point(32, 27);
            this.rt_entrada.Name = "rt_entrada";
            this.rt_entrada.Size = new System.Drawing.Size(515, 335);
            this.rt_entrada.TabIndex = 0;
            this.rt_entrada.Text = "";
            // 
            // bt_cargar
            // 
            this.bt_cargar.Location = new System.Drawing.Point(604, 69);
            this.bt_cargar.Name = "bt_cargar";
            this.bt_cargar.Size = new System.Drawing.Size(75, 23);
            this.bt_cargar.TabIndex = 1;
            this.bt_cargar.Text = "Cargar";
            this.bt_cargar.UseVisualStyleBackColor = true;
            this.bt_cargar.Click += new System.EventHandler(this.bt_cargar_Click);
            // 
            // bt_analizar
            // 
            this.bt_analizar.Location = new System.Drawing.Point(604, 118);
            this.bt_analizar.Name = "bt_analizar";
            this.bt_analizar.Size = new System.Drawing.Size(75, 23);
            this.bt_analizar.TabIndex = 2;
            this.bt_analizar.Text = "Analizar";
            this.bt_analizar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 414);
            this.Controls.Add(this.bt_analizar);
            this.Controls.Add(this.bt_cargar);
            this.Controls.Add(this.rt_entrada);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rt_entrada;
        private System.Windows.Forms.Button bt_cargar;
        private System.Windows.Forms.Button bt_analizar;
    }
}

