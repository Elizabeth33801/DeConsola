using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.Write("programa utilizado para deducir cuanto dinero se tiene disponible, cuanto dinero se debe y cuanto dinero le deben");

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
    }
  }
}
