using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CreateDatabase.DAL.Classes
{
    [Table("tblPostTagMap")]
    public class PostTagMap
    {
        [ForeignKey("Post.Id")]
        public int PostId { get; set; }
        [ForeignKey("Tag.Id")]
        public int TagId { get; set; }
  
        public virtual Post Post { get; set; }
       
        public virtual Tag Tag { get; set; }

    }
}
