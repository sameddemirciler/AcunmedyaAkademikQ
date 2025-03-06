// See https://aka.ms/new-console-template for more information

using PR19OOP.Abstracts;
using PR19OOP.Classes;
using System.Collections;


Araba a = new Araba();
a.marka = "Bmw";
a.model = "x5";
a.kapiSayisi = 4;
a.pencereSayisi = 4;

Bmw bm = new Bmw();
bm.HavadaUc("Bmw");
bm.DenizdeYüz("Bmw");
bm.HizliGİt("Bmw");

Mercedes me = new Mercedes();
me.HavadaUc("Mercedes");
me.DenizdeYüz("Mercedes");

Porche p = new Porche();
p.HavadaUc("Porsche");

GenelMudur gm = new GenelMudur();
Mudur mu = new Mudur();
Programci pr = new Programci();
Stajyer s = new Stajyer();


double toplamMaas = 0.0;

toplamMaas += gm.maasiniziNedir();
toplamMaas += mu.maasiniziNedir();
toplamMaas += pr.maasiniziNedir();
toplamMaas += s.maasiniziNedir();

Console.WriteLine("Toplam : " + toplamMaas + " TL maaş alıyorlar");

Renault re = new Renault();
Mazda ma = new Mazda();
Fiat fi = new Fiat();

double toplamYakıt = 0.0;

toplamYakıt += re.yakitTuketim();
toplamYakıt += ma.yakitTuketim();
toplamYakıt += fi.yakitTuketim();

Console.WriteLine("Toplam :" + toplamYakıt + " Lt Yakıt tüketiliyor");



