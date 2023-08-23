namespace datinconsolapp1.SeniorCalc
{
    internal abstract class Calc
    {
        public static decimal result { get; protected set; } = 0;
        public static List<string> History { get; protected set; } = new();
        public abstract void Calculator(decimal current);
    }
}
