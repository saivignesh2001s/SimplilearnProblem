using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Asp.NetMvc.Models
{
    public class user
    {
        [Required]
        public int UserID
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        public string Password
        {
            get;
            set;
        }
    }
}