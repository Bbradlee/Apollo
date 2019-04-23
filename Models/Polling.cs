using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace SportsStore.Models
{
    public class Polling
    {
        [Key]
        public int VoteID { get; set; }
        [Required(ErrorMessage = "Please Make a selection")]
        public int Vote { get; set; }
        //public object Lines { get; internal set; }
    }
}