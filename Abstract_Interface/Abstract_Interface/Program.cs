using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface
{
    interface IVehicle
    {
        bool Start(int type);
        void Turn(int direction);
        void Reverse(int direction);
        bool Stop();
    }

    interface IEngine
    {
        double Speed(int distance, int hours);
    }
    class Vehicle
    {
        bool isBatteryCharged = false;

        public Vehicle(bool charged)
        {
            this.isBatteryCharged = charged;
        }

        public virtual bool Start(int type)
        {
            bool result = false;
            if (type == 0 && isBatteryCharged)
            {
                //check for gas
                //if there is gas
                result = true;

            }

            if (isBatteryCharged)
            {
                result = true;

            }
            else
            {
                result = false;
            }
            return result;


        }
        public virtual void Turn(int direction)
        {
            // do something
        }
        public void Reverse(int direction)
        {
            // do something
        }
        public bool Stop()
        {
            return true;
        }

    }
    class Toyota : IVehicle, IEngine
    {
        public void Reverse(int direction)
        {
            throw new NotImplementedException();
        }

        public bool Start(int type)
        {
             throw new NotImplementedException();
        }

        public bool Stop()
        {
            throw new NotImplementedException();
        }

        public void Turn(int direction)
        {
            throw new NotImplementedException();
        }

        public double Speed(int distance, int hours)
        {
            throw new NotImplementedException();
        }
        class Tesla : Vehicle
        {
            bool isBatteryCharged = true;

            public Tesla(bool charged) : base(charged)
            {
                this.isBatteryCharged = charged;
            }

            public override bool Start(int type)
            {
                bool result = false;
                if (isBatteryCharged)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;


            }

            public void Speed(int distance, int hour)
            {
                throw new NotImplementedException();
            }

            public override void Turn(int direction)
            {
                this.Turn(direction);
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                var gasVehicle = new Toyota();
                gasVehicle.Start(0); // needs to implement the Start method in Toyota Class
                gasVehicle.Speed(70, 1);// needs to implement the Speed method in Toyota Class
                gasVehicle.Stop();// needs to implement the Stop methos in Toyota Class
 
                var electricalVehicle = new Tesla(true);
                electricalVehicle.Start(1); // uses over ridden method in Testa Class
                electricalVehicle.Speed(90, 1); // internal method
                electricalVehicle.Stop(); //code reuse from the Vehicle abstract class
                var virtulaVehicle = new Vehicle(true);//  will not work as this a abstract class 
            }
        }
    }
}
 