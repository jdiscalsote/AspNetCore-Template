using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using System.Web;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCore_Template.Models
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
