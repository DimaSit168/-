using System;
using ClassLibrary;

namespace ConsoleApp
{
    /// Точка входа в программу
    internal class Program
    {
        private static readonly string middleName1;

        public static object Settings { get; private set; }

        private static void Main()
        {
            var NameInvestigator = new Investigator(1, "Рижимин", "Петр", " ");
            var NameInvestigator2 = new Investigator(2, "Викторов", "Константин", " ");
            var NameInvestigator3 = new Investigator(3, "Героев", "Аркадий", " ");
            var NameInvestigator4 = new Investigator(4, "Римский", "Даниил", " ");
            var NameInvestigator5 = new Investigator(5, "Прямовидов", "Игнат", " ");
            var NameInvestigator6 = new Investigator(6, "Гордеев", "Виталий", " ");
      
            var NameConvicted = new Convicted(1, "Ридискин", "Павел", " ");
            var NameConvicted2 = new Convicted(2, "Воров", "Кирил", " ");
            var NameConvicted3 = new Convicted(3, "Горин", "Артемий", " ");
            var NameConvicted4 = new Convicted(4, "Ридискин", "Даниил", " ");
            var NameConvicted5 = new Convicted(5, "Воровитов", "Игнат", " ");
            var NameConvicted6 = new Convicted(6, "Горлин", "Витя", " ");

            var CourtCase = new CourtCase(1, 1208, "Горбушечка", "Убийство", 1977, 1978, 105, middleName1);
            var CourtCase2 = new CourtCase(2, 1380, "Хлопушка", "Порча имущества", 1978, 1979, 168, middleName1);
            var CourtCase3 = new CourtCase(3, 1204, "Хлебозавод", "Кража со взломом", 1979, 1980, 158, middleName1);
            var CourtCase4 = new CourtCase(4, 1206, "Горб", "Убийство", 1977, 1978, 105, middleName1);
            var CourtCase5 = new CourtCase(5, 1388, "Хлеба и зрелищ", "Организованный разбой", 1978, 1979, 162, middleName1);
            var CourtCase6 = new CourtCase(6, 1111, "Хлебоводы", "Угон", 1979, 1980, 166, middleName1);

            Console.WriteLine($"{CourtCase} {NameInvestigator} {NameConvicted}");
            Settings settings = new Settings();
            Settings.AddDatabaseServer("DESKTOP-3011201");
            Settings.AddDatabase("Arhiv");
        }
    }
}