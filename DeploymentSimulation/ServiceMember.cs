using System;

namespace DeploymentSimulation
{
    public class ServiceMember
    {
        public virtual void Report()
        {
            Console.WriteLine(); ///Calls an Airman or a Soldier
        }
    }

    public class Airman : ServiceMember
    {
        public override void Report()
        {
            Console.WriteLine("Sir, Airman reports as ordered!");
        }

        public void GiveOrder()
        {
            Console.WriteLine("Give your troop an order");
            string input = Console.ReadLine();
        }

        public void AcceptOrder()
        {
            Console.WriteLine("Yes Sir!");
        }
    }

    public class Soldier : ServiceMember
    {
        public override void Report()
        {
            Console.WriteLine("Sir, Soldier reports as ordered!");
        }

        public void GiveOrder()
        {
            Console.WriteLine("Give your troop an order.");
            string input = Console.ReadLine();
        }

        public void AcceptOrder()
        {
            Console.WriteLine("Yes Sir!");
        }
    }
}
