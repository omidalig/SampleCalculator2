namespace datinconsolapp1.SeniorCalc
{
    internal class CalcMultiplication : Calc
    {
        public override void Calculator(decimal current)
        {
            try
            {
                History.Add($"{result} * {current}");
                result *= current;
            }
            catch
            {
                Console.WriteLine($"hasel Zarb {result} dar {current} kharej az damaneh tarif shodeh ast");
            }
        }
    }
}
