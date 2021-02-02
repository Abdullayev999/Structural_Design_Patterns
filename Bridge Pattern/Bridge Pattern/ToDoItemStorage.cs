using System.Collections.Generic;

namespace Bridge_Pattern
{
    class ToDoItemStorage : Storage<ToDoItem>
    {
        public ToDoItemStorage(ISaveLoader<List<ToDoItem>> saveLoader) : base(saveLoader)
        {

        }

        private List<ToDoItem> toDoItems = new List<ToDoItem>();

        public override void Add(ToDoItem item)
        {
            toDoItems.Add(item);
        }

        public override void Load()
        {
            toDoItems = saveLoader.Load("items");
        }

        public override void Save()
        {
            saveLoader.Save(toDoItems, "items");
        }
    }
}
