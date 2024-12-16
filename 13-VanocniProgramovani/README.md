# Zadání: Balení dárků

Vytvořte program v jazyce C#, který bude simulovat stánek na balení dárků. Program bude pracovat s dárky, které lze různě balit, a výsledný popis i cena balení se vypíší uživateli.

## Požadavky
1. **Základní informace o dárku**:
   - Dárek má popis (např. „hračka“) a příjemce (např. „Karel“).
   - Výstup bude například: „Karel dostane hračku“.

2. **Možnosti balení**:
   - **Krabice**: Cena 16 Kč. Přidá text „v krabici“.
   - **Balicí papír**: Cena 5 Kč. Může mít barvu nebo vzor, např. „modrý pruhovaný“. Přidá text „s [barva/vzor] balicím papírem“.
   - **Stuha**: Cena 3 Kč. Může mít specifikovanou barvu, např. „bílá“. Přidá text „a [barva] stuhou“.

3. **Výstup**:
   - Program vypíše postupně popis dárku s přidaným balením a cenu balení.
   - Například:
     ```plaintext
     Vítejte u stánku na balení dárků!
     Dárek: Karel dostane hračku, Cena za balení: 0 Kč
     Dárek: Karel dostane hračku v krabici, Cena za balení: 16 Kč
     Dárek: Karel dostane hračku v krabici s modrým pruhovaným balicím papírem, Cena za balení: 21 Kč
     Dárek: Karel dostane hračku v krabici s modrým pruhovaným balicím papírem a bílou stuhou, Cena za balení: 24 Kč
     ```

Program lze implementovat s využitím návrhového vzoru **Decorator**, který umožní přidávat vlastnosti k dárkům dynamicky. Každý typ balení bude reprezentován třídou, která dědí z rozhraní základní služby balení `IWrappingService`, definující metody `Describe()` a `Cost()`. Základní dárek bude implementován třídou `Gift`. Dekorátory jako `BoxDecorator`, `WrappingPaperDecorator` a `RibbonDecorator` přidají specifické vlastnosti balení. Hlavní třída `Program` bude obsahovat ukázku, jak kombinovat různé možnosti balení, přičemž výstup bude obsahovat výsledný popis dárku a cenu za balení.
