using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Models
{
    internal static class EntityExtensions
    {
        internal static MinContact ToMinContact(this Contact entity)
        {
            return new MinContact() { Id = entity.Id, LastName = entity.LastName, FirstName = entity.FirstName };
        }
    }
}
