using BE;
using DAL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class UsuarioBusiness : IUSuario
    {

        public virtual  void CrearUsuario(UsuarioEntity usuario)
        {

        }

        //McUsuario mc = new McUsuario();
        McTraductor mcTraductor = new McTraductor();
        McPermiso mcPermiso = new McPermiso();
        public static UsuarioEntity Login(UsuarioEntity usuario)
        {
            try
            {
                if (String.IsNullOrEmpty(usuario.Nombre) || String.IsNullOrEmpty(usuario.Password)) throw new Exception("Debe completar todos los campos");

                string rol = McUsuario.ValidarUsuario(usuario);
                if (rol != "")
                {
                    usuario.Rol = rol;
                    SessionState.Login(usuario);
                    usuario.Permisos = McPermiso.Listar(usuario);

                   // return GestionarTipoUsuario(usuario);
                    //PREGUNTAR
                    //No puedo convertir superclase en subclase
                }
                else
                {
                    throw new Exception("Usuario o contraseña incorrecta");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                usuario.Nombre = "error";

            }
            return usuario;

        }

        public static UsuarioEntity GestionarTipoUsuario(UsuarioEntity usuario)
        {
            if(usuario.Rol == "Cliente")
            {
                //return (UsuarioClienteEntity)usuario;
                return new UsuarioClienteEntity();
            }
            if (usuario.Rol == "Empresa")
            {
                return (UsuarioComercialEntity)usuario;
            }
            if (usuario.Rol == "Logistica")
            {
                return (UsuarioLogisticaEntity)usuario;
            }
            else
            {
                throw new Exception("El usuario no matchea con ningún rol");
            }
        }

        public void ValidarUsuario(UsuarioEntity usuario)
        {
            if(SessionState.Login(usuario))
            {
                
            }
            else
            {
                //revisar si el usuario existe
            }
        }

        public List<UsuarioEntity> ListarNoBoss()
        {
            return McUsuario.ListarUsuariosNoBoss();    
        }
        public string Encriptar(string clave)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(clave);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }



    }
}
