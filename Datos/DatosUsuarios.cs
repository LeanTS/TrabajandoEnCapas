using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Data.OleDb;

namespace Datos
{
    public class DatosUsuarios : DatosConexionBD
    {
        public int abmUsuarios(string accion, Usuario objUsuario)
        {
            int resultado = -1; //verifica que se realice la operacion
            string orden = string.Empty; //guardar consulta sql

            if (accion == "Alta") // agregar usuario
                orden = "insert into Usuarios values (" + objUsuario.CodUser +
                ", '" + objUsuario.User + "', '" 
                + objUsuario.ClaveUser + "', '" 
                + objUsuario.Nombre + "', '"
                + objUsuario.Apellido + "', '" 
                + objUsuario.Email + "', "
                + objUsuario.Edad + ", '" 
                + objUsuario.FechaNacimiento + "', '" 
                + objUsuario.FechaCreacion + "', "
                + objUsuario.NumeroCel + "');";

            if (accion == "Modificar") //Modifica propiedades del usuario existente
            {
                orden = "update Profesionales set clavUser='" + objUsuario.ClaveUser +
                    "', set nomUser= '" + objUsuario.Nombre +
                    "', set apelUser= '" + objUsuario.Apellido +
                    "', set edadUser= " + objUsuario.Edad +
                    ", set nacimientoUser= '" + objUsuario.FechaNacimiento +
                    "', set numCel= " + objUsuario.NumeroCel +
                    " where codUser= " + objUsuario.CodUser + "; ";
            }


            SqlCommand cmd = new SqlCommand(orden, conexion);

            try
            {
                AbrirConexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de guardar,borrar o modificar de Usuario",e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoProfesionales(string cual) //1 o todos los datos
        {
            string orden = string.Empty;
            if (cual != "Todos")
                orden = "select * from Usuarios where CodProf = " + int.Parse(cual) + ";";
            else
                orden = "select * from Usuarios;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;//quede aca
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar profesionales", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
