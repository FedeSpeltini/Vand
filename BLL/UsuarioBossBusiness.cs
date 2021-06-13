using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBossBusiness
    {
        private List<UsuarioEntity> usuarios;

        public List<UsuarioEntity> Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }

        //public void CambiarValorVandCoin(decimal nuevoValor)
        //{
        //    //Business logic to validate and add a product.
        //    var subjectEvent = new SubjectEvent
        //    {
        //        EventType = "ProductAdded",
        //        EventDate = DateTime.Now
        //    };
        //    NotifyObservers(subjectEvent);
        //}
        //public void Notificar(SubjectEvent subjectEvent)
        //{
        //    Console.WriteLine("Before notifying observers");
        //    foreach (UsuarioEntity observer in usuarios)
        //    {
        //        observer.Wallet.Ac(subjectEvent);
        //    }
        //    Console.WriteLine("After notifying observers");
        //}
    }
}
