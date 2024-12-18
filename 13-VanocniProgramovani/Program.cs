

using vanocniProgramovani;

IGift gift = new Gift("Xbox S", "Karel", 9000);
gift = new WrappingPaperDecorator(new BoxDecorator(gift), "modrým pruhovaným");

IGift darekProJanu = new Gift("Iphone 16", "Jana");
darekProJanu = new RibbonDecorator(new BoxDecorator(darekProJanu), "růžovou");

IGift darekProPetra = new Gift("Notebook", "Petr", 15000);
darekProPetra = new RibbonDecorator(new WrappingPaperDecorator(new BoxDecorator(darekProPetra), "zeleným"), "zlatou");


Print(gift);
Print(darekProJanu);
Print(darekProPetra);


void Print(IGift gift) {
    Console.WriteLine(gift.Describe() + " za " + gift.Cost() + " kč");
}

