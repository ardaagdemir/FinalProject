using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static object ProductsListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError  = "Aynı kategoriden en fazla 10 ürün eklenebilir. ";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün bulunmaktadır";
        public static string CategoryLimitExceded = "Katefori limiti aşıldı";
    }
}
