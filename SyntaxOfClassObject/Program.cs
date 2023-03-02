using SyntaxOfClassObject;
class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person
        {
            LastName = "Rand",
            FirstName = "James",
            Adress = new Adress
            {
                Country = "Andor",
                Region = "Tworiver",
                City = "Magicwond",
            }
        };

    }
}
       