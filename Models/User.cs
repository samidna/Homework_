using System.Globalization;

namespace Homework.Models;

public class User
{
    public string Username;
    public string Password;

    public User(string username, string password)
    {
        string tempPassword = password.ToLower();
        if (!tempPassword.Equals(password) && IsDigit(password) && password.Length>=8 && username.Length>=8)
        {
            Username=username;
            Password=password;
            Console.WriteLine("Hesab ugurla yaradildi.");
        }
        else
        {
            Console.WriteLine("Qaydalara uygun sifre yazin");
        }
    }

    public bool IsDigit(char ch)
    {
        return ch >= '0' && ch <='9';
    }

    public bool IsDigit(string password)
    {
        for (int i = 0; i<password.Length; i++)
        {
            if (IsDigit(password[i])) return true;
        }
        return false;
    }


}
