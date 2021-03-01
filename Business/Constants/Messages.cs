using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakım zamanı";
        public static string ProductsListed = "Ürün Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExits= "Aynı isimde ürün olamaz";
        public static string CategoryHaveLimitExceded = "Kategori Limiti aşıldı";

        public static string AuthorizationDenied = "Yetkiniz Yok";

        public static string UserRegistered = "Kayıt Olundu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessfulLogin = "Başarılı işlem";
        public static string UserAlreadyExists = "Kullanıcı var";
        public static string AccessTokenCreated = "Token Oluşturuldu";
    }
}
