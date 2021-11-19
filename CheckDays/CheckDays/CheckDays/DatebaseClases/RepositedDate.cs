using System;
using System.Text;
using System.Collections.Generic;
using SQLite;
namespace CheckDays.DatebaseClases
{
    public class RepositedDate
    {
        SQLiteConnection database;
        public RepositedDate(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<CreareDateBase>();
        }
        public IEnumerable<CreareDateBase> GetItems()
        {
            return database.Table<CreareDateBase>().ToList();
        }
        public CreareDateBase GetItem(int id)
        {
            return database.Get<CreareDateBase>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<CreareDateBase>(id);
        }
        public int SaveItem(CreareDateBase item)
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
