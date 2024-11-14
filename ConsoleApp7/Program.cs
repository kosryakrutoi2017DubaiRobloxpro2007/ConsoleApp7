using System;

public class UserInfo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите ФИО:");
        string fullName = Console.ReadLine();

        Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ:");
        DateTime birthDate;
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out birthDate))
        {
            Console.WriteLine("Неверный формат даты. Введите дату рождения в формате ДД.ММ.ГГГГ:");
        }


        Console.WriteLine("Введите номер телефона:");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Введите почту:");
        string email = Console.ReadLine();

        int age = CalculateAge(birthDate);

        Console.WriteLine($"\nПривет, {fullName}!");
        Console.WriteLine($"Ваши данные:");
        Console.WriteLine($"ФИО: {fullName}");
        Console.WriteLine($"Дата рождения: {birthDate.ToString("dd.MM.yyyy")}");
        Console.WriteLine($"Номер телефона: {phoneNumber}");
        Console.WriteLine($"Почта: {email}");
        Console.WriteLine($"Возраст: {age}");

        Console.ReadKey(); 
    }


    static int CalculateAge(DateTime birthDate)
    {
        DateTime today = DateTime.Today;
        int age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--; 
        return age;
    }
}
