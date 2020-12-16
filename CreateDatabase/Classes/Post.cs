using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CreateDatabase.DAL.Classes
{
    [Table("tblPosts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Title { get; set; }
        [Required, StringLength(255)]
        public string ShortDescription { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        [Required, StringLength(100)]
        public string Meta { get; set; }
        [Required, StringLength(100)]
        public string UrlSlug { get; set; }
        public byte Published { get; set; }
        public byte PostedOn { get; set; }
        public byte Modified { get; set; }
        [ForeignKey("category.Id")]
        public int CategoryId { get; set; }

        public virtual Category category { get; set; }

    }
}
