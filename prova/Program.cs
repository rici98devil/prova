using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
namespace prova
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
   Globals.DirLavoro = Directory.GetCurrentDirectory();
            }
            catch (Exception)
            {

               MessageBox.Show("Programm cs");
            }
        

            string file_name = Globals.DirLavoro+"\\Lavoro.grx";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!System.IO.File.Exists(file_name) )
            {
                try
                {
 System.IO.StreamWriter fs = System.IO.File.CreateText(file_name);
          
            fs.Close();
                }
                catch (Exception)
                {

                  MessageBox.Show(file_name);
                }
            
            }
            Filelavoro();

          




            Application.Run(new Form1());
        }

        static public void Filelavoro()
        {
            string file_name = Globals.DirLavoro + "\\Lavoro.grx";

            if (System.IO.File.Exists(file_name) == true)
            {

                System.IO.StreamReader objReader;
                objReader = new System.IO.StreamReader(file_name);
               
                Globals.File_Lavoro[0] = objReader.ReadLine();//percorso
                Globals.File_Lavoro[1] = objReader.ReadLine();// inserito
                Globals.File_Lavoro[2] = objReader.ReadLine();//start
                Globals.File_Lavoro[3] = objReader.ReadLine();//stop
                Globals.File_Lavoro[4] = objReader.ReadLine();//timeout
                objReader.Close();
            }
           
        }
        



    }



    public static class Globals
    {

        public static string DirLavoro;
        public static string[] File_Lavoro = new string[10];

    }

   


}
