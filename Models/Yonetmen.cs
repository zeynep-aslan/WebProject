using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Models
{
    public class Yonetmen
    {
        public int Id { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }


        public int UlkeId { get; set; }

        public Ulke Ulke { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

        public DateTime DogumTarihi { get; set; }

    }
}
