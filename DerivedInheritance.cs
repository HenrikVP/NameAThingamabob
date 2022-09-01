namespace OOP007Inheritance
{
    // For at arve fra en anden klasse skal vi bruge : efterfulgt af
    // klassens navn vi nedarver fra. Man kan kun nedarve fra én klasse.
    // For at lukke for videre nedarvning, skal man bruge keywordet 'sealed'
    internal sealed class DerivedInheritance : BaseDerivedInheritance
    {
        // For at overskrive en nedarvet metode/property 
        // skal vi bruge keywordet 'override' OG
        // gøre metoden i base klassen 'virtual'
        public override void MyBaseMethod()
        {
            Console.WriteLine("This is my derived method");
        }

        // Overloading af metode. Metoden har samme navn og returtype
        // MEN forskellige parametre. Dette vises når man 'mouse-over' 
        // metoden når man kalder den. For at se de forskellige overloads
        // kan man stille sig i parantesen og trykke ctrl+shift+space.
        public void MyBaseMethod(string s)
        {
            Console.WriteLine("This is my derived method " + s);
        }
    }
}
