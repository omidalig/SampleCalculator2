namespace datinconsolapp1.SeniorCalc
{
    internal class SeniorTazehKar
    {
        private List<string> _lst;
        public SeniorTazehKar(List<string> lst) => _lst = lst ?? new List<string>();
        public void Calculator()
        {
            try
            {
                CalcSum Sum = new();
                CalcDivision Division = new();
                CalcSubtract Subtract = new();
                CalcMultiplication Multiplication = new();
                Sum.Calculator(decimal.Parse(_lst.First()));
                for (int i = 0; i < _lst.Count; i++)
                {
                    switch (_lst[i])
                    {
                        case "+":
                            Sum.Calculator(decimal.Parse(_lst[i + 1]));
                            break;
                        case "-":
                            Subtract.Calculator(decimal.Parse(_lst[i + 1]));
                            break;
                        case "*":
                            Multiplication.Calculator(decimal.Parse(_lst[i + 1]));
                            break;
                        case "/":
                            Division.Calculator(decimal.Parse(_lst[i + 1]));
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
