using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int müşteriNumarası = 15000000;

            ÇalıştırmaMotoru.KomutÇalıştır("MuhasebeModulu", "MaaşYatır", new object[] { müşteriNumarası });
            ÇalıştırmaMotoru.KomutÇalıştır("MuhasebeModulu", "YıllıkÜcretTahsilEt", new object[] { müşteriNumarası });


            ÇalıştırmaMotoru.BekleyenİşlemleriGerçekleştir();
        }

        public class ÇalıştırmaMotoru
        {
            public static object[] KomutÇalıştır(string modülSınıfAdı, string methodAdı, object[] inputs)
            {
                var cmdList = "";
                //var cmdList = new List<SqlCommand>();
                //Veritabanına kayıt işlemi yapılırken sürekli baglantı acıp kapatmamak için commandList olusturuldu.
                var cmd = Veritabanıİşlemleri.BekleyenIsleriKaydet(modülSınıfAdı, methodAdı, inputs);
                //cmdList.add(cmd);

                Veritabanıİşlemleri.Kaydet(cmdList);

                throw new NotImplementedException();
            }



            public static void BekleyenİşlemleriGerçekleştir()
            {
                var sonuc = Veritabanıİşlemleri.BekleyenIsleriGetir();

                var bekleyenIsler = new List<Is>();

                //sonuc bilgisini donerek bekleyenIsListesiOlustur
                bekleyenIsler.Add(new Is
                {
                    MethodAdi = "",
                    ModülSınıfAdı = "",
                    MusteriNumarasi = 0
                });

                var muhasebeModülü = new MuhasebeModülü();

                foreach (var bekleyenIs in bekleyenIsler)
                {
                    muhasebeModülü.BekleyenIsYukle(bekleyenIs.MethodAdi,bekleyenIs.MusteriNumarasi);
                }
            }
        }





        public class MuhasebeModülü
        {
            private void MaaşYatır(int müşteriNumarası)
            {

                // gerekli işlemler gerçekleştirilir.

                Console.WriteLine(string.Format("{0} numaralı müşterinin maaşı yatırıldı.", müşteriNumarası));

            }
            private void YıllıkÜcretTahsilEt(int müşteriNumarası)
            {
                // gerekli işlemler gerçekleştirilir.

                Console.WriteLine("{0} numaralı müşteriden yıllık kart ücreti tahsil edildi.", müşteriNumarası);

            }
            private void OtomatikÖdemeleriGerçekleştir(int müşteriNumarası)
            {

                // gerekli işlemler gerçekleştirilir.

                Console.WriteLine("{0} numaralı müşterinin otomatik ödemeleri gerçekleştirildi.", müşteriNumarası);

            }

            public void BekleyenIsYukle(string methodTip, int müşteriNumarası)
            {
                switch (methodTip)
                {
                    case "MaaşYatır":
                        MaaşYatır(müşteriNumarası);
                        break;
                    case "YıllıkÜcretTahsilEt":
                        YıllıkÜcretTahsilEt(müşteriNumarası);
                        break;
                    case "OtomatikÖdemeleriGerçekleştir":
                        OtomatikÖdemeleriGerçekleştir(müşteriNumarası);
                        break;
                }
            }
        }



        public class Veritabanıİşlemleri
        {

            public static string BekleyenIsleriKaydet(string modülSınıfAdı, string methodAdı, object[] inputs)
            {
                //Bekleyen işleri database e yazan sql cümlecisi olustur
                return "";
            }

            public static void Kaydet(string commandList)
            {
                //Bekleyen işleri db ye kaydet
            }

            public static object BekleyenIsleriGetir()
            {

                //BekleyenIsler Tablosundan ısleri getir.
                return "";
            }

        }
    }
}
