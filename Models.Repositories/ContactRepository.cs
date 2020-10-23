using Models.Entities;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Transactions;
using Tools.Connection;

namespace Models.Repositories
{
    public sealed class ContactRepository : IContactRepository
    {

        private Connection _connection;

        public ContactRepository()
        {
            _connection = new Connection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AppWeb;Integrated Security=True;");
        }        

        public IEnumerable<Contact> Get()
        {
            Command command = new Command("select Id, LastName, FirstName, Email, BirthDate from Contact");
            return _connection.ExecuteReader(command, dataReader => dataReader.ToContact());
        }

        public Contact Get(int id)
        {
            Command command = new Command("select Id, LastName, FirstName, Email, BirthDate from Contact where Id = @Id");
            command.AddParameter("Id", id);
            return _connection.ExecuteReader(command, dataReader => dataReader.ToContact()).SingleOrDefault();
        }


    }
}
