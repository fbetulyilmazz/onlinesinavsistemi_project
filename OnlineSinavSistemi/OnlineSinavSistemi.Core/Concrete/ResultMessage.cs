using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavSistemi.Core.Concrete
{
    public class ResultMessage<T>
    {
        //durum basarili mi diye kontrol edicem 
        public bool BasariliMi { get; set; }
        //geri donus verisi istersem icine basıcam
        public T Data { get; set; }
        //hata mesajı veya bilgi mesajı vermej istersem icine basıcam
        public string Mesaj { get; set; }
    }
}
