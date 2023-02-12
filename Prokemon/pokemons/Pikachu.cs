using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokemon.pokemons
{
    public class Pikachu : Prokemon1
    {
        public Pikachu()
        {
            this.name = "Pikachu";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 295);
            this._image = Properties.Resources._025;
            this.Attack = random.Next(130, 245);
            this.Defense = random.Next(117, 247);
        }
    }
}
