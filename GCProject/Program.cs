namespace GCProject
{
    class BigClass : IDisposable
    {
        //public int[] arr = new int[1000];
        public BigClass()
        {
            Console.WriteLine("object construct");
        }

        public void Dispose()
        {
            Console.WriteLine("object destruct");
        }

        //~BigClass()
        //{
        //    Console.WriteLine("object destruct");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    BigClass bigClass = new BigClass();
            //    bigClass.Dispose();
            //}


            using(BigClass bigClass = new BigClass())
            {
                Console.WriteLine("big class is work");
            }


            GC.Collect(0);
            Console.WriteLine("Program is work...");


            //int a;
            //int b;
            //int c;


            //Console.WriteLine(GC.MaxGeneration);
            //Console.WriteLine($"Total Busy memry: {GC.GetTotalMemory(false)}");

            //object obj = new object();
            //Console.WriteLine($"Curr generation - {GC.GetGeneration(obj)}");
            //for (int i = 0; i < 500; i++)
            //{
            //    var iarr = new BigClass();
            //}

            //Console.WriteLine($"Total Busy memry: {GC.GetTotalMemory(false)}");

            //GC.Collect(0);
            //GC.Collect(2);
            //Console.WriteLine($"Curr generation - {GC.GetGeneration(obj)}");



        }
    }
}