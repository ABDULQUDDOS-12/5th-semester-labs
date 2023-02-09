using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Login_MVC_.Models
{
    public class FileClass
    {
        [Key]
        public int FileClassId { get; set; }
        public string Name { get; set; }    
        public byte [] file { get; set; }

    }
}