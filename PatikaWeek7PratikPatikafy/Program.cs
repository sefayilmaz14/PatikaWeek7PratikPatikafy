using PatikaWeek7PratikPatikafy;

List<Patikafy> patikafyList = new List<Patikafy>
{
 new Patikafy("Ajda Pekkan", "Pop", 1968, 20),
 new Patikafy("Sezen Aksu", "Türk Halk Müziği /Pop", 1971, 20),
 new Patikafy("Funda Arar", "Pop", 1999, 3),
 new Patikafy("Sertab Erener", "Pop", 1994, 5),
 new Patikafy("Sıla", "Pop", 2009, 3),
 new Patikafy("Serdar Ortaç", "Pop", 1994, 10),
 new Patikafy("Tarkan", "Pop", 1992, 40),
 new Patikafy("Hande Yener", "Pop", 1999, 7),
 new Patikafy("Hadise", "Pop", 2005, 5),
 new Patikafy("Gülben Ergen", "Pop / Türk Halk Müziği", 1997, 10),
 new Patikafy("Neşet Ertaş", "Türk Halk Müziği / Türk Sanat Müziği", 1960, 2)
 };


//S ile başlayan şarkıcılar 
Console.WriteLine("-----------S İle Başlayan Şarkıcılar ------------");

var Ssinger = patikafyList.Where(x => x.FullName.StartsWith("S"));// Starswith ile "S" ile başlayan şarkıcıları buluyoruz

foreach (var singer in Ssinger)
{
    Console.WriteLine(singer.FullName);
}


// Albüm satışı 10 milyon üzeri olan şarkıcılar
Console.WriteLine("-----------Albüm Satışı 10 Miyon Üzeri Olan Şarkıcılar ------------");

var albumSinger = patikafyList.Where(x => x.Album > 10);

foreach (var album in albumSinger)
    { Console.WriteLine(album.FullName + " " +album.Album + " milyon" ); }

//2000 Yılı öncesi çıkış yapmış pop müzik yapan şarkıcılar ( Çıkış yıllarına göre gruplayarak, alfabetik bir sıra ile yazdırınız.)

Console.WriteLine("-----------2000 Yılı Öncesi Çıkış Yapmış Pop Yapan Şarkıcılar ------------");

var popArtistsBefore2000 = patikafyList
           .Where(x => x.Date < 2000 && x.MusicType.Contains("Pop"))
           .GroupBy(x => x.Date)  // Çıkış yıllarına göre grupluyoruz
           .OrderBy(x => x.Key);  // Yıllara göre sıralama yapıyoruz

// Her grup içinde şarkıcıları alfabetik olarak sıralıyoruz
Console.WriteLine("2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
foreach (var group in popArtistsBefore2000)
{
    Console.WriteLine($"Çıkış Yılı: {group.Key}");
    foreach (var artist in group.OrderBy(a => a.FullName))  // Alfabetik sıralama
    {
        Console.WriteLine($" - {artist.FullName}");
    }
}

//En çok albüm satan şarkıcı

    Console.WriteLine("-----------En Çok Albüm Satışı Yapan Şarkıcılar ------------");
var maxalbum =patikafyList.Max(x => x.Album);//En yüksek albüm satışı yapan şarkıcıyı belirliyoruz
var singerMaxAlbum = patikafyList.Where(x => x.Album == maxalbum);//En yüksek albüm satışını seçiyoruz

foreach (var album in singerMaxAlbum)
{ Console.WriteLine(album.FullName + " "+ album.Album + " milyon"); }

//En yeni yapan şarkıcı ve en eski çıkış yapan şarkıcı

Console.WriteLine("-----------En Yeni Çıkış Yapan ve En Eski Çıkış Yapan Şarkıcılar ------------");
var oldDate = patikafyList.Min(x => x.Date);// En eski çıkış yapan şarkıcıyı belirliyoruz
var newDate = patikafyList.Max(y => y.Date);// En yeni çıkış yapan şarkıcıyı belirliyoruz
var singerNewDate  = patikafyList.Where(x => x.Date == newDate);// En yeni çıkış yapan şarkıcıyı seçiyoruz
var singerOldDate = patikafyList.Where(x => x.Date == oldDate);// En eski çıkış yapan şarkıcıyı seçiyoruz
foreach (var album in singerOldDate)
    { Console.WriteLine($"En eski çıkış yapan şarkıcı:\n{album.FullName} Çıkış yılı  {album.Date}"); }
foreach (var album in singerNewDate)
    { Console.WriteLine($"En eski yeni yapan şarkıcı:\n{album.FullName} Çıkış yılı  {album.Date}"); }