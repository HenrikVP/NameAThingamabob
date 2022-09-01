// Med using kan man bruge fra andre namespaces/klasser
using OOP007Inheritance;

// Namespace er en indpakning (Encapsulation) som gør at access modifiers
// med Internal kan ses i det
namespace NogetAndetEndProjektNavn
{
    // Rækkefølgen på indholdet i en klasse er: Field -> Properties -> Metoder.
    // Klasser er også skabelonen for et objekt, og instantieres med 'new' keyword.
    class KlasseNavn
    {
        // Field, vil typisk være Private med camelCasing
        // Eller public med PascalCasing (Som ikke anbefales).
        // Værdier kan sættes, men er ikke nødvendigt.
        private int privateField = 5;
        public int PublicField;

        // AutoImpl properties behøver ikke et field (skjult).
        public int AutoImplementedProperty { get; set; }

        // Properties med getter & setters sætter værdien (value) i et field (Set)
        // og returnerer værdien fra fieldet (Get) med mulighed for at lave logik i deres respektive bodies.
        public int PropertyWithGetterAndSetterForField
        {
            get
            {
                if (privateField > 10) return 10;
                else return privateField;
            }
            set
            {
                if (value < 0) privateField = 0;
                else privateField = value;
            }
        }

        // METODER
        // Access modifier (Public, Internal, Protected & Private)
        // Static / Non-Static (Der er kun én instans af static, mens non-static kan bruges i objekter.
        // Returtype (void returnerer ingenting) ellers returnerer den typen
        // Metodenavn (Det skal være PascalCasing, kort og sigende på engelsk)
        // Parameter (ingen, en eller flere af samme eller forskellige typer)
        // Body hvor logikken står i.
        public static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }

            // Hvis man skal have fat i et andet namespace kan man enten
            // Tilføje det før klassenavnet eller bruge en using.

            // Man instantierer et objekt ved at bruge new keyword,
            // og skal man genbruge objektet, skal man oprette en
            // variable af objekt typen. Dette bliver referencen.
            
            // Man kan ikke instantiere et objekt fra en abstrakt klasse.
            //OOP007Inheritance.BaseInheritance baseInheritance = new();

            //Typen            Variable/reference   Ny instans af objektet
            DerivedInheritance derivedInheritance = new();
            // Vi nedarver metoder og properties mm. fra vores baseklasse
            // For at benytte os af objektet skal vi skrive
            // referencenavnet/variablenavnet efterfulgt af et punktum.            derivedInheritance.MyBaseMethod();
            derivedInheritance.MyBaseMethod();

            derivedInheritance.MyBaseProperty = 100;

            BaseDerivedInheritance bdi = new();
            bdi.MyBaseMethod();
        }
    }
}
