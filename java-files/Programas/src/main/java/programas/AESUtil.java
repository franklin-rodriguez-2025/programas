//
// AESUtil.java
//
package programas;

import javax.crypto.Cipher;
import javax.crypto.spec.IvParameterSpec;
import javax.crypto.spec.SecretKeySpec;
import java.nio.charset.StandardCharsets;
import java.util.Base64;
import static programas.GestionDeDatos.*;

public class AESUtil
{
    public static final String cifradoAESCBCPKCS5Padding = "AES/CBC/PKCS5Padding";

    /**
     * Asegura que la clave sea de 32 bytes = 256 bits
     * rellenando o truncando según sea necesario.
     */
    public static SecretKeySpec generarSecretKey(String secretKey)
    {
        //
        // 8bit1byte1caracter
        // 1 byte = 8 bits
        // 1 byte por caracter
        // 8 bit por caracter
        //
        // 16 caracteres = 16 bytes = 128 bits
        // 16 caracteres = 128 bits = 16 bytes
        //
        // 32 caracteres = 32 bytes = 256 bits
        // 32 caracteres = 256 bits = 32 bytes
        //
        byte[] keyBytes = new byte[32]; // 32 bytes = 256 bits
        byte[] secretBytes = stringToBytes(secretKey);

        int len = Math.min(secretBytes.length, keyBytes.length);
        System.arraycopy(secretBytes, 0, keyBytes, 0, len);
        return new SecretKeySpec(keyBytes, "AES");
    }

    public static String cifrar(String texto, String secretKey) throws Exception
    {
        String randomInitialVector = getInitVector();
        IvParameterSpec iv = new IvParameterSpec( stringToBytes(randomInitialVector) );
        SecretKeySpec skeySpec = generarSecretKey(secretKey);

        Cipher cipher = Cipher.getInstance(cifradoAESCBCPKCS5Padding);
        cipher.init(Cipher.ENCRYPT_MODE, skeySpec, iv);

        byte[] encrypted = cipher.doFinal( stringToBytes(texto) );
        return Base64.getEncoder().encodeToString(encrypted);
    }

    public static String descifrar(String textoCifradoBase64, String secretKey) throws Exception
    {
        String initVector = getInitVector();
        IvParameterSpec iv = new IvParameterSpec(getBytesFrom(initVector));
        SecretKeySpec skeySpec = generarSecretKey(secretKey);

        Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
        cipher.init(Cipher.DECRYPT_MODE, skeySpec, iv);

        byte[] decodedBytes = Base64.getDecoder().decode(textoCifradoBase64);
        byte[] original = cipher.doFinal(decodedBytes);

        return new String(original, StandardCharsets.UTF_8);
    }

    public static void main(String[] args) throws Exception
    {
        String original = "Hola, mundo !";
        String contrasena = "contrasena123";

        String cifrado = AESUtil.cifrar(original, contrasena);
        System.out.println("Cifrado: " + cifrado);

        String descifrado = AESUtil.descifrar(cifrado, contrasena);
        System.out.println("Descifrado: " + descifrado);
    }
}
