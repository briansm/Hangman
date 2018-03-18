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
            this.rt_entrada.Location = new System.Drawing.Point(24, 22);
            this.rt_entrada.Margin = new System.Windows.Forms.Padding(2);
            this.rt_entrada.Name = "rt_entrada";
            this.rt_entrada.Size = new System.Drawing.Size(387, 273);
            this.rt_entrada.TabIndex = 0;
            this.rt_entrada.Text = "";
            // 
            // bt_cargar
            // 
            this.bt_cargar.Location = new System.Drawing.Point(453, 56);
            this.bt_cargar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_cargar.Name = "bt_cargar";
            this.bt_cargar.Size = new System.Drawing.Size(56, 19);
            this.bt_cargar.TabIndex = 1;
            this.bt_cargar.Text = "Cargar";
            this.bt_cargar.UseVisualStyleBackColor = true;
            this.bt_cargar.Click += new System.EventHandler(this.bt_cargar_Click);
            // 
            // bt_analizar
            // 
            this.bt_analizar.Location = new System.Drawing.Point(453, 96);
            this.bt_analizar.Margin = new System.Windows.Forms.Padding(2);
            this.bt_analizar.Name = "bt_analizar";
            this.bt_analizar.Size = new System.Drawing.Size(56, 19);
            this.bt_analizar.TabIndex = 2;
            this.bt_analizar.Text = "Analizar";
            this.bt_analizar.UseVisualStyleBackColor = true;
            this.bt_analizar.Click += new System.EventHandler(this.bt_analizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 336);
            this.Controls.Add(this.bt_analizar);
            this.Controls.Add(this.bt_cargar);
            this.Controls.Add(this.rt_entrada);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hangman";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_cargar;
        private System.Windows.Forms.Button bt_analizar;
        public System.Windows.Forms.RichTextBox rt_entrada;
    }
}

