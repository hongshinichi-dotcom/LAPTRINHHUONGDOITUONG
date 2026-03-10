
using QuanLyChiTieu;
TransactionRepository rep = new TransactionRepository(200);

Category c1 = new Category(1);
c1.SetName("Breakfast");
Transaction tx1 = rep.CreateEmpty();
tx1.SetCategory(c1);
tx1.SetType(2);
tx1.SetAmount(50000);
tx1.SetNote("Bun cha");
rep.Add(tx1);

Category c2 = new Category(2);
c2.SetName("Breakfast");
Transaction tx2 = rep.CreateEmpty();
tx2.SetCategory(c2);
tx2.SetType(2);
tx2.SetAmount(40000);
tx2.SetNote("Pho bo tai chin");
rep.Add(tx2);

rep.PrintAll();
