using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UploadImage
{
    public static class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName(); //temp dosyası oluşturuyoruz
            if (file.Length > 0) //dosya varsa 
            {
                using (var stream = new FileStream(sourcepath, FileMode.Create)) //temp dosyasını kullanarak oluşturma işlemi yapıcaz
                {
                    file.CopyTo(stream); //formdan gelen dosyayı FileStream kullanarak tempdeki dosyaya yazdırıyoruz
                }
            }
            var result = newPath(file); //formdan gelen dosyayı kaydetmek için kaydolacak dizini ve  adını ayarlıyoruz
            File.Move(sourcepath, result); //tempdeki dosyayı hedef dizine hedef adla beraber kaydediyoruz
            return result; //dosya adını döndürüyoruz
        }

        public static void Delete(string path)
        {
            try
            {
                File.Delete(path); //girilen dizindeki dosyayı sil
            }
            catch (Exception )
            {
                throw new Exception();
            }
        }
        public static string Update(string sourcePath,IFormFile file) //silinecek dosya yolu ve Form nesnesi
        {
            var result = newPath(file); //dosya adının değiştirilmiş yol değerini tutar
            if (sourcePath.Length>0)
            {
                using (var stream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(stream); //formdan gelen dosyayı result taki dizin ve dosya adına kopyalar
                }
            }
            File.Delete(sourcePath); //eski dosyayı siler
            return result; //yeni dosyanın yolunu döndürür
        }

        public static string newPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName); //Formdan gelen dosya adını alıyoruz
            string fileExtension = fileInfo.Extension; //dosya uzantısını alıyoruz
            string path = Path.Combine(Environment.CurrentDirectory, "Images"); //projenin çalıştığı klasörü /Images dizini ile alıyoruz
            string newPath = Guid.NewGuid().ToString() + fileExtension; //Yeni guid ismine dosyanın uzantısını ekliyoruz
            string result = Path.Combine(path, newPath); //dosya dizini ile dosya adını birleştiriyoruz
            return result;

        }
    }
}
