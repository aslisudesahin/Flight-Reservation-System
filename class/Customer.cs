
using FligthReservationSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// User sınıfından kalıtım alır
public class Customer : User
{
    // özellikler User sınıfından miras alınıyor.

    //  Boş Yapıcı Metot
    public Customer() : base() { }

    // User sınıfının kurucusunu cagırır
    public Customer(int userId, string userName, string password, string email)
        : base(userId, userName, password, email)
    {
    }

    public override void ViewProfile()
    {
        Console.WriteLine($"Müşteri Profili: Kullanıcı Adı: {UserName}, Email: {Email}");
    }
}