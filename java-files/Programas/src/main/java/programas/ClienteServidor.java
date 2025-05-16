//
// ClienteServidor.java
//
package programas;

import java.io.*;
import java.net.*;
import java.math.BigDecimal;

public class ClienteServidor implements Serializable
{
	@Serial
	private static final long serialVersionUID = 9L;

	public static void main(String host, int puerto)
	{
		final int port = 8010;
		// Iniciar programa Servidor.java
		Thread thread = new Thread(() -> {
			Servidor servidor = new Servidor();
			System.out.println("Servicio en puerto: " + port );
			servidor.iniciar(port);
		}).start();
		
		// Esperar un momento para asegurarse de que el servidor está listo
		try
		{
			Thread.sleep(2700);
		}
		catch (InterruptedException e)
		{
			System.out.println(e.printStackTrace(););
			System.err.println(e.printStackTrace(););
		}
		
		// Iniciar programa cliente
		Cliente cliente = new Cliente();
		cliente.conectar("127.0.0.1", port);
	}
}
