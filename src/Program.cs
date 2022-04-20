using System;
using System.Linq;

namespace DateFormat
{
    public class Program
    {
        public static String ChangeFormat(String year)
        {
            return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
        }

        public static String CambiarFormato(string fecha)
        {
            if (!String.IsNullOrEmpty(fecha))
            {
                var partes = fecha.Split("/").Where(x => !String.IsNullOrEmpty(x)).ToArray();
                if (partes.Length == 3)
                {
                    return $"D: {partes[0]} | M: {partes[1]} | A: {partes[2]}";
                }
            }
            return "";
        }

        public static void Main(string[] args)
        {
            string testDate = "10/11/1977";
            Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
        }
    }
}
