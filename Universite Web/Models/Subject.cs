using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Universite_Web.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public int SaatlarnCemi { get; set; }
        public List<RegisterTEACHER> RegisterTEACHERs { get; set; }
    }
}
