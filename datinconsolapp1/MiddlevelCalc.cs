using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datinconsolapp1
{
    internal class MiddlevelCalc
    {
        public MiddlevelCalc(List<string> lstcalc) {
            try
            {
                double lastcalc = 0;
                for (int i = 0; i < lstcalc.Count; i++)
                {
                    switch (lstcalc[i])
                    {
                        case "+":
                            lastcalc += Convert.ToDouble(lstcalc[i + 1]);
                            break;
                        case "-":
                            lastcalc -= Convert.ToDouble(lstcalc[i + 1]); ;
                            break;
                        case "*":
                            lastcalc *= Convert.ToDouble(lstcalc[i + 1]); ;
                            break;
                        case "/":
                            lastcalc /= Convert.ToDouble(lstcalc[i + 1]); ;
                            break;
                    }
                }
                Console.WriteLine("majmo: \n");
                Console.WriteLine(lastcalc);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
