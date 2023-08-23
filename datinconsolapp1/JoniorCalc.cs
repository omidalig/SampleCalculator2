using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datinconsolapp1
{
    internal class JoniorCalc
    {
        public JoniorCalc() { }

        public double JoniorsSum(double val1, double val2)
        {
            try
            {
                return val1 + val2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
        public double JoniorsSubtract(double val1, double val2)
        {
            try
            {
                return val1 - val2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
        public double JoniorsMultiplication(double val1, double val2)
        {
            try
            {
                return val1 * val2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }

        public double Joniorsdivision(double val1,double val2)
        {
            try
            {
                return val1 / val2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return 0;
            }
        }
    }
}
