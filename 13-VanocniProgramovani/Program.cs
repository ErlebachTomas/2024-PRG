using _13_vanocniProgramovani;


IWrapGift gift = new Gift("Xbox S", "Karel", 9000 );
gift = new BoxDecorator(gift);
gift = new WrappingPaperDecorator(gift, "modrým pruhovaným");
gift = new RibbonDecorator(gift, "bílou");
PrintGift(gift);

gift = new Gift("Panenku", "Jana", 300);
gift = new WrappingPaperDecorator(new BoxDecorator(gift), "červeným srdíčkovým");
PrintGift(gift);


static void PrintGift(IWrapGift gift)
{
    Console.WriteLine($"Dárek: {gift.Describe()}");
    Console.WriteLine($"Cena za balení: {gift.Cost()} Kč\n");
}