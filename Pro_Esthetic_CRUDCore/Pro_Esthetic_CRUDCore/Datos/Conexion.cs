using System.Data.SqlClient;

namespace Pro_Esthetic_CRUDCore.Datos
{
    public class Conexion
    {

        private string  conexion = string.Empty;

        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            conexion = builder.GetSection("ConnectionStrings:conexion").Value;
        }

        public string getconexion()
        {
            return conexion;
        }
    }
}
