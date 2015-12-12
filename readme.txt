System.EnterpriseServices library referans olarak eklenmeli.
GUID i visual studio da üret ve classin basina yaz. %Installation Path%\Microsoft Visual Studio 11.0\Common7\Tools\guidgen.exe
ComVisible class da olursa bütün methodlari etkiler. Granüler seviye istenirse method basina comvisible konmali.
Com+ in konacagi kategorinin Application Root Directory'si dll ve config'in oldugu yeri göstermeli.

Strong name olusturulmasi gerekli. Aksi takdirde com+ kategorisine eklenemez.
Strong name key: skyfall
Project properties -> Signing. Sign the assembly seçilir. New seçilir.
Key file name: skyfall. No password for testing purposes.

Roles: Authenticated Users