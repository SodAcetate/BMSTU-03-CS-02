using System;   

namespace Lab_02_2
{
    class Program {
        
        class Vehicle{
            double _x;
            double _y;
            float _price;
            short _speed;
            short _year;
            
            public Vehicle(double x, 
                        double y,
                        float price,
                        short speed,
                        short year) { _x = x ;
                                        _y = y ;
                                        _price = price ;
                                        _speed = speed ;
                                        _year = year ;
                        }
            public virtual void print(){
                Console.WriteLine($"Координаты: x {_x} ; y {_y}");
                Console.WriteLine($"Стоимость: {_price} штук денег");
                Console.WriteLine($"Скорость: {_speed} км/ч");
                Console.WriteLine($"Год выпуска: {_year}");
            }
        }
        
        class Plane : Vehicle {
            short _height;
            short _passengerCount;
            public Plane( double x, double y, float price, short speed, 
                        short year, short height, short passengerCount) : base (x, y, price, speed, year) {
                            _height = height; _passengerCount = passengerCount;
                        }    
            public override void print(){
                base.print();
                Console.WriteLine($"Высота полёта: {_height} м");
                Console.WriteLine($"Кол-во мест: {_passengerCount}");
            }
        }
        class Car : Vehicle { 
            public Car( double x, double y, float price, short speed, 
                        short year) : base (x, y, price, speed, year) { }    
            public override void print(){
                base.print();
            }
        }
        class Ship : Vehicle {
            string _port;
            short _passengerCount;
            public Ship( double x, double y, float price, short speed, 
                        short year, string port, short passengerCount) : base (x, y, price, speed, year) {
                            _port = port; _passengerCount = passengerCount;
                        }
            public override void print(){
                base.print();
                Console.WriteLine($"Порт приписки: {_port}");
                Console.WriteLine($"Кол-во мест: {_passengerCount}");
            }
        }
        
        static void Main() {
            
            Car testCar = new Car(0,0,1000,150,2007);
            testCar.print();
            Console.WriteLine();
            Plane testPlane = new Plane(1005.51,5351.32,20000,900,2002,5000,200);
            testPlane.print();
            Console.WriteLine();
            Ship testShip = new Ship(8623.12,-2354.05,50000,50,1998,"Международный Порт Монголии",3000);
            testShip.print();
            
            
        }
    }

}