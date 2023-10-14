namespace SOLIDExample.Vehicle
{

    /*Example
     * Bad:- A base class with some methods and sub classes throwing NotImplementedException for those methods it don't need
     * Good:- A base class with some methods and sub classes implement those methods and those are needed as well.
     */
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    public class Car : Vehicle
    {
        public override void Drive(){}
    }

    public class Jeep : Vehicle
    {
        public override void Drive(){}
    }
}
