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
    
    public partial class Kategori
    {
        public Kategori()
        {
            this.Urun = new HashSet<Urun>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Açıklama { get; set; }
    
        public virtual ICollection<Urun> Urun { get; set; }
    }
}
