using System;

namespace Bridge_Pattern
{
    [Serializable]
    public class ToDoItem
    {
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}
