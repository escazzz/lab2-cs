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
        Console.WriteLine("Документ сохранен в старом формате, сохранение в дргуих форматах доступно в версии Expert.");
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
        if (key == "Pro")
        {
            user = new ProDocumentWorker();
        }
        else if (key == "Expert")
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
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System;
using Npgsql;

namespace Lab10
{
    public class DatabaseConfig
    {
        private const string Dsn = "Host=localhost;Port=5432;Database=MyData;Username=postgres;Password=postgres";

        public static string GetDsn() //возвращает строку подключения к бд
        {
            return Dsn;
        }
    }
    public class HTTPRequest  //выполняем GET-запросы
    {
        public static async Task<string> Request(string url)
        {
            using (HttpClient httpClient = new HttpClient()) //для отправки запросов
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url); //выполнение GET-запроса

                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        throw new HttpRequestException($"HTTP Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
                catch (HttpRequestException e)
                {
                    throw new HttpRequestException($"Request error: {e.Message}");
                }
            }
        }
    }

    public class Parser
    {
        public static async Task<string[]> Parse(string CSVString) //асинхронный парсинг CSV-строки
        {
            using (StringReader stringReader = new StringReader(CSVString))
            {

                using (TextFieldParser textFieldParser = new TextFieldParser(stringReader)) //для парсинга текстовых полей
                {
                    textFieldParser.TextFieldType = FieldType.Delimited; //тип - разделённые
                    textFieldParser.SetDelimiters(","); //запятая в качестве распределителя

                    textFieldParser.ReadFields();

                    string[] rows = textFieldParser.ReadFields(); //читает содержимое

                    return rows;
                }
            }
        }
    }

    public class TickerPrice
    {
        public static async Task<double> GetTodayPrice(string ticker) //цена за сегодня
        {
            DateTime today = DateTime.Today;
            DateTime yesterday = today.AddDays(-1);

            long todayUnixTimestamp = ((DateTimeOffset)today).ToUnixTimeSeconds();
            long yesterdayUnixTimestamp = ((DateTimeOffset)yesterday).ToUnixTimeSeconds();

            string url = $"https://query1.finance.yahoo.com/v7/finance/download/" +
                            $"{ticker}?period1={yesterdayUnixTimestamp}&period2={todayUnixTimestamp}" +
                            "&interval=1d&events=history&includeAdjustedClose=true";

            string response = await HTTPRequest.Request(url); //GET-запрос

            var parsedResponse = await Parser.Parse(response);
            // Console.WriteLine(parsedResponse[1]);
            return Convert.ToDouble(parsedResponse[1].Replace('.', ','));
        }

        public static async Task<double> GetYesterdayPrice(string ticker) //получение цены за прошлые дни
        {
            DateTime yesterday = DateTime.Today.AddDays(-1);
            DateTime twoDaysAgo = yesterday.AddDays(-1);

            long yesterdayUnixTimestamp = ((DateTimeOffset)yesterday).ToUnixTimeSeconds();
            long twoDaysAgoUnixTimestamp = ((DateTimeOffset)twoDaysAgo).ToUnixTimeSeconds();

            string url = $"https://query1.finance.yahoo.com/v7/finance/download/" +
                         $"{ticker}?period1={twoDaysAgoUnixTimestamp}&period2={yesterdayUnixTimestamp}" +
                         "&interval=1d&events=history&includeAdjustedClose=true";

            string response = await HTTPRequest.Request(url);

            var parsedResponse = await Parser.Parse(response);

            return Convert.ToDouble(parsedResponse[1].Replace('.', ','));
        }
    }



    internal class Program
    {
        private static readonly string path = "C:\\Users\\user\\Desktop\\ticker.txt";
        private static readonly object lockObject = new object(); //лбъект для многопоточного доступа
        public static async Task Main(string[] args)
        {
            DateTime today = DateTime.Today;

            NpgsqlConnection connection = new NpgsqlConnection(DatabaseConfig.GetDsn()); //подключаемся к бд PostgreSQL
            await connection.OpenAsync();

            string createTickersTable = "CREATE TABLE IF NOT EXISTS Tickers " +
                                        "(id SERIAL PRIMARY KEY, " +
                                        "ticker VARCHAR(255));";

            string createPricesTable = "CREATE TABLE IF NOT EXISTS Prices " +
                                       "(id SERIAL PRIMARY KEY, " +
                                       "tickerid INT, " +
                                       "price DOUBLE PRECISION, " +
                                       "date VARCHAR(255));";

            string createTodaysConditionTable = "CREATE TABLE IF NOT EXISTS TodaysCondition " +
                                                "(id SERIAL PRIMARY KEY, " +
                                                "tickerid INT, " +
                                                "state VARCHAR(255));";

            NpgsqlCommand commandCreateTables = new NpgsqlCommand(createTickersTable
                                                                  + createPricesTable
                                                                  + createTodaysConditionTable, connection);
            commandCreateTables.ExecuteNonQuery(); //создание таблиц

            try
            {
                using (StreamReader reader = new StreamReader(path)) //открываем файл для чтения
                {
                    string ticker;
                    while ((ticker = reader.ReadLine()) != null)
                    {
                        double price;
                        try
                        {
                            price = await TickerPrice.GetTodayPrice(ticker); //запрос цены
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error fetching price for {ticker}: {ex.Message}");
                            continue;
                        }

                        NpgsqlConnection updateConnection = new NpgsqlConnection(DatabaseConfig.GetDsn());
                        await updateConnection.OpenAsync(); //обновление бд

                        NpgsqlCommand insertCommand = updateConnection.CreateCommand();
                        insertCommand.CommandText = "INSERT INTO Tickers (ticker) VALUES (@ticker) RETURNING id";
                        insertCommand.Parameters.AddWithValue("@ticker", ticker);
                        int tickerId = (int)insertCommand.ExecuteScalar();


                        insertCommand.CommandText = $"INSERT INTO Prices (tickerid, price, date) VALUES (@tickerId, @price, @today)";//@ используется для избежание sql инъекций
                        insertCommand.Parameters.AddWithValue("@tickerId", tickerId);
                        insertCommand.Parameters.AddWithValue("@price", price);
                        insertCommand.Parameters.AddWithValue("@today", today.ToString("yyyy-MM-dd"));
                        insertCommand.ExecuteNonQuery();

                        updateConnection.Close();
                        await AnalyzeAndUpdateCondition(connection, ticker, price, today); //анализ цены
                       
                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }

            connection.Close(); //закрытие соединенеия

            NpgsqlConnection newConnection = new NpgsqlConnection(DatabaseConfig.GetDsn()); //создание нового соединения

            try
            {

                while (true)
                {
                    Console.Write("Enter ticker to retrieve its condition (or 'exit' to exit): "); //работаем до exit
                    string userInput = Console.ReadLine();

                    if (userInput.ToLower() == "exit")
                        break;

                    string ticker = userInput.ToUpper();

                    await newConnection.OpenAsync();

                    lock (lockObject)
                    {
                        try
                        {
                            int tickerId = GetTickerId(newConnection, ticker);

                            if (tickerId == 0)
                            {
                                Console.WriteLine($"Ticker '{ticker}' not found in the database.");
                                continue;
                            }

                            string selectConditionQuery = "SELECT state FROM TodaysCondition WHERE tickerid = @tickerId"; //SQL-запрос для condition
                            NpgsqlCommand selectConditionCommand = new NpgsqlCommand(selectConditionQuery, newConnection);//команда
                            selectConditionCommand.Parameters.AddWithValue("@tickerId", tickerId);

                            var condition = selectConditionCommand.ExecuteScalar(); //выполняет SQL запрос к базе данных и возвращает результат выполнения запроса в переменную condition.

                            Console.WriteLine($"Condition for {ticker}: {condition}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error retrieving condition for {ticker}: {ex.Message}");
                        }
                    }
                    newConnection.Close();
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            connection.Close();
        }

        private static async Task AnalyzeAndUpdateCondition(NpgsqlConnection connection, string ticker, double todayPrice, DateTime today)
        {
            try
            {
                int tickerId = GetTickerId(connection, ticker);

                double yesterdayPrice = await TickerPrice.GetYesterdayPrice(ticker);

                double condition = todayPrice - yesterdayPrice;

                NpgsqlCommand insertConditionCommand = connection.CreateCommand();
                insertConditionCommand.CommandText =
                    "INSERT INTO TodaysCondition (tickerid, state) VALUES (@tickerId, @state)";
                insertConditionCommand.Parameters.AddWithValue("@tickerId", tickerId);
                insertConditionCommand.Parameters.AddWithValue("@state", condition);
                await insertConditionCommand.ExecuteNonQueryAsync();
            }
            catch (Exception err)
            {
                Console.WriteLine("error");
            }
        }

        private static int GetTickerId(NpgsqlConnection connection, string ticker)
        {
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = $"SELECT id FROM Tickers WHERE ticker = '{ticker}'";
            command.Parameters.AddWithValue("@ticker", ticker);
            return (int)command.ExecuteScalar(); //запрос по идентификатору
        }

    }
}

