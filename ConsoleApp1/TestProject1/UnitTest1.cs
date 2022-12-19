using static NHibernate.Engine.Query.CallableParser;
using System.Net;
using ConsoleApp;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Convicted()
        {
            string LastName = "Ридискин";
            string FirstName = "Павел";
            string temp = $"{LastName} , {FirstName}";

            var NameConvicted = new Convicted(1, LastName, FirstName, " ");
            Console.WriteLine(NameConvicted);

            ///Assert.Equals(convicted.ToString(), temp);
        }
    }
}