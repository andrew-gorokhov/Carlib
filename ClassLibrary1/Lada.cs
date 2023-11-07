using System.ComponentModel.Design;

namespace Library_Cars
{
    public class vesta
    {
        public string mark = "Lada";
        public string model = "Vesta";
        public bool motorActivate = false;
        public int speed = 0;
        public int odometr = 0;
        public int gear = 0;
        public bool automaticTransmission = true;
        private int maxSpeed = 195;
        private int minSpeed = 0;
        public int maxGear = 6;
        private int minGear = -1;
        public int acceleration = 5;
        public void start()
        {
            speed += acceleration;
            
        }
        public void stop()
        {
            if (speed > 0)
            {
                speed -= 15;
            } else if (speed <= 0) 
            { 
                speed = 0;
            }
            
        }
        public void currentGear()
        {
            switch (gear)
            {
                case (-1):
                    acceleration = 5;
                    break;
                case 0:
                    acceleration = 0;
                    break;
                case 1:
                    acceleration = 5;
                    break;
                case 2:
                    acceleration = 30;
                    break;
                case 3:
                    acceleration = 20;
                    break;
                case 4:
                    acceleration = 15;
                    break;
                case 5:
                    acceleration = 10;
                    break;
            }
        }

        public void automaticGear()
        {
            if (speed >= 0 & speed < 30)
            {
                gear = 1;
            }
            else if (speed >= 30 & speed < 50)
            {
                gear = 2;
            }
            else if (speed >= 50 & speed < 70)
            {
                gear = 3;
            }
            else if (speed >= 70 & speed < 90)
            {
                gear = 4;
            }
            else if (speed >= 90 & speed < 120)
            {
                gear = 5;
            }
            else if (speed >= 120 & speed < maxSpeed)
            {
                gear = 6;
            }
            else if (speed > maxSpeed)
            {
                speed = maxSpeed;
            }
        }
       
    }
}