using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class cuentas
  {
    //a quien debo y quien me debe respectivamente siendo 0 a cuantas personas le debe y 1 cuanto debe}
    public double dineroDisponible = 0;
    public double[] acreedor = new double[2];
    public double[] deudor = new double[2];

    public cuentas()
    {
      dineroDisponible = 0;
      acreedor[0] = 0;
      acreedor[1] = 0;
      deudor[0] = 0;
      deudor[1] = 0;
    }
  }
}
