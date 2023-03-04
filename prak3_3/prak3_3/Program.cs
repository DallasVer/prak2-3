namespace prak3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation rub= new Calculation();

            while (true)
            {
                Console.WriteLine("Работа со строками: \n 1.Изменить значение свойства, \n 2.Прибавить символ \n 3.Вывести значение свойства \n 4.Получить последний символ \n 5.Удалить последний символ из строки; \n 6.Exit");
                int res = Convert.ToInt32(Console.ReadLine());
                switch (res)
                {
                    case 1: rub.SetCalculationLin(); break;
                    case 2: rub.SetLastSymbolCalculationLine(); break;
                    case 3: rub.GetCalculationLin(); break;
                    case 4: rub.GetLastSymbo(); break;
                    case 5: rub.DeleteLastSymbol(); ; break;
                    case 6: return;
                    default: Console.WriteLine("Ошибка"); break;
                }
            }
        }
    }
}