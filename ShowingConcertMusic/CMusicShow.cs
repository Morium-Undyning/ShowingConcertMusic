using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingConcertMusic
{
    public class CMusicShow
    {
        public string cityName { get; private set; }
        public string misucShowName { get; private set; }
        public string nameMisucPlace { get; private set; }
        public string misucGroup { get; private set; }
        public string dateMisucPlace { get; private set; }
        public double posOfMapX { get; private set; }
        public double posOfMapY { get; private set; }
        public bool isBalletorForNigth { get; private set; }
        public string typeMusicShowOrOriginOrGenresOfMusic { get; private set; }

        protected CMusicShow(string cityName, string misucShowName, string nameMisucPlace, string misucGroup, string dateMisucPlace, double posOfMapX, double posOfMapY, bool isBalletorForNigth, string typeMusicShowOrOriginOrGenresOfMusic)
        {
            this.cityName = cityName;
            this.misucShowName = misucShowName;
            this.nameMisucPlace = nameMisucPlace;
            this.misucGroup = misucGroup;
            this.dateMisucPlace = dateMisucPlace;
            this.posOfMapX = posOfMapX;
            this.posOfMapY = posOfMapY;
            this.typeMusicShowOrOriginOrGenresOfMusic = typeMusicShowOrOriginOrGenresOfMusic;
            this.isBalletorForNigth = isBalletorForNigth;


        }

        


    }
}
