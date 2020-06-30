using CapaDatos.clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class GestionBD
    {
        SqlConnection conexion;
        SqlCommand comando;

        //--INSERTAR--//
        public bool registrarHerramie(Herramienta objherra)
        {
            int control = -1;
            bool respuesta = false;

            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-GEUAC8A\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True";  //String de Conexion
            
            {
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Insert into Herramientas (idProducto,nombre,costoUnit,marca,tipoHerramienta) " +
                                      "Values (@idProducto,@nombre,@costoUnit,@marca,@tipoHerramienta)";

                //--DEFINICION DE PARAMETROS--//
                comando.Parameters.Add(new SqlParameter("@idproducto", objherra.idProducto));
                comando.Parameters.Add(new SqlParameter("@nombre", objherra.nombre));
                comando.Parameters.Add(new SqlParameter("@costoUnit", objherra.costoUnit));
                comando.Parameters.Add(new SqlParameter("@marca", objherra.marca));
                comando.Parameters.Add(new SqlParameter("@tipoHerramienta", objherra.tipoHerramienta));
                conexion.Open();

                control = comando.ExecuteNonQuery();
            }

            if (control > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        //----MODIFICAR-----//
        public bool ModificararHerramie(Herramienta objherra)
        {
            int control = -1;
            bool respuesta = false;

            conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-GEUAC8A\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True";  //String de Conexion

            {
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Update herramientas set nombre = @nombre , costoUnit = @costoUnit,marca = @marca,tipoHerramienta= @tipoHerramienta where idproducto=@idproducto";


                //DEFINICION DE PARAMETROS
                comando.Parameters.Add(new SqlParameter("@idproducto", objherra.idProducto));
                comando.Parameters.Add(new SqlParameter("@nombre", objherra.nombre));
                comando.Parameters.Add(new SqlParameter("@costoUnit", objherra.costoUnit));
                comando.Parameters.Add(new SqlParameter("@marca", objherra.marca));
                comando.Parameters.Add(new SqlParameter("@tipoHerramienta", objherra.tipoHerramienta));
                conexion.Open();

                control = comando.ExecuteNonQuery();  
            }

            if (control > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }

        //----ELIMINAR---//
        public bool EliminarHerramie(Herramienta objherra)
        {
            int control = -1;
            bool respuesta = false;

            conexion = new SqlConnection(); 
            conexion.ConnectionString = @"Data Source=DESKTOP-GEUAC8A\SQLEXPRESS;Initial Catalog=Ferreteria;Integrated Security=True";  //String de Conexion

            {
                comando = new SqlCommand();
                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Delete from herramientas where idproducto=@idproducto";

                //DEFINICION DE PARAMETRO
                comando.Parameters.Add(new SqlParameter("@idproducto", objherra.idProducto));

                conexion.Open();

                control = comando.ExecuteNonQuery();  
            }

            if (control > 0)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
