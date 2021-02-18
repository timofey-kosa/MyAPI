﻿using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Models;

namespace LogicLayer.Requests
{
    public class UserRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
       
        public string Password { get; set; }
        public Office Office { get; set; }        

    }
}
