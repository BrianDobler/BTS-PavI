using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTS_3k2_2020.Modelos
{
    public class Usuario
    {
        #region PropiedadNoAbreviada
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        #endregion


        #region PropiedadesAbreviadas
        //public string Nombre { get; set; }
        public long Id { get; set; }
        public string Password { get; set; }

        public Perfil Perfil { get; set; }

        public string Email { get; set; }
        #endregion

        public bool Estado { get; set; }
        public string Perfiles2 { get; internal set; }

        #region Constantes
        public string MensajeErrorNombre = "El campo nombre es requerido y no debe superar los 50 caracteres";
        public string MensajeErrorPassword = "El campo contraseña es requerido y debe tener mas de 8 caracteres";
        private TextBox nombreIngresado;
        private TextBox passwordIngresado;
        #endregion


        #region Constructores
        public Usuario()
        {

        }

        // Construtor con parametros
        public Usuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }

        public Usuario(TextBox nombreIngresado, TextBox passwordIngresado)
        {
            this.nombreIngresado = nombreIngresado;
            this.passwordIngresado = passwordIngresado;
        }
        #endregion


        #region Metodos
        public bool EsNombreValido()
        {
            return !string.IsNullOrEmpty(Nombre) &&
                    Nombre.Length < 51;
        }

        public bool EsPasswordValido()
        {
            return !string.IsNullOrEmpty(Password) &&
                    Password.Length > 8;
        }
        #endregion

        public bool EsPerfilValido()
        {
            return Perfil != null && Perfil.Id > 0;
        }

        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(this.Nombre))
                throw new ApplicationException("El nombre es requerido");
            if (!string.IsNullOrEmpty(this.Nombre) && this.Nombre.Length > 50)
                throw new ApplicationException("Nombre inválido. El nombre no debe superar los 50 caracteres");
        }

        public void ValidarPassword()
        {
            if (string.IsNullOrEmpty(this.Password))
                throw new ApplicationException("La contraseña es requerida");
            if (!string.IsNullOrEmpty(this.Password) && this.Password.Length > 10)
                throw new ApplicationException("Contraseña inválida. La contraseña no debe superar los 10 caracteres");
        }

        public void ValidarEmail()
        {
            if (!string.IsNullOrEmpty(this.Email) && this.Email.Length > 50)
                throw new ApplicationException("Email inválido. El email no debe superar los 50 caracteres");
        }

        public string MostrarEstado()
        {
            return Estado ? "S" : "N";
        }

        public string EstadoABD()
        {
            return Estado ? "S" : "N";
        }
    }
}

