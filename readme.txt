System.EnterpriseServices library referans olarak eklenmeli.
GUID i visual studio da �ret ve classin basina yaz. %Installation Path%\Microsoft Visual Studio 11.0\Common7\Tools\guidgen.exe
ComVisible class da olursa b�t�n methodlari etkiler. Gran�ler seviye istenirse method basina comvisible konmali.
Com+ in konacagi kategorinin Application Root Directory'si dll ve config'in oldugu yeri g�stermeli.

Strong name olusturulmasi gerekli. Aksi takdirde com+ kategorisine eklenemez.
Strong name key: skyfall
Project properties -> Signing. Sign the assembly se�ilir. New se�ilir.
Key file name: skyfall. No password for testing purposes.

Roles: Authenticated Users