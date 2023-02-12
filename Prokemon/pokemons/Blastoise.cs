using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokemon.pokemons
{
    public class Blastoise : Prokemon1
    {
        public Blastoise()
        {
            this.name = "Blastoise";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 295);
            this._image = Properties.Resources._009;
            this.Attack = random.Next(110, 254);
            this.Defense = random.Next(117, 247);

        }
    }
}
