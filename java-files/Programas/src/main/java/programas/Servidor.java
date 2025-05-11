//
// Servidor.java
//
package programas;

import java.math.BigDecimal;
import java.io.*;
import java.net.*;

public class Servidor implements Serializable
{
	@Serial
	private static final long serialVersionUID = 9L;

	private ServerSocket serverSocket;

	public void iniciar(int puerto)
	{
		try {
			serverSocket = new ServerSocket(puerto);
			System.out.println("Servidor iniciado en el puerto " + puerto);
			
			// Espera por un cliente
			Socket socket = serverSocket.accept();
			System.out.println("Cliente conectado.");
			
			ObjectInputStream ois = new ObjectInputStream(socket.getInputStream());
			DataContainer mensaje = (DataContainer) ois.readObject();
			System.out.println("Servidor recibió: " + mensaje.toString());
			
			ois.close();
			socket.close();
			serverSocket.close();
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}
}
