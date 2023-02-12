using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokemon.pokemons
{
    public class Charmander : Prokemon1
    {
        public Charmander()
        {
            this.name = "Charmander";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 295);
            this._image = Properties.Resources._004;
            this.Attack = random.Next(132, 224);
            this.Defense = random.Next(117, 247);
        }
    }
}
