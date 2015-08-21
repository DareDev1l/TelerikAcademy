namespace Phone
{
    using System;
    using System.Collections.Generic;
    public class GSM
    {
        // Static variables
        private static GSM iPhone4s = 
            new GSM("iPhone 4s", "Apple", 900, "Bill Gates", new Battery(BatteryType.NiMH), new Display(4.5f, 2.3f, 16000000));

        // Fields
        private string model;
        private string manufacturer;
        private int? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        // Constructors
        public GSM(string model , string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = null;
            this.Owner = null;
            this.Battery = null;
            this.Display = null;
        }

        public GSM(string model, string manufacturer, int price , string owner , Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // Properties
        public List<Call> CallHistory
        {
            get { return this.callHistory; }
        }

        public static GSM IPhone
        {
            get { return iPhone4s; }
        }
        public string Model
        {
            get { return this.model; }
            set 
            {
                // Validation of string  --> it shouldn't be empty
                if (value != "" || value == null)
                {
                    this.model = value;
                } 
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                // Validation of string  --> it shouldn't be empty
                if (value != "" || value == null)
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                // Validation of string  --> it shouldn't be empty
                if (value != "" || value == null)
                {
                    this.owner = value;
                }
                else
                {
                    throw new Exception("String shouldn't be empty!");
                }
            }
        }

        public int? Price
        {
            get { return this.price; }
            set 
            {
                // Validation of the price   -->  It shouldn't be zero or less
                if (value >= 0 || value == null)
                {
                    this.price = value;
                }
                else
                {
                    throw new Exception("Price can not be negative!");
                }
            }
        }

        public Battery Battery
        {
            get { return this.battery ;}
            set { this.battery = value;}
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        // Methods

        // Add call to the call history
        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        // Remove call from the call history
        public void RemoveCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        // Method for calculation of calls prices
        public double CallPrice(double pricePerMinute)
        {
            double price = 0;

            foreach (var call in this.CallHistory)
            {
                price += call.Duration * pricePerMinute;
            }

            return price;
        }

        // Remove all calls from call history
        public void DeleteCallHistory()
        {
                this.CallHistory.RemoveAll(x => x.Duration >= 0);
        }

        // Method for proper printing on the console
        public override string ToString()
        {
            // We use StringBuilder because it is faster than concatenating strings
            System.Text.StringBuilder result = new System.Text.StringBuilder();

            // If a field has a value of null , it wouldn't be added to the result
            if (this.Model != null)
            {
                result.Append("Model: ".PadRight(15, ' '));
                result.Append(this.Model);
                result.AppendLine();
            }
            if (this.Manufacturer != null)
            {
                result.Append("Manufacturer: ".PadRight(15, ' '));
                result.Append(this.Manufacturer);
                result.AppendLine();
            }
            if (this.Price != null)
            {
                result.Append("Price: ".PadRight(15, ' '));
                result.Append(this.Price);
                result.AppendLine();
            }
            if (this.Owner != null)
            {
                result.Append("Owner: ".PadRight(15, ' '));
                result.Append(this.Owner);
                result.AppendLine();
            }
            if (this.Battery != null)
            {
                result.Append("Battery: ".PadRight(15, ' '));
                result.Append(this.Battery.ToString());
                result.AppendLine();
            }
            if (this.Display != null)
            {
                result.Append("Display: ".PadRight(15, ' '));
                result.Append(this.Display.ToString());
                result.AppendLine();
            }

            string stringResult = result.ToString();
            return stringResult;
        }
    }
}
