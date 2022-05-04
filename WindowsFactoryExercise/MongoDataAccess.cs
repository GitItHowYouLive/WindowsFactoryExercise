using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFactoryExercise
{
    internal class MongoDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from MongoDB.");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine("I am saving data to a mongo database.");
        }
    }
}
