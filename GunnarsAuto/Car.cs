using System;
using System.Collections.Generic;
using System.Text;

namespace GunnarsAuto
{
   public class Car
    {
        private int carID;
        private string make;
        private string model;
        private string vin;
        private string registration;
        private string isUsed;

        public Car(int carID, string make, string model, string vin, string registration, string isUsed)
        {
            PK_CarID = carID;
            Make = make;
            Model = model;
            VIN_number = vin;
            RegistrationNumber = registration;
            IsUsed = isUsed;
        }
        public int PK_CarID { get { return carID; } set { carID = value; } }
        public string Make { get { return make; } set { make = value; } }

        public string Model { get { return model; } set { model = value; } }

        public string VIN_number { get { return vin; } set { vin = value; } }

        public string RegistrationNumber { get { return registration; } set { registration = value; } }

        public string IsUsed { get { return isUsed; } set { isUsed = value; } }
    }
}
