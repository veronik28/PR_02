﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Producer
    {
        //[Key]
        //public int Id { get; set; }
        //public string? Title { get; set; }

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [DisplayName("Название")]
        public string? Title { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Рэйтинг")]
        [Required(ErrorMessage = "Поле не может быть пустым")]
        [Range(1, int.MaxValue, ErrorMessage = "Значение должно быть больше нуля")]
        public string Rating { get; set; }


    }
}
