using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BLL
{
    public class CopiaBusiness
    {
        McCopia mc = new McCopia();

        CompraBusiness compraBs = new CompraBusiness();

        static void Main()
        {
            //CopiaEntity copia = new CopiaEntity();
            //CompraBusiness compraBs = new CompraBusiness();
            //compraBs.CompraRealizada += c_ThresholdReached;
            //compraBs.CompraRealizada += new EventHandler((sender, e) => PlayMusicEvent(sender, e, copia));
            // provide remaining implementation for the class
        }
        
        public List<CopiaEntity> ObtenerDiscos()
        {
            return mc.Listar();
        }

        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }

        public void PlayMusicEvent(object sender, EventArgs e, CopiaEntity music)
        {
            //music.player.Stop();
            //System.Timers.Timer myTimer = (System.Timers.Timer)sender;
            //myTimer.Stop();
        }
    }
}
