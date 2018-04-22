﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularEf.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularEf.Controllers
{
    [Route("api/[controller]")]
    public class MemberWebApiController : Controller
    {
        MemberDataAccessLayer objmember = new MemberDataAccessLayer();
         // GET: api/values
         [HttpGet]
        public IEnumerable<Member> Get()
        {
            return objmember.GetAllEmployees();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/values
        [HttpPost]
        public int Post([FromBody]Member member)
        {
            return objmember.AddEmployee(member);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public int Put( [FromBody]Member member)
        {
            return objmember.UpdateEmployee(member);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
