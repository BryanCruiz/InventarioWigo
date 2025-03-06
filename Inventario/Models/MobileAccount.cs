using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.Models
{
	public class MobileAccount
	{
        public int ID_MobileAccount { get; set; }

        public string Gmail { get; set; }

        public string Password { get; set; }

        public int? Mobile_Recovery { get; set; }

        public string Gmail_Recovery { get; set; }
    }
}