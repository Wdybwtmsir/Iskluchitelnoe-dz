using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введите строку для проверки:");
            string input = Console.ReadLine();
            bool isPalindrome = CheckPalindrome(input);
            Console.WriteLine(isPalindrome ? "Строка является палиндромом." : "Строка не является палиндромом.");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Завершение выполнения программы.");
        }
    }

    static bool CheckPalindrome(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("Строка не может быть пустой или null.");
        }

        int length = str.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (str[i] != str[length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
}