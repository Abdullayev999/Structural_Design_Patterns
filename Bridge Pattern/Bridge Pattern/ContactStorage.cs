using System.Collections.Generic;

namespace Bridge_Pattern
{
    class ContactStorage : Storage<Contact>
    {
        public ContactStorage(ISaveLoader<List<Contact>> saveLoader) : base(saveLoader)
        {
            contacts = new List<Contact>();
        }

        private List<Contact> contacts;

        public override void Add(Contact item)
        {
            contacts.Add(item);
        }

        public override void Load()
        {
            contacts = saveLoader.Load("contacts");
        }

        public override void Save()
        {
            saveLoader.Save(contacts, "contacts");
        }
    }
}
