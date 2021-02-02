using System.Collections.Generic;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Storage<Contact> contactStorage = new ContactStorage(new XmlSaveLoader<List<Contact>>());
            //contactStorage.Add(new Contact { Name = "Farid", Phone = "012345" });
            //contactStorage.Add(new Contact { Name = "Cavid", Phone = "678910" });
            //contactStorage.Save();

            Storage<ToDoItem> taskStorage = new ToDoItemStorage(new JsonSaveLoader<List<ToDoItem>>());
            taskStorage.Add(new ToDoItem { Title = "Feed my cat", Done = true });
            taskStorage.Add(new ToDoItem { Title = "Do my homework", Done = false });
            taskStorage.Save();
        }
    }
}
