using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Shop.Models
{
    public class Review : IEntity
    {
        [Range(0,10)]
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int ProductId { get; set; }


        public string Name { get; set; }


    }
}