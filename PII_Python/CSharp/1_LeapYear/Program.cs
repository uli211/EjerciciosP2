Console.Write("2000 es bisiesto? :", Function.IsLeap(2000));

// Implementa en esta clase la función que corresponda

public static class Function
{
    public static bool IsLeap(int year)
    {
        year = 2000;
        bool isLeapyear = year % 4 == 0 && (!(year % 100 == 0) || year % 400 == 0);

        return isLeapyear;
    }
}


/* def is_leap(year):
    return year % 4 == 0 and (not (year % 100 == 0) or year % 400 == 0)


print("2000 es bisiesto? True :", is_leap(2000))*/

