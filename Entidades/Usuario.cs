using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region atributos
        private int codUser;
        private string user;
        private string claveUser;
        private string nombre;
        private string apellido;
        private string email;
        private int edad;
        private DateTime fechaNacimiento;
        private DateTime fechaCreacion;
        private int numerocel;
        #endregion

        #region Constructor

        public Usuario()
        {
            codUser = 0;
            user = string.Empty;
            nombre = string.Empty;
            apellido = string.Empty;
            edad = 0;
            fechaNacimiento = DateTime.MinValue;
            fechaCreacion = DateTime.MinValue;
        }
        #endregion
        #region propiedades/encapsulamiento
        public int CodUser
        {
            get { return codUser; }
            set { codUser = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string ClaveUser
        {
            get { return claveUser; }
            set { claveUser = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }
        public int NumeroCel
        {
            get { return numerocel; }
            set { numerocel = value; }
        }
        #endregion
    }
}
