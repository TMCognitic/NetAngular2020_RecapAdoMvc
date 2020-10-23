using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Entities;
using Models.Interfaces;
using Models.Repositories;
using Tools.Connection;

namespace AppApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ILogger<ContactController> _logger;
        private readonly IContactRepository _contactRepository;

        public ContactController(ILogger<ContactController> logger, IContactRepository contactRepository)
        {
            _logger = logger;
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public IEnumerable<Contact> Get()
        {

            return _contactRepository.Get();
        }

        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _contactRepository.Get(id);
        }
    }
}
