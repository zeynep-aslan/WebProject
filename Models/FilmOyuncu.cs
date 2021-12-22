using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Models
{
    public class FilmOyuncu
    {
        public int Id { get; set; }


        public int FilmId { get; set; }

        public int OyuncuId { get; set; }

        
        public int? Sira { get; set; }



        public Film Film { get; set; }

        public Oyuncu Oyuncu { get; set; }

    }
}
