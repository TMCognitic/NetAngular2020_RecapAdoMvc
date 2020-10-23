using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Models.Repositories
{
    internal static class DataReaderExtensions
    {
        internal static Contact ToContact(this IDataReader dataReader)
        {
            return new Contact() { Id = (int)dataReader["Id"], LastName = (string)dataReader["LastName"], FirstName = (string)dataReader["FirstName"], Email = (string)dataReader["Email"], BirthDate = (DateTime)dataReader["BirthDate"] };
        }
    }
}
