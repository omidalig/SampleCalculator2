namespace datinconsolapp1.SeniorCalc
{
    internal class CalcSum : Calc 
    {
        public override void Calculator(decimal current)
        {
            try
            {
                History.Add($"{result} + {current}");
                result += current;
            }
            catch
            {
                Console.WriteLine($"hasel Jam {result} dar {current} kharej az damaneh tarif shodeh ast");
            }
        }
    }
}
