using Element;

static bool GetBooleanValue(double chance)
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

namespace Element
{
    abstract class Element
    {
        public virtual void getServiceability() { /*syntax*/ }
        public virtual void setServiceability(bool inf) { /*syntax*/ }
    }
    class Engine : Element
    {
        public double Serviceability;

        public override void getServiceability() { }
        public override void setServiceability(bool inf)
        {
            switch (inf)
            {
                case false:
                    Serviceability = 0;
                    break;
                case true:
                    Serviceability = 0.3;
                    break;
            }
        }
    }

    class Hodovka : Element
    {
        public double Serviceability;

        public override void getServiceability() { }
        public override void setServiceability(bool inf)
        {
            switch (inf)
            {
                case false:
                    Serviceability = 0;
                    break;
                case true:
                    Serviceability = 0.3;
                    break;
            }
        }
    }
    class Wheel : Element
    {
        public double Serviceability;

        public override void getServiceability() { }
        public override void setServiceability(bool inf)
        {
            switch (inf)
            {
                case false:
                    Serviceability = 0;
                    break;
                case true:
                    Serviceability = 0.1;
                    break;
            }
        }
    }
}

namespace Vehicle
{
   
    abstract class Vehicle
    {
        public virtual void ToString(bool x) { /*syntax*/ }
        public virtual bool move(Engine engine, Wheel[] wheels, Hodovka hodovka)
        {
            double digit = 0;
            for (int i = 0; i < wheels.Length;i++)
            {
                digit += wheels[i].getServiceability();
            }
            chance = digit + engine.getServiceability() + hodovka.getServiceability();
            return GetBooleanValue(chance);


        }

    }
    
    namespace Cars
    {
        abstract class Car : Vehicle
        {
            Engine engine;
            Wheel[] wheels = new Wheel[4];
            Hodovka hodovka;
            public virtual void ToString(bool x);
            public virtual bool move(double y);
        }
        class Solaris : Car 
        {
            Engine engine;
            Wheel[] wheels = new Wheel[4];
            Hodovka hodovka;
            public virtual void ToString(bool x) { }
            public virtual bool move() 
            { 
            
            }
        }

    }
}