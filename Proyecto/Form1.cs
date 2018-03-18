using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Analizador lex = new Analizador();
        private void bt_cargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirA = new OpenFileDialog();
            abrirA.Filter="|*.lfp";
            if(abrirA.ShowDialog()==System.Windows.Forms.DialogResult.OK){
                StreamReader lectura = new StreamReader(abrirA.FileName);
                String arch = lectura.ReadToEnd();
                rt_entrada.Text = arch;
            }
        }

        private void bt_analizar_Click(object sender, EventArgs e)
        {
            lex.lexico(rt_entrada.Text);
        }

        
    }
}
