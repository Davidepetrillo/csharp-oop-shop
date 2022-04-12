using CsharpShop;

Random random = new Random();
long codice = random.Next(10000);

Prodotto IlMioProdotto = new Prodotto(codice, "banana", "banane coltivate in Brasile e prodotte in Guatemala", 1.89, 17 );

IlMioProdotto.StampaProdotto();