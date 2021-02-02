using System;

namespace AdapterTask
{
    [Serializable]
    public class Person
    {
        public Person()
        {
            // default constructor for saver in XML
        }
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
