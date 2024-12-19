using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingConcertMusic
{
    internal class CBalletOpera : CMusicShow
    {
        

        public CBalletOpera(string cityName, string misucShowName, string nameMisucPlace, string misucGroup, string dateMisucPlace, double posOfMapX, double posOfMapY, bool isBalletorForNigth, string typeMusicShowOrOriginOrGenresOfMusic) : base(cityName, misucShowName, nameMisucPlace, misucGroup, dateMisucPlace, posOfMapX, posOfMapY, isBalletorForNigth, typeMusicShowOrOriginOrGenresOfMusic)
        {
            
        }

    }
}
