﻿namespace Biblioteka
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostCode { get; set; }

        public static Address GetCentrineBiblioteka()
        {
            return new Address()
            {
                City = "Kaunas",
                Country = "lietuva",
                Street = "laisves aleja",
                PostCode = 566651
            };

        }
        public static Address GetViesojiBiblioteka()
        {
            return new Address()
            {
                City = "Kaunas",
                Country = "lietuva",
                Street = "Vilniaus g.",
                PostCode = 466652
            };

        }

    }
}