namespace RobotterneKommer

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string type;
            string color;
            string wifiInterface;
            bool wifi = false;
            byte batteryCapacity = 0;
            bool battery = false;
            bool soapDispencer = false;
            byte wheels = 0;

            //User interface for the type of robot they want
            Console.WriteLine("Hvad skal robotten kunne?\r\nfeje, pudse vinduer, skifte dæk");
            type = Console.ReadLine();
            if (type == "feje")
            {
                soapDispencer = true;
            }
            else if (type == "pudse vinduer")
            {
                soapDispencer = true;
            }
            else if (type == "skifte dæk")
            {
                battery = true;
                Console.WriteLine("Hvor mange dæk skal din robot have?");
                wheels = byte.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("indtast en gyldig funktion");
            }
            
            //user interface for the color they want
            Console.WriteLine("Vælg din robots farve\r\nHvid, sort");
            color = Console.ReadLine();
            if (color == "hvid")
            {
                battery = true;
                Console.WriteLine("hvor meget kapacitet skal der være på dit batteri?\r\n1 - 255");
                batteryCapacity = byte.Parse(Console.ReadLine());                
            }
            else
            {
                battery = false;
            }

            //user interface if they want wifi
            Console.WriteLine("Skal din robot have wifi?");
            wifiInterface = Console.ReadLine();
            if (wifiInterface == "ja")
            {
                wifi = true;
            }
            else
            {
                wifi = false;
            }

            //Here we create the robot
            Robot robot = new Robot(type, color, wifi, battery, soapDispencer, wheels);
            //we write the robot in console
            Console.WriteLine($"Det her er din robot\r\nChip: {robot.Chip}  Type: {robot.Type}  Farve: {robot.Color}  Wifi: {robot.Wifi}  Batteri: {robot.Battery}  Sæbe: {robot.SoapDispencer}  Hjul: {robot.Wheels}");
        }
        internal class Robot
        {
            //The instance variables
            private string type;
            private string color;
            private string chip;
            private bool wifi;
            private bool battery;
            private bool soapDispencer;
            private int wheels;

            //Incapsulation of our instance variables
            public string Type
            {
                get { return type; }
            }
            public string Color
            {
                get { return color; }
            }
            public string Chip
            {
                get { return chip; }
            }
            public bool Wifi
            {
                get { return wifi; }
            }
            public bool Battery
            {
                get { return battery; }
            }
            public bool SoapDispencer
            {
                get { return soapDispencer; }
            }
            public int Wheels
            {
                get { return wheels; }
            }

            //The construction
            public Robot(string type, string color, bool wifi, bool battery, bool soapDispencer, int wheels)
            {
                Random random = new Random();
                int number = random.Next(1, 3);
                if (number == 1)
                {
                    this.chip = "RX54667";
                    this.type = type;
                }
                else
                {
                    this.chip = "QT8339";
                    this.type = type;
                }
                this.color = color;
                this.wifi = wifi;
                this.battery = battery;
                this.soapDispencer = soapDispencer;
                this.wheels = wheels;
            }
            
        }

    }
}