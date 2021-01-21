using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //convention-- yazım kuralı
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : "+ product.Adi);


        }
        public void Ekle2(string Adi, string aciklama, double fiyat)
        {
            Console.WriteLine("Sepete Eklendi : " );
        }
    }
}
