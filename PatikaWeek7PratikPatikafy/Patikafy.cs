using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek7PratikPatikafy
{
    public class Patikafy
    {
        public string FullName { get; set; }
        public string MusicType { get; set; }
        public int Date { get; set; }

        public int Album { get; set; }


        public Patikafy(string fullName, string musicType, int date, int album)
        {
            FullName = fullName;
            MusicType = musicType;
            Date = date;
            Album = album;
        }

        public override string ToString()
        {
            return $"Şarkıcının Adı ve Soyadı: {FullName}, Yaptığı Müzik Türü: {MusicType}, Çıkış Yılı: {Date}, Albüm Satışları: {Album} milyon";
        }
    }
}
