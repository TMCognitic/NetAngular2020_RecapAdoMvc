using Models.Entities;
using System;
using System.Collections.Generic;

namespace Models.Interfaces
{
    public interface IContactRepository
    {
        IEnumerable<Contact> Get();
        Contact Get(int id);
    }
}
