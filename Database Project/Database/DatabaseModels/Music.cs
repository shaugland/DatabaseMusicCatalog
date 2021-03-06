﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Database_Project.Database.DatabaseModels
{
    public class Music
    {
        [Key]
        public int MusicId { get; set; }
        public string Name { get; set; }
        public string YearReleased { get; set; }
        public int Length { get; set; } // Int or string?
        public string Artist { get; set; }

        public int GenreID { get; set; }
        public Genre Genre { get; set; }
    }
}
