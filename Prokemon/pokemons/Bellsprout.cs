using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prokemon.pokemons
{
    public class Bellsprout : Prokemon1
    {
        public Bellsprout()
        {
            this.name = "Bellsporut";
            Random random = new Random();
            //random number between >= 200 and <295
            this.HP = random.Next(200, 295);
            this._image = Properties.Resources._069;
            this.Attack = random.Next(85, 174);
            this.Defense = random.Next(67 , 185);
        }
    }
}
