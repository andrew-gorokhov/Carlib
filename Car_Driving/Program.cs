using Library_Cars;
using System.Buffers.Binary;
using System.Reflection.Metadata.Ecma335;

namespace Car_Driving



{
    internal class Program
    {
        static void Main(string[] args)
        {
            vesta tom = new vesta();
            
            bool script = true;
            while (script) 
            {
                Console.WriteLine("Симуляция вождения автомобиля " + tom.mark + " " + tom.model);
                Console.WriteLine("Управление автомобилем происходит при помощи ввода номера команд через консоль");
                Console.WriteLine("Доступные команды");
                Console.WriteLine("1) Завести машину.");
                Console.WriteLine("2) Снять машину с паркинга.");
                Console.WriteLine("3) Нажать на педаль газа.");
                Console.WriteLine("4) Нажать на педаль тормоза.");
                Console.WriteLine("5) Повысить передачу.");
                Console.WriteLine("6) Понизить передачу.");
                Console.WriteLine("7) Активировать автопилот.");
                Console.WriteLine("8) Снять машину с автопилота");
                Console.WriteLine("9) Заглушить двигатель");
                Console.WriteLine("10) Посмотреть на лево");
                Console.WriteLine("11) Посмотреть на право");
                Console.WriteLine("12) Посмотреть вперед");
                Console.WriteLine("13) Посмотреть назад");
                Console.WriteLine("14) Поставить машину на паркинг");
                int value = Convert.ToInt32(Console.ReadLine());
                
                switch (value)
                {
                    case 1:
                        if (tom.motorActivate != true)
                        {
                            Console.WriteLine("Двигатель завелся.");
                            tom.motorActivate = true;
                            Console.WriteLine("быр быр быр, дзынь дзынь");
                        } else
                        {
                            Console.WriteLine("Кщщщщщщщщщщщщщщщщщщщщщ");
                            tom.motorActivate = false;
                            Console.WriteLine("Critycal error. Error code 64321fs654sd31fsfasfsdfsadfsdfsd.  Please contact to the cervice center.");
                        }
                        break;
                    case 2: 
                        if (tom.motorActivate == true)
                        {
                            Console.WriteLine("Можно начинать движение.");
                            tom.gear = 1;
                            Console.WriteLine("Включена передача номер " + tom.gear);

                        } else {
                            Console.WriteLine("Critycal error. Engine is not activated! Please contact to the cervice center.");
                                }
                        break;
                    case 3:
                        if (tom.motorActivate == true & tom.gear != 0) 
                        {
                            if (tom.speed == 0)
                            {
                                Console.WriteLine("Машина начинает движение");
                                tom.start();
                                tom.start();
                                tom.start();
                                Console.WriteLine("Скорость: "+ tom.speed);

                                
                                bool driving = true;
                                while (driving)
                                {
                                    Console.WriteLine("Продолжить набор скорости?");
                                    Console.WriteLine("1) Да.");
                                    Console.WriteLine("2) Нет.");
                                    int speedvalue = Convert.ToInt32(Console.ReadLine());
                                    switch (speedvalue)
                                    {
                                        case 1:
                                            tom.start();
                                            tom.currentGear();
                                            tom.automaticGear();                                  
                                            Console.WriteLine("Скорость: " + tom.speed);
                                            Console.WriteLine("Передача: " + tom.gear);
                                            break;
                                        case 2:
                                            driving = false;
                                            break;


                                    }
                                }
                                break;

                            } 
                            break;
                        } else
                        {
                            Console.WriteLine("Нужно завести машину и снять её с паркинга!");
                        }
                        break;
                    case 4:
                        {
                            if (tom.motorActivate == true & tom.speed != 0)
                            {
                                tom.stop();
                                if (tom.speed < 0)
                                {
                                    tom.speed = 0;
                                }
                                tom.currentGear();
                                tom.automaticGear();
                                Console.WriteLine("Скорость: " + tom.speed);
                                Console.WriteLine("Передача: " + tom.gear);
                            } else
                            {
                                Console.WriteLine("Машина не движется");
                            }
                           
                            break;  

                        }
                    case 5:
                        {
                          Console.WriteLine("Для доступа к данной функции Вам необходимо приобрести ежемесячную подписку на laga-ne-avto.com");
                            
                            break;
                        }
                        case 6 :
                        {
                            Console.WriteLine("Для доступа к данной функции Вам необходимо приобрести ежемесячную подписку на laga-ne-avto.com");

                            break;
                        }
                        case 7 : 
                        {
                            if (tom.motorActivate == true)
                            {
                                Console.WriteLine("Поиск ближайшего столба.");
                                Console.WriteLine("Определение оптимального маршрута.");
                                Console.WriteLine("Маршрут найден.");
                                Console.WriteLine("Активация автопилота.");
                                tom.speed = 250;
                                tom.currentGear();
                                Console.WriteLine("Скорость: " + tom.speed);
                                Console.WriteLine("Передача: " + tom.gear);
                                Console.WriteLine("Потрачено...");
                                break;
                            } else
                            {
                                Console.WriteLine("Нужно завести мшину!");
                            }
                            break;
                        }
                        case 8 : 
                        {
                            Console.WriteLine("Сначало его нужно активировать.");
                            break;
                        }
                        case 9 : 
                        {
                            tom.motorActivate = false;
                            Console.WriteLine("Двигатель выключен.");
                            break;
                        }
                        case 10 :
                        {
                            Console.WriteLine("Там едет Урал.");
                            break;
                        }
                        case 11 : 
                        {
                            Console.WriteLine("Там едет КамАЗ.");
                            break;
                        }
                        case 12 : 
                        {
                            Console.WriteLine("Впереди выезд со двора.");
                            break;
                        }
                        case 13 : 
                        {
                            Console.WriteLine("Обычный подмосковный двор.");
                            break;

                        }   
                        case 14 : 
                        {
                            Console.WriteLine("Паркинг установлен.");
                            tom.gear = 0;
                            tom.currentGear();
                            break;
                        }
                }




            }
            


        }
    }
}