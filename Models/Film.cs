using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Models
{
    public class Film
    {
        public int Id { get; set; }

        public string FilmAdi { get; set; }  // doldurmazsann hata vermez str old icin

        public int? Yil { get; set; }  // deg.ici null olabilir sikinti yok, ? yoksa hata verir

        public int? Uzunluk { get; set; }

        public double? IMDB_Puan { get; set; }

        public string Konu { get; set; }

        public string Afis { get; set; }  // db den link cekilecek, str

        public string Fragman { get; set; }  // link gelecek, str

        public int KategoriId { get; set; }  // KategoriId fk 

        public Kategori Kategori { get; set; }  // Kategori fk , Kategori nin pk i burada fk olarak kullaniyoruz

        public int DilId { get; set; }  // fk

        public Dil Dil { get; set; }  // 1.20.00


        // oyuncuları burda tutamayız
        // yorumlar tablosunda film id sini fk olarak tutucaz

        // kategori-film arasinda pkfk iliskisi kurulacak
    }
}
