Console.WriteLine("Bir Cümle Giriniz");
List<char> sesliHarf=new List<char>(){'a','e','ı','i','o','ö','u','ü'};
List<char> cumledekiSesliHarf=new List<char>();
string cumle=Console.ReadLine();
if (cumle.Length>100)
{
    Console.WriteLine("Çok uzun cümle girdiniz!!");
    return;
}
for (int i = 0; i < cumle.Length; i++)
{
    for (int j = 0; j <8; j++)
    {
        if (cumle[i]==sesliHarf[j])
        {
            cumledekiSesliHarf.Add(sesliHarf[j]);
        }
    }
}


int a=0,e=0,i1=0,i2=0,u=0,u2=0,o=0,o2=0;
    foreach (var harf in cumledekiSesliHarf)
    {
       if ('a'==harf)
       {
        a++;
       }
       if ('e'==harf)
       {
        e++;
       }
       if ('ı'==harf)
       {
        i2++;
       }
       if ('i'==harf)
       {
        i1++;
       }
       if ('u'==harf)
       {
        u++;
       }
       if ('ü'==harf)
       {
        u2++;
       }
       if ('o'==harf)
       {
        o++;
       }if ('ö'==harf)
       {
        o2++;
       }
    }

foreach (var harf in cumledekiSesliHarf)
{
    Console.WriteLine(harf);
}
Console.WriteLine("Cümlede "+a+" Tane a var!!");
Console.WriteLine("Cümlede "+e+" Tane e var!!");
Console.WriteLine("Cümlede "+o+" Tane o var!!");
Console.WriteLine("Cümlede "+o2+" Tane ö var!!");
Console.WriteLine("Cümlede "+i2+" Tane ı var!!");
Console.WriteLine("Cümlede "+i1+" Tane i var!!");
Console.WriteLine("Cümlede "+u+" Tane u var!!");
Console.WriteLine("Cümlede "+u2+" Tane ü var!!");
