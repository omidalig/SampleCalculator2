namespace datinconsolapp1
{
    internal class Middlevele: ICaller
    {
        public void Call()
        {
            ///summary
            /// when a Middlevel Programming
            ///summary
            List<string> lstclc = new();
            Console.WriteLine("lotfan yek adad ra vared konid :");
            string valmidlevel1 = Console.ReadLine();
            Console.WriteLine("lotfan adad dovom ra vared konid :");
            string valmidlevel2 = Console.ReadLine();
            Console.WriteLine("lotfan amaliat ra vared konid :");
            string operationmidlevel = Console.ReadLine();
            lstclc.Add(valmidlevel1);
            lstclc.Add(operationmidlevel);
            lstclc.Add(valmidlevel2);
            while (Console.ReadLine() != "end")
            {
                Console.WriteLine("lotfan yek adad ra vared konid :");
                valmidlevel1 = Console.ReadLine();
                Console.WriteLine("lotfan adad dovom ra vared konid :");
                valmidlevel2 = Console.ReadLine();
                Console.WriteLine("lotfan amaliat ra vared konid :");
                operationmidlevel = Console.ReadLine();
                lstclc.Add(valmidlevel1);
                lstclc.Add(operationmidlevel);
                lstclc.Add(valmidlevel2);
            }
            MiddlevelCalc midleveleCalc = new MiddlevelCalc(lstclc);
        }
    }
}
