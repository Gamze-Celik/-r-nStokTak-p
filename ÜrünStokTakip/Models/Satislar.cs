//------------------------------------------------------------------------------
// <auto-generated>
//    Bu kod bir şablondan oluşturuldu.
//
//    Bu dosyada el ile yapılan değişiklikler uygulamanızda beklenmedik davranışa neden olabilir.
//    Kod yeniden oluşturulursa, bu dosyada el ile yapılan değişikliklerin üzerine yazılacak.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ÜrünStokTakip.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Satislar
    {
        public int Id { get; set; }
        public Nullable<int> UrunId { get; set; }
        public Nullable<int> Adet { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public string Resim { get; set; }
        public Nullable<int> KullanıcıId { get; set; }
    
        public virtual Kullanıcı Kullanıcı { get; set; }
    }
}
