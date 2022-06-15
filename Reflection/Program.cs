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

            Personel personel2 = new Personel() {id=5, name = "Ali", phone = "05055050505" };
            PersonelVM pvm = TypeConversion.Coversion<Personel, PersonelVM>(personel2);
            Console.WriteLine(pvm.ToString());
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
        public override string ToString()
        {
            return $"PersonelVM details; name:{name} phone:{phone}";
        }
    }
}
