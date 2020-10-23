using Models.Entities;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.Repositories
{
    public sealed class FakeContactService : IContactRepository
    {
        private List<Contact> _contacts;

        public FakeContactService()
        {
            _contacts = new List<Contact>();
            _contacts.AddRange( new Contact[] {
                new Contact() { Id = 1, LastName = "Doe", FirstName = "John", Email = "john.doe@unknow.com" },
                new Contact() { Id = 2, LastName = "Doe", FirstName = "Jane", Email = "john.doe@unknow.com" },
                new Contact() { Id = 3, LastName = "Smith", FirstName = "Hanibal", Email = "john.doe@unknow.com" },
                new Contact() { Id = 4, LastName = "Doe", FirstName = "John", Email = "john.doe@unknow.com" }
            });
        }

        public IEnumerable<Contact> Get()
        {
            return _contacts;
        }

        public Contact Get(int id)
        {
            return _contacts.Where(c => c.Id == id).SingleOrDefault();
        }
    }
}
