using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CreateDatabase.DAL.Classes
{
    [Table("tblCategory")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string UrlSlug { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
    }
}
