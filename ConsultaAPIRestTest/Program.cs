using ConsultaAPIRestTest;
using RestSharp;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            ConsultasAPI ca = new ConsultasAPI();

            //Usuario? usuario = ca.GetUsuarioPorID("6350asc696fd8c3f65c09872f5");
            //Console.WriteLine(usuario.Nombre);

            Usuario usuario = new Usuario("Marcos", "1254125", "Av. test");           
            ca.PostUsuario(usuario);


        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

    }
}