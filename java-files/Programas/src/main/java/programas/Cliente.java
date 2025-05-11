//
// Cliente.java
//
package programas;

import java.io.*;
import java.net.*;
import java.math.BigDecimal;

public class Cliente implements Serializable
{
	@Serial
	private static final long serialVersionUID = 9L;

	public void conectar(String host, int puerto)
	{
		try {
			Socket socket = new Socket(host, puerto);
			System.out.println("Conectado al servidor.");

			ObjectOutputStream oos = new ObjectOutputStream(socket.getOutputStream());
			DataContainer mensaje = new DataContainer();
			mensaje.setUnString("¡Hola desde el cliente!");
			oos.writeObject(mensaje);
			System.out.println("Mensaje enviado: " + mensaje);

			oos.close();
			socket.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}