using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelVM personel = new PersonelVM() { name = "Ali", phone = "05055050505" };
            Personel pm = TypeConversion.Coversion<PersonelVM, Personel>(personel);
            Console.WriteLine(pm.ToString());
        }
    }
    public class Personel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public override string ToString()
        {
            return $"Personel details; id:{id} name:{name} phone:{phone}";
        }
    }
    public class PersonelVM
    {
        public string name { get; set; }
        public string phone { get; set; }
    }
}
