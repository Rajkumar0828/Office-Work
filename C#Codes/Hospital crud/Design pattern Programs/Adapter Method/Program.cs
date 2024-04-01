using System;

namespace Adapterpattern
{
    // Step 1: Define the Incompatible Interfaces
    // First, we define the two incompatible interfaces, ILightningPhone and IMicroUSBPhone.


    public interface ILightningPhone
    {
        void Recharge();
        void UseLightning();
    }


    public interface IMicroUSBPhone
    {
        void Recharge();
        void UseMicroUSB();
    }


    //  Step 2: Create Concrete Classes
    // Next, we implement these interfaces in concrete classes.

    public class iPhone : ILightningPhone
    {
        private bool connector;

        public void UseLightning()
        {
            connector = true;
            Console.WriteLine("Lightning connector is plugged in.");
        }

        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharging your device");
            }
            else
            {
                Console.WriteLine("Connect Lightning first");
            }
        }
    }

    public class Android : IMicroUSBPhone
    {
        private bool connector;

        public void UseMicroUSB()
        {
            connector = true;
            Console.WriteLine("MicroUSB connector is plugged in.");
        }

        public void Recharge()
        {
            if (connector)
            {
                Console.WriteLine("Recharging your device");
            }
            else
            {
                Console.WriteLine("Connect MicroUSB first");
            }
        }
    }

    //  Step 3: Create the Adapter Class
    // Now, we'll create an adapter that implements the ILightningPhone interface (the target interface) but internally uses an object of IMicroUSBPhone to perform the operations.
    // This is how we bridge the two incompatible interfaces.

    public class LightningToMicroUSBAdapter : ILightningPhone
    {
        private IMicroUSBPhone microUsbPhone;

        public LightningToMicroUSBAdapter(IMicroUSBPhone phone)
        {
            microUsbPhone = phone;
        }

        public void UseLightning()
        {
            Console.WriteLine("Lightning connected");
            microUsbPhone.UseMicroUSB();
        }

        public void Recharge()
        {
            microUsbPhone.Recharge();
        }
    }


    // Step 4: Use the Adapter
    // Finally, let's see how we can use the adapter to charge an iPhone with a MicroUSB charger.


    class Program
    {
        static void Main(string[] args)
        {
            ILightningPhone iPhone = new iPhone();
            IMicroUSBPhone android = new Android();

            Console.WriteLine("Recharging iPhone with Lightning connector:");
            iPhone.UseLightning();
            iPhone.Recharge();
            Console.WriteLine();

            Console.WriteLine("Recharging iPhone with MicroUSB connector via adapter:");
            ILightningPhone adapter = new LightningToMicroUSBAdapter(android);
            adapter.UseLightning();
            adapter.Recharge();
        }
    }





}