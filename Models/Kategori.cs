using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Models
{
    public class Kategori
    {
        public int Id { get; set; }  // primary key

        public string KategoriAd { get; set; }

        //public ICollection<Film> Film { get; set; }  // o kategorideki tum filmleri getirmek icin bunu yazdik
        // 507205 filmi getirecegi icin sikinti cok kastiriyor, film tablosundan getiririz
    }
}
