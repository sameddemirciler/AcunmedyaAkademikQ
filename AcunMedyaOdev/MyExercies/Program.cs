// See https://aka.ms/new-console-template for more information
using MyExercies.classes;

Car cr = new Car();
cr.marka = "BMW";
cr.model = "M5";
cr.git(cr.marka, cr.model);


BMW bm = new BMW();
bm.markaModel("BMW", "M5");


Mercedes m = new Mercedes();
m.markaModel("Mercedes", "E350");


Ford f = new Ford();
f.markaModel("Ford", "Focus");


Porsche p = new Porsche();
p.marka = "Porsche";
p.model = "Taycan";
p.kapiSayisi = 2;
p.pencereSayisi = 4;
p.vites = "OtoVites";
p.MarkaModelVites(p.marka, p.model,p.vites);


DüzVites dv = new DüzVites();
dv.marka = "BMW";
dv.model = "M5";
dv.pencereSayisi = 4;
dv.kapiSayisi = 4;
dv.vites = "DüzVites";
dv.MarkaModelVites(dv.marka, dv.model, dv.vites);

OtoVites o = new OtoVites();
o.marka = "Mercedes";
o.model = "E350";
o.vites = "OtoVites";
o.MarkaModelVites(o.marka, o.model, o.vites);




