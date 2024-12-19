using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingConcertMusic
{
    internal class CDefaultMusicShow : CMusicShow
    {
        

        public CDefaultMusicShow(string cityName, string misucShowName, string nameMisucPlace, string misucGroup, double posOfMapX, double posOfMapY, string dateMisucPlace, bool isBalletorForNigth, string typeMusicShowOrOriginOrGenresOfMusic) : base(cityName, misucShowName, nameMisucPlace, misucGroup, dateMisucPlace, posOfMapX, posOfMapY, isBalletorForNigth, typeMusicShowOrOriginOrGenresOfMusic)
        {
            
        }



    }
}
