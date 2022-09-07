using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempoCilco
{
    public partial class Form1 : Form
    {
        bool colore = false;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) System.Diagnostics.Process.GetCurrentProcess().Kill(); // controllo e uccide.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            string Tempo_ciclo = Globals.DirLavoro + "\\Tempo.grx";
            System.IO.StreamReader objReader;
            try
            {
           objReader = new System.IO.StreamReader(Tempo_ciclo);
           lblciclo.Text = objReader.ReadLine();//percorso
            objReader.Close();
            }
            catch (Exception)
            {

                ;
            }
          
        }
    }
} 
