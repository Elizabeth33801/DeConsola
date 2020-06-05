using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class CuentaCalc : cuentas
  {
    public CuentaCalc() : base()
    {

    }
    //dinero disponible
    public double dd(double x)
    {
      return dineroDisponible += x;
    }
    //dinero por pagar
    public double DPP(double x)
    {
      acreedor[1] += x;
      return acreedor[1];
    }

    //dinero por cobrar
    public double DPC(double x)
    {
      deudor[1] += x;
      return deudor[1];
    }
  }
}
