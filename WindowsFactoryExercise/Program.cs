using System;

namespace WindowsFactoryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of database would you like to use?");
            Console.WriteLine("Please choose Mongo, SQL, or list");
            var choice = Console.ReadLine().ToLower().Trim();
            IDataAccess current = DataAccessFactory.GetDataAccessType(choice);

            current.LoadData();
            current.SaveData();

            var sqltest = new SQLDataAccess();
            var lisTest = new ListDataAccess();
            var mongoTest = new MongoDataAccess();

            sqltest.LoadData();
            sqltest.SaveData();

            lisTest.LoadData();
            lisTest.SaveData();

            mongoTest.LoadData();
            mongoTest.SaveData();
        }
    }
}
