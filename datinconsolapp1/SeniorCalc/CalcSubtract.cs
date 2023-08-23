namespace datinconsolapp1.SeniorCalc
{
    internal class CalcSubtract : Calc
    {
        public override void Calculator(decimal current)
        {
            try
            {
                History.Add($"{result} - {current}");
                result -= current;
            }
            catch
            {
                Console.WriteLine($"hasel Tafrigh {result} dar {current} kharej az damaneh tarif shodeh ast");
            }
        }
    }
}
