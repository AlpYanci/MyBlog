﻿using MyBlog.DAL.ORM.Enum;
using MyBlog.DAL.ORM.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DAL.ORM.Entity
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role{ get; set; }

        public virtual List<Article> Articles { get; set; }
        public virtual List<Like>Likes { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
