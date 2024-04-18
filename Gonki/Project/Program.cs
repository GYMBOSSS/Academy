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
}

namespace Vehicle
{
   
    abstract class Vehicle
    {
        public virtual void ToString(bool x) { /*syntax*/ }
        public virtual void move(double y) { /*syntax*/ }

    }
}