﻿using PatientData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PatientData.Controllers
{
    [EnableCors("*","*","GET")]
    [Authorize]
    public class CustomersController : ApiController
    {
        public CustomersController()
        {

        }
        public List<Customer> Get()
        {
            return CustomerDb.GetGata();
        }
    }
}
