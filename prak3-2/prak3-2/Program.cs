namespace prak3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Worker> Rate = new List<Worker>();
            Rate.Add(new Worker("Иван", "Иванович", 321.1, 30));
            Rate.Add(new Worker("Петров", "Базович", 260.23, 48));
            Rate.Add(new Worker("Галина", "Иванова", 427.5, 91));
            while (true)
            {
                Console.WriteLine("Узнать зарплату сотрудника: \n 1.Иван Иванович \n 2.Петров Базович \n 3.Галина Иванова \n 4.Exit");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1: Rate[0].GetSalary(); break;
                    case 2: Rate[1].GetSalary(); break;
                    case 3: Rate[2].GetSalary(); break;
                    case 4: return;
                    default: Console.WriteLine("Ошибка"); break;
                }
            }
        }
    }
}