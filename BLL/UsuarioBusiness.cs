using BE;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBusiness : IUSuario
    {

        public virtual void CrearUsuario(string username, string pwd)
        {

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
