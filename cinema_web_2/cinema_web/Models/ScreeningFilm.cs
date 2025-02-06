using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace cinema_web.Models
{
    public partial class ScreeningFilm
    {
        [Display(Name = "Id phim")]
        public int FilmId { get; set; }

        [Display(Name = "Id suất chiếu")]
        public int ScreeningId { get; set; }

        public virtual Film Film { get; set; }
        public virtual Screening Screening { get; set; }
    }
}
