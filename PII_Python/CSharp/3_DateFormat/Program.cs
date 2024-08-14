//string testDate = "10/11/1977";
//Console.WriteLine(string.Format("{0} se convierte a: {1}", testDate, Functions.DateFormat(testDate)));


public static class Functions
{
    public static string DateFormat(string dia, string mes, string año)
    {
        if (dia.Length != 2 || mes.Length != 2 || año.Length != 4)
            throw new ArgumentException("Los valores deben estar en los formatos 'dd', 'mm', y 'aaaa'.");

        return año + "-" + mes + "-" + dia;
    }
}

// Ejemplo de uso
    class Program
    {
        static void Main()
        {
            string dia = "20";
            string mes = "12";
            string año = "2009";
        
            string fechaConvertida = Functions.DateFormat(dia, mes, año);
            Console.WriteLine(fechaConvertida); 
        }
    }


