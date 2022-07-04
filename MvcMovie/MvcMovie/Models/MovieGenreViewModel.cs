using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<Movies>? Movies { get; set; }// list phim
        public SelectList? Genres { get; set; }// lis the loai
        public string? MovieGenre { get; set; }//the loai dc selected
        public string? SearchString { get; set; }// text ma nguoi dung nhap
    }
}

