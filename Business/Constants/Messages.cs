using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string SuccessMessages = "Başarılı";
        public static string ErrorMessages = "Başarısız";
        public static string CarImagesListed = "Resimler Listelendi";
        public static string CarImageDoesNotFound = "Araba resmş bulunamadı";
        public static string AuthorizationDenied = "Yetkilendirme Reddedildi";
        public static string UserRegistered = "Kullanıcı Kaydoldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola Hatalı";
        public static string SuccessfulLogin = "Basarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token Yaratıldı";
    }
}
