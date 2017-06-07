using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace IsoMetall
{
    class Alarm
    {
        private SoundPlayer alarm;

        public Alarm()
        {
            alarm = new SoundPlayer(); // instancie l'objet alarm pour charger le fichier audio 
            alarm.SoundLocation = Environment.CurrentDirectory + @"\Alarm\WAILING_.WAV";// charger l'audio de l'alarm depuis un dossier de l'emplacement du projet
        }

        public void Start()
        {
            this.alarm.PlayLooping();
        }

        public void Stop()
        {
            this.alarm.Stop();
        }
    }
}
