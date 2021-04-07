using Core.Entities.Concrete;
using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";

        public static string CarAdded = "Araç Eklendi";
        public static string CarNameInvalid = "Araç ismi geçersiz";
        public static string CarsListed = "Araçlar Listelendi";
        public static string CarUpdated = "Araç bilgisi güncellendi";
        public static string CarDeleted = "Araç silindi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";

        public static string RentalAdded = "Araç kiralandı";
        public static string RentalInvalid = "İşlem Başarısız";
        public static string RentalListed = "Kiradaki araçlar listelendi";
        public static string RentalUpdated = "Güncellendi";
        public static string RentalDeleted = "Silindi";

        public static string CarImageAdded = "Resim Eklendi";
        public static string CarImageNameInvalid = "Resim ismi geçersiz";
        public static string CarImagesListed = "Resimler Listelendi";
        public static string CarImageUpdated = "Resim bilgisi güncellendi";
        public static string CarImageDeleted = "Resim silindi";

        public static string AuthorizationDenied="Yetkiniz yok";

        public static string UserRegistered="Kullanıcı kaydedildi";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Şifre hatalı";
        public static string SuccessfulLogin="Giriş başarılı";
        public static string UserAlreadyExists="Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
