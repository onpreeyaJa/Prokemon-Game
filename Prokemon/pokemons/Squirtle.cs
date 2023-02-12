using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokemon.pokemons
{
    public class Squirtle : Prokemon1
    {
        public Squirtle() 
        {
            this.name = "Squirtle";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 265);
            this._image = Properties.Resources._030;
        
        }
    }
}
