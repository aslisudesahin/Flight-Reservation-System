using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace FligthReservationSystem
{
    // Admin sınıfı User sınıfından miras alır
    public class Admin : User
    {
        // Veritabanı bağlantı adresi
        string baglantiAdresi = @"Server=(localdb)\MSSQLLocalDB;Database=UcakSistemDB;Integrated Security=True";

        public int AdminLevel { get; private set; }

        public Admin() : base() { }

       // user sınıfı ile iletısım kuara
        public Admin(int userId, string userName, string password, string email, int adminLevel)
            : base(userId, userName, password, email)
        {
            AdminLevel = adminLevel;
        }

        //ucus ekleme
        
        public bool UcusEkle(string nereden, string nereye, DateTime tarih, string saat, decimal fiyat, int kapasite, int ucakId)
        {
            string sorgu = @"INSERT INTO Ucuslar (Nereden, Nereye, Tarih, Saat, Fiyat, Kapasite, UcakId, AktifMi) 
                             VALUES (@nereden, @nereye, @tar, @saat, @fiyat, @kap, @uid, 1)";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@nereden", nereden);
                    komut.Parameters.AddWithValue("@nereye", nereye);
                    komut.Parameters.AddWithValue("@tar", tarih.Date); 
                    komut.Parameters.AddWithValue("@saat", saat);    
                    komut.Parameters.AddWithValue("@fiyat", fiyat);
                    komut.Parameters.AddWithValue("@kap", kapasite);
                    komut.Parameters.AddWithValue("@uid", ucakId);

                    return komut.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // ucus guncelle
        
        public bool UcusGuncelle(int id, string nereden, string nereye, DateTime tarih, string saat, decimal fiyat, int ucakId)
        {
            string sorgu = @"UPDATE Ucuslar 
                             SET Nereden=@p1, Nereye=@p2, Tarih=@p3, Saat=@pSaat, Fiyat=@p4, UcakId=@p5 
                             WHERE Id=@pid";

            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);

                    komut.Parameters.AddWithValue("@p1", nereden);
                    komut.Parameters.AddWithValue("@p2", nereye);
                    komut.Parameters.AddWithValue("@p3", tarih.Date);
                    komut.Parameters.AddWithValue("@pSaat", saat);
                    komut.Parameters.AddWithValue("@p4", fiyat);
                    komut.Parameters.AddWithValue("@p5", ucakId);
                    komut.Parameters.AddWithValue("@pid", id);

                    return komut.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        //ucus sılme

        /* public bool UcusSil(int ucusId)
         {
             string sorgu = "DELETE FROM Ucuslar WHERE Id = @id";

             using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
             {
                 try
                 {
                     baglanti.Open();
                     SqlCommand komut = new SqlCommand(sorgu, baglanti);
                     komut.Parameters.AddWithValue("@id", ucusId);

                     return komut.ExecuteNonQuery() > 0;
                 }
                 catch (Exception)
                 {
                     return false;
                 }
             }
         }*/
        public bool UcusSil(int ucusId)
        {
            using (SqlConnection baglanti = new SqlConnection(baglantiAdresi))
            {
                try
                {
                    baglanti.Open();
                    // Gerçekten silmeyi dene. Eğer rezervasyon varsa SQL hata fırlatacak (catch'e düşecek)
                    string sorgu = "DELETE FROM Ucuslar WHERE Id = @id";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@id", ucusId);

                    int sonuc = komut.ExecuteNonQuery();
                    return sonuc > 0;
                }
                catch (SqlException)
                {
                    // Rezervasyon kısıtlaması (Foreign Key) nedeniyle buraya düşerse false döner
                    return false;
                }
            }
        }

        public override void ViewProfile()
        {
            Console.WriteLine($"Admin Paneli: {UserName} (Yetki Seviyesi: {AdminLevel})");
        }
    }
}