/*using System;
class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
    {
        pupils = new Pupil[] { pupil1, pupil2, pupil3, pupil4 };
    }

    public void ShowClassInfo()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"Ученик {i + 1}:");
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
            Console.WriteLine();
        }
    }
}
class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Ученик учится.");
    }

    public virtual void Read()
    {
        Console.WriteLine("Ученик читает.");
    }

    public virtual void Write()
    {
        Console.WriteLine("Ученик пишет.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Ученик отдыхает.");
    }
}

class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Отличник учится усердно.");
    }

    public override void Read()
    {
        Console.WriteLine("Отличник много читает.");
    }

    public override void Write()
    {
        Console.WriteLine("Отличник хорошо пишет.");
    }

    public override void Relax()
    {
        Console.WriteLine("Отличник отдыхает недолго.");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Хороший ученик учится регулярно.");
    }

    public override void Read()
    {
        Console.WriteLine("Хороший ученик регулярно читает.");
    }

    public override void Write()
    {
        Console.WriteLine("Хороший ученик пишет аккуратно.");
    }

    public override void Relax()
    {
        Console.WriteLine("Хороший ученик комфортно отдыхает.");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Плохой ученик тяжело учится.");
    }

    public override void Read()
    {
        Console.WriteLine("Плохой ученик тяжело читает.");
    }

    public override void Write()
    {
        Console.WriteLine("Плохой ученик тяжело пишет.");
    }

    public override void Relax()
    {
        Console.WriteLine("Плохой ученик много отдыхает.");
    }
}
class Lab2_1
{
    static void Main()
    {


        Pupil pupil1 = new ExcellentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new GoodPupil();

        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classRoom.ShowClassInfo();
    }
    }*/
/*class Vehicle
{
    private double coordinates;
    private double price;
    private double speed;
    private int year;

    public Vehicle(double coordinates, double price, double speed, int year)
    {
        this.coordinates = coordinates;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Координаты: {coordinates}");
        Console.WriteLine($"Цена: {price:C2}");
        Console.WriteLine($"Скорость: {speed} км/ч");
        Console.WriteLine($"Год выпуска: {year}");
    }
}

class Plane : Vehicle
{
    private double altitude;
    private int passengers;

    public Plane(double coordinates, double price, double speed, int year, double altitude, int passengers)
        : base(coordinates, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Высота: {altitude} м");
        Console.WriteLine($"Количество пассажиров: {passengers}");
    }
}

class Car : Vehicle
{
    public Car(double coordinates, double price, double speed, int year)
        : base(coordinates, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double coordinates, double price, double speed, int year, int passengers, string port)
        : base(coordinates, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public new void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Количество пассажиров: {passengers}");
        Console.WriteLine($"Порт приписки: {port}");
    }
}

class Lab2_2
{
    static void Main()
    {
        Vehicle vehicle1 = new Plane(0, 1000000, 900, 2020, 10000, 200);
        Vehicle vehicle2 = new Car(0, 30000, 150, 2022);
        Vehicle vehicle3 = new Ship(0, 2000000, 30, 2018, 500, "New York");

        Console.WriteLine("Информация о самолете:");
        vehicle1.ShowInfo();

        Console.WriteLine("\nИнформация о машине:");
        vehicle2.ShowInfo();

        Console.WriteLine("\nИнформация о корабле:");
        vehicle3.ShowInfo();
    }
}*/
using System;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт.");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактикрование документа доступно в версии Pro.");

    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro.");

    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован.");
    }
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в дргуих форматах доступно в версии Ex[ert.]");
    }

}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате.");
    }

}
class Lab2_3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номера ключа доступа для Pro/Expert: ");
        string key = Console.ReadLine();
        DocumentWorker user;
        if (key == "pro_key")
        {
            user = new ProDocumentWorker();
        }
        else if (key == "expert_key")
        {
            user = new ExpertDocumentWorker();
        }
        else
        {
            user = new DocumentWorker();
        }

        user.OpenDocument();
        user.EditDocument();
        user.SaveDocument();
    }


}
