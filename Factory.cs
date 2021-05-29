using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greyhound_Racing_Game
{

    public static class Factory
    {

        public static Punter Punterdata(int id)
        {
            switch (id)
            {
                case 0: return new Parminder();
                case 1: return new Jaskaran();
                case 2: return new Jashan();
                default: return null;
            }
        }

    }
}
