namespace datinconsolapp1
{
    internal class Jonior: ICaller
    {
        public void Call()
        {
            ///summary
            /// when a Jonior Programming
            ///summary


            JoniorCalc JoniorCalc = new JoniorCalc();

            Console.WriteLine("lotfan yek adad ra vared konid :");
            double val1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lotfan adad dovom ra vared konid :");
            double val2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("lotfan amaliat ra vared konid :");
            string operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.WriteLine("hasel Jame :");
                Console.WriteLine(JoniorCalc.JoniorsSum(val1, val2));
            }
            else
            {
                if (operation == "-")
                {
                    Console.WriteLine("hasel Tafrigh:");
                    Console.WriteLine(JoniorCalc.JoniorsSubtract(val1, val2));
                }
                else
                {
                    if (operation == "*")
                    {
                        Console.WriteLine("hasel Zarb :");
                        Console.WriteLine(JoniorCalc.JoniorsMultiplication(val1, val2));
                    }
                    else
                    {
                        if (operation == "/")
                        {
                            Console.WriteLine("hasel Taghsim = \t");
                            Console.WriteLine(JoniorCalc.Joniorsdivision(val1, val2));
                        }
                    }
                }
            }
        }
    }
}
