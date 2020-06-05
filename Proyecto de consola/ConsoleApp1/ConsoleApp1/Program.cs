using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {



            Console.Write("programa utilizado para deducir cuanto dinero se tiene disponible, cuanto dinero se debe y cuanto dinero le deben");
            Console.ReadLine();
          
            do
            {
                string result = "";
                CuentaCalc cc = new CuentaCalc();
                Console.WriteLine("Escriba +/- dinero disponible: ");
                result += "Dinero disponible: " + cc.dd(double.Parse(Console.ReadLine()));


                Console.WriteLine("nuevo acreedor? (si/no)");
                if (Console.ReadLine() == "si")
                {
                    cc.acreedor[0]++;
                    Console.WriteLine(" Escriba +/- dinero por pagar");
                   result += "\n Dinero que debe: " + cc.DPP(double.Parse(Console.ReadLine())) + " Á " + cc.acreedor[0] + " personas";
                }

                double y = 0;
                Console.WriteLine("nuevo deudor? (si/no)");
                if (Console.ReadLine() == "si")
                {
                    cc.deudor[0]++;
                    Console.WriteLine(" Escriba +/- dinero por cobrar");
                    y = cc.DPC(double.Parse(Console.ReadLine()));
                }
                result += "\n Dinero que le deben: " + y + " de " + cc.deudor[0] + " personas";
                Console.Write(result);
              


                Console.WriteLine("repetir? (si/No");
            } while (Console.ReadLine() == "si");
            //guardar cuentas en txt

            Console.WriteLine("¿Le gustaria anotar esto en un archivo de texto? Si/No");
            if (Console.ReadLine() == "si")
            {
                TextWriter archivo;
                archivo = new StreamWriter("archivo.txt");
                string mensaje;
                mensaje = Console.ReadLine();
                archivo.WriteLine(mensaje);
                archivo.Close();
                Console.Clear();
                Console.WriteLine("Se ha guardado el archivo exitosamente, puede empezar un escrito en el archivo de texto en la carpeta debug de esta aplicacion");
                Console.ReadKey();



            }
        }
    }
}
