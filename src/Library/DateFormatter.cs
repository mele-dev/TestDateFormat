namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// Esta clase implementa la funcionalidad de cambiar el formato de una fecha.
/// </summary>
public class DateFormatter
{

    /// <summary>
    /// Cambia el formato de la fecha que se recibe como argumento. La fecha que se recibe como argumento se asume en
    /// formato "dd/mm/yyyy" y se retorna en formato "yyyy-mm-dd". No se controla que la fecha recibida tenga el formato
    /// asumido.
    /// </summary>
    /// <param name="date">Una fecha en formato "dd/mm/yyyy".</param>
    /// <returns>La fecha convertida al formato "yyyy-mm-dd".</returns>
    public static string ChangeFormat(string date)
    {
        if (ValidateFormat(date))
            return date.Substring(6) + "-" + date.Substring(3, 2) + "-" + date.Substring(0, 2);
        return "wrongDate";
    }

    public static bool ValidateFormat(string date)
    {
        if (!date.Equals(""))
        {
            // convertimos la fecha en una lista
            List<char> charsList = date.ToCharArray().ToList();

            /* validamos que tenga el caracter "/" en las posiciones que deberian estar
             * (usamos '' en vez de "" porque es char) */
            if (charsList[2] == '/' && charsList[5] == '/')
            {
                /* en caso de que los tenga, le quitamos el caracter "/" en ambas posiciones
                 * y validamos que el resultado sea un digito. Es decir, que si se recibe la
                 * fecha "10/11/1997" por ejemplo, esta quedaria asi: 10111997. Validamos que
                 * sea un numero y si lo es, el formato de la fecha es correcto */

                charsList.RemoveAt(5);
                charsList.RemoveAt(2);

                if (charsList.All(char.IsDigit))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
