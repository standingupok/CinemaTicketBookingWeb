using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace cinema_web.Models
{
    public partial class Film
    {
        public Film()
        {
            ScreeningFilms = new HashSet<ScreeningFilm>();
        }

        [Display(Name = "Id phim")]
        public int FilmId { get; set; }

        [Display(Name = "Tên phim")]
        public string FilmName { get; set; }

        [Display(Name = "Đạo diễn")]
        public string Director { get; set; }

        [Display(Name = "Thể loại")]
        public string Category { get; set; }

        [Display(Name = "Ngôn ngữ")]
        public string Language { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }

        [Display(Name = "Ảnh")]
        public string Thmb { get; set; }

        [Display(Name = "Thời lượng")]
        public int TimeDuration { get; set; }

        [Display(Name = "Trạng thái")]
        public bool IsFilming { get; set; }

        [Display(Name = "Công chiếu")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Giá vé")]
        public long TicketPrice { get; set; }

        public virtual ICollection<ScreeningFilm> ScreeningFilms { get; set; }
    }
}
