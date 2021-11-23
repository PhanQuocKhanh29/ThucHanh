using BTL_LTQL.Models;
using System;
using System.Linq;
using System.Web.Security;
using System.Collections.Generic;

namespace BTL_LTQL.Controllers
{

    public class Encrytion
    {
        public string PassWordEncrytion(string pass)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(pass.Trim(), "MD5");
        }
    }
}