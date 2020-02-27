using System.Collections.Generic;
using System.Linq;
using SQLite;
using Xamarin.Forms;

namespace RudnevMenuProject
{
    public class MenuRepository
    {
        SQLiteConnection database;
        static object locker = new object();
        public MenuRepository(string filename)
        {
            string databasePath = DependencyService.Get<ISQLite>().GetDatabasePath(filename); // считывает путь из интерфейса который мы создавали
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Menuu>();
        }
        public IEnumerable<Menuu> GetItems()
        {
            return (from i in database.Table<Menuu>() select i).ToList();
        }
        public Menuu GetItem(int id) // Get<T>: позволяет получить элемент типа T по id
        {
            return database.Get<Menuu>(id);
        }

        public int DeleteItem(int id) // функция для удаление записи
        {
            lock (locker)
            {
                return database.Delete<Menuu>(id);
            }
        }
        public int SaveItem(Menuu item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
