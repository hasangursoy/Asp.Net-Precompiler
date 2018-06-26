# Asp.Net-Precompiler

A simple, Asp.Net source-code pre-compiler tool

Microsoft Asp.Net’in en güzel özelliklerinden biri de yayınlanmadan önce derlenebiliyor olmasıdır. Bu sayede sitenizin kaynak kodları hem FTP’ye erişimi olan diğer kişilerce doğrudan görüntülenemez hem de web siteniz MSIL’ye derlendiğinden daha hızlı çalışır.

Bu program aslında Visual Studio’da bulunan Build » Publish Web Site ile aynı görevi görüyor. Fakat taşınabilir ve çalışabilmesi için bilgisayarınızda sadece .Net Framework’ün yüklü olması yeterli.

Programı kullanmak için öncelikle kodlamada kullandığınız Framework versiyonunu seçiyorsunuz. Sonra örneğin wwwroot klasörünüzde bulunan web sitenizin kaynak kodlarını source (kaynak) olarak gösteriyorsunuz. Destination (hedef) olarak ise herhangi bir boş klasör seçmeniz gerekir veya oluşturulabilecek bir klasör ismi de yazabiliyorsunuz. Open destination folder after compile (derleme sonunda hedef klasörü aç)’ı derleme esnasında da işaretleyebilirsiniz.

Compile (derle) butonuna bastıktan sonra kod boyutuna bağlı olarak derleme tamamlanacak veya hata varsa görüntülenecektir. Hedef klasörümüzde oluşan dosyalar bizim web sitemizin dizinine atmamız gereken dosyalardır. Bunların içindeki en önemlisi ise bin klasörü ve web.config dosyası. Bunlar sitenizin asp.net özel dosyalarının kodlarını içerir.
