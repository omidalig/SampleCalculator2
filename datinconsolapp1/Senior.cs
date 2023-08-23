using datinconsolapp1.SeniorCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datinconsolapp1
{
    internal class Senior: ICaller
    {
        public void Call()
        {
            ///summary
            /// when a Senior Programming
            ///summary
            Console.WriteLine("lotfan moshabeh zir amal konid :");
            Console.WriteLine("1 + 2 / 3 * 4");
            Console.WriteLine("lotfan faghat adad va operator vared konid :");
            string val = Console.ReadLine();
            string[] vals = val.Split(" ");
            SeniorTazehKar senior = new(vals.ToList());
            senior.Calculator();
            Console.WriteLine("natije =");
            Console.WriteLine(Calc.result);
            Console.WriteLine("baray dariaft tarikhcheh mitavinid history va baray mohasebeh mojadad calc ra type konid");//
            string str = Console.ReadLine();
            if (str == "calc") Call();
            else if (str == "history") { Calc.History.ForEach(item => { Console.WriteLine(item); }); }
        }
    }
}
