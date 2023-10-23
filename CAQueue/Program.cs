namespace CAQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enqueue: Adds an object to the end of the Queue
            //Dequeue: This method removes and returns the element present at the beginning of the queue
            Queue<PrintingJob> printingJobs = new Queue<PrintingJob>();
            printingJobs.Enqueue(new PrintingJob("documentation.docx", 2));
            printingJobs.Enqueue(new PrintingJob("user-stories.pdf", 6));
            printingJobs.Enqueue(new PrintingJob("report.xlsx", 6));
            printingJobs.Enqueue(new PrintingJob("payroll.report", 5));
            printingJobs.Enqueue(new PrintingJob("budget.xlsx", 4));
            printingJobs.Enqueue(new PrintingJob("algorithm.ppt", 1));

            Console.WriteLine($"Current  Before while Queue Count: {printingJobs.Count}");

            Random rnd = new Random();
            while (printingJobs.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                var job = printingJobs.Dequeue();
                Console.WriteLine($"printing ... [{job}]");
                System.Threading.Thread.Sleep(rnd.Next(1, 5) * 1000);
            }

            Console.WriteLine($"Current  After while Queue Count: {printingJobs.Count}");
            Console.WriteLine("-------------------------------");

            Queue<int> numbers = new Queue<int>();
            // we use tryPeek if queue is empty the program will not give exeption
            if (numbers.TryPeek(out int n))
            {
                Console.WriteLine(n);

            }
            Console.ReadKey();
        }
    }
    class PrintingJob
    {
        private readonly string _file;
        private readonly int _copies;

        public PrintingJob(string file, int copies)
        {
            _file = file;
            _copies = copies;
        }

        public override string ToString()
        {
            return $"{_file} x #{_copies} copies";
        }
    }
}