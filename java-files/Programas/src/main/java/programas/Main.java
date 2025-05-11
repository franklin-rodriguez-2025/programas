//
// Main.java
//
package programas;

public class Main
{
    public static void main(String[] args)
    {
        testClienteServidor();
    }

    private static void testClienteServidor()
    {
        // Ejecutar el servidor en un hilo separado
        new Thread(() -> {
            Servidor servidor = new Servidor();
            servidor.iniciar(8181);
        }).start();

        // Esperar un momento para asegurarse
        // de que el servidor está listo
        try {
            Thread.sleep(1000);
        } catch (Exception e) {
            e.printStackTrace();
        }

        Cliente cliente = new Cliente();
        cliente.conectar("localhost", 8181);
    }
}