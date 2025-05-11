//
// GestionDeDatos.java
//
package programas;

import java.nio.charset.StandardCharsets;
import java.util.ArrayList;
import java.util.Base64;
import java.util.List;

public class GestionDeDatos
{
    public static int getRandomNumber(Integer min, Integer max)
    {
        if( max == null )
        {
            max = 101;
        }
        else
        {
            max = max + 1;
        }
        if( min == null )
        {
            min = 0;
        }
        // Si no se indica el rango,
        // se genera un numero random entre 0 a 100.
        return (int) (Math.random() * (max - min + 1)) + min;
    }

    public static char getCharacter(int number)
    {
        return (char) number;
    }

    public static String genPassword(Integer size)
    {
        if( size == null )
        {
            size = 18;
        }
        StringBuilder unStringRandom = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            int randomNumber = getRandomNumber(null,null);
            char randomChar = getCharacter(randomNumber);
            unStringRandom.append(randomChar);
        }
        return unStringRandom.toString();
    }

    public static String getRandomChar()
    {
        List<Character> letras = new ArrayList<>();
        for(int i = 65; i < 91; i++)
            letras.add( (char) i);
        for(int i = 97; i < 123; i++)
            letras.add((char) i);
        // add especial chars
        letras.add('!');
        letras.add('@');
        letras.add('#');
        letras.add('$');
        letras.add('%');
        letras.add('^');
        letras.add('&');
        letras.add('*');
        letras.add('(');
        letras.add(')');
        letras.add('[');
        letras.add(']');
        letras.add('{');
        letras.add('}');
        letras.add('\\');
        letras.add('-');
        letras.add('>');
        letras.add('<');
        letras.add('=');
        letras.add('?');
        letras.add(':');
        letras.add(';');
        letras.add('.');
        letras.add(',');
        letras.add('`');
        for( Character item : letras )
        {
            System.out.print( item );
        }
        return "$";
    }

    public static String getInitVector()
    {
        String randomInitVector = "RandomInitVector";
        if( randomInitVector.length() >= 16 )
        {
            return randomInitVector;
        }
        else
        {
            throw new RuntimeException("unString de 16 como minimo !");
        }
    }

    public static byte[] getBytesFrom(String unString)
    {
        return stringToBytes(unString);
    }

    public static byte[] stringToBytes(String unString)
    {
        return unString.getBytes(StandardCharsets.UTF_8);
    }

    public static String codificar(String texto)
    {
        return Base64.getEncoder().encodeToString(texto.getBytes(StandardCharsets.UTF_8));
    }

    public static String decodificar(String textoBase64)
    {
        return new String(Base64.getDecoder().decode(textoBase64), StandardCharsets.UTF_8);
    }

    public static void main(String[] args)
    {
        getRandomChar();
    }
}