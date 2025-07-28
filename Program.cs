Console.WriteLine("Liste İçinde kaç  adet olduğunu bulma ");
List<string> ogrenciler = [
    "Emre Aydın",
    "Zeynep Güneş",
    "Melis Karaca",
    "Caner Arslan",
    "Ahmet Yılmaz",
    "Ayşe Demir",
    "Fatma Koç",
    "Burak Yıldız",
    "Mehmet Kaya",
    "Selin Özkan",
    "Elif Şahin",
    "Fatma Koç",
    "Emre Aydın",
    "Ahmet Yılmaz",
    "Burak Yıldız",
    "İrem Korkmaz",
    "Ayşe Demir",
    "Burak Yıldız",
    "Elif Şahin",
    "Mert Taş",
    "Selin Özkan",
    "Caner Arslan",
    "Zeynep Güneş",
    "Burak Yıldız",
    "Ahmet Yılmaz",
    "Selin Özkan",
    "Ahmet Yılmaz",
    "Oğuzhan Çelik",
    "Ayşe Demir",
    "Deniz Erdem",
    "Mehmet Kaya",
    "Elif Şahin",
    "Fatma Koç",
    "Emre Aydın",
    "Caner Arslan",
    "Elif Şahin",
    "Ahmet Yılmaz",
    "Emre Aydın",
    "Burak Yıldız",
    "Selin Özkan"
];

    
Console.Write("Adı Soyad giriniz: ");
string students = Console.ReadLine();
    
    
int sayac = 0;
for (int i = 0; i < ogrenciler.Count; i++)
{
    if (ogrenciler[i] == students)
    {
        sayac ++;
    }
}

if (sayac > 0 )
{
    Console.WriteLine($"'{students}' ismi listede {sayac} kez bulunuyor. ");
}
else
{
    Console.WriteLine($"'{students}' isim listede bulanamadı. ");
}