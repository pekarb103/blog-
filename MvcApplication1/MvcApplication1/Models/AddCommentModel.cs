 ﻿using System;
 using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MvcApplication1.Models
{
    public class AddCommentModel
    {
       [Required(ErrorMessage = "Пожалуйста,введите {0}!")] 
        [Display(Name = "Комментарий")]
        [StringLength(30)]
        public string Comment { get; set; }
        public UserModel User { get; set; }

    }
}
  