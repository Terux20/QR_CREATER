using System;
using System.Drawing;
using QRCoder;
namespace QR_KOD_OLUŞTURUCU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QR kodunu oluşturmak istediğiniz metni girin girin");
            string number = Console.ReadLine();
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(number.ToString(), QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine($"Sayı: {number} QR kod olarak oluşturuldu ve 'qrcode.png' olarak kaydedildi.");
        }
    }
}
