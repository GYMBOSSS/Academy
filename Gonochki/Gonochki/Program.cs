using Element;
using Vehicle.Cars;

/*static bool GetBooleanValue(double chance)
{
    Random random = new Random();
    double randomValue = random.NextDouble();
    if (randomValue < chance)
    {
        return true;
    }
    else
    {
        return false;
    }
}*/
namespace Element
{
    abstract class Element
    {
        public double Serviceability { get; set; }
    }
    class Engine : Element
    {
        public Engine(double x) { Serviceability = x; }
    }

    class Hodovka : Element
    {
        public Hodovka(double x) { Serviceability = x; }
    }
    class Wheel : Element
    {
        public Wheel(double x) { Serviceability = x; }
    }
}
namespace Vehicle
{
    interface IMoveable
    {
        bool Move();
    }

    abstract class Vehicle : IMoveable
    {
        public virtual bool GetBooleanValue(double chance)
        {
            Random random = new Random();
            double randomValue = random.NextDouble();
            if (randomValue < chance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Engine? Dvig { get; set; }
        public Hodovka? Hodov { get; set; }
        public Wheel[]? Kolesa { get { } set { } }
        public virtual bool Move()
        {
            double chance = Dvig.Serviceability + Hodov.Serviceability;
            for (int i = 0; i < Kolesa.Length; i++)
            {
                chance += Kolesa[i].Serviceability;
            }
            return GetBooleanValue(chance);
        }
    }
    namespace Cars
    {
        class Solaris : Vehicle
        {
            public override bool Move()
            {
                return base.Move();
            }
        }

        class Rio : Vehicle
        {
            public override bool Move()
            {
                return base.Move();
            }
        }
    }
    namespace Trucks
    {
        class Kamaz : Vehicle
        {
            public override bool Move()
            {
                return base.Move();
            }
        }

        class Vaz : Vehicle
        {
            public override bool Move()
            {
                return base.Move();
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Engine dvig1 = new Engine(1) { };
        Hodovka hdv1 = new Hodovka(1) { };
        Wheel koleso1 = new Wheel(1) { };
        Wheel koleso2 = new Wheel(1) { };
        Wheel koleso3 = new Wheel(1) { };
        Wheel koleso4 = new Wheel(1) { };
        Solaris solaris1 = new Solaris()
        {
            Dvig = dvig1, Hodov = hdv1,
            Kolesa = { koleso1, koleso2, koleso3, koleso4 }
        }
    }
}