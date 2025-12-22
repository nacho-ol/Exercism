using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool nextIsUpper = false;

        foreach (char c in identifier)
        {
            // 1. Espacios -> Guion bajo
            if (c == ' ')
            {
                sb.Append('_');
            }
            // 2. Caracteres de Control -> "CTRL"
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");
            }
            // 3. Kebab-case a camelCase (Guion detectado)
            else if (c == '-')
            {
                nextIsUpper = true;
            }
            // 4. Omitir letras griegas minúsculas (α a ω)
            else if (c >= 'α' && c <= 'ω')
            {
                continue; 
            }
            // 5. Solo letras (y procesar mayúscula si viene de un guion)
            else if (char.IsLetter(c))
            {
                if (nextIsUpper)
                {
                    sb.Append(char.ToUpper(c));
                    nextIsUpper = false;
                }
                else
                {
                    sb.Append(c);
                }
            }
            // 6. Cualquier otra cosa (números, emojis) se ignora
        }

        return sb.ToString();
    }
}