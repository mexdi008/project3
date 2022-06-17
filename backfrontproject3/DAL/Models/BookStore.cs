using DAL.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class BookStore : BaseEntity
    {
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(255)]
        public string Subtitle { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        public string ImgUrl { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
