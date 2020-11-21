using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Jamil";
        }

        //[HttpPost]
        //public string Post(string title, string firstName, string surname, int age)
        //{
        //    return $"Customer created: {title} {firstName} {surname} {age}";
        //}

        [HttpPost]
        public string Post([FromBody] Customer customer)
        {
            return $"Customer created: {customer.title} {customer.firstName} {customer.surname} {customer.age}";
        }

        [HttpPost("{firstName}")]
        public string PostWithRouteParams(string firstName)
        {
            return $"Customer created to: {firstName}";
        }

        [HttpDelete]
        
        public string Delete()
        {
            return $"Customer Removed";
        }

        [HttpPut]

        public string Put()
        {
            return $"Customer updated";
        }
    }

    public class Customer
    {
        public string firstName { get; private set; }
        public string surname { get; set; }
        public string title { get; set; }
        public int age { get; set; }

    }
}
