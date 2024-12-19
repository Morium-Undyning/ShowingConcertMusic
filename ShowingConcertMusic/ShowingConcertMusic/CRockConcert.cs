using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingConcertMusic
{
    internal class CRockConcert : CMusicShow
    {
        public bool isBalletorForNigth {  get; private set; }
        public string typeMusicShowOrOriginOrGenresOfMusic { get; private set; }
        
        public CRockConcert(string cityName, string misucShowName, string nameMisucPlace, string misucGroup, string dateMisucPlace, string typeMusicShowOrOriginOrGenresOfMusic, bool isBalletorForNigth) : base(cityName, misucShowName, nameMisucPlace, misucGroup, dateMisucPlace)
        {
            this.typeMusicShowOrOriginOrGenresOfMusic = typeMusicShowOrOriginOrGenresOfMusic;
            this.isBalletorForNigth = isBalletorForNigth;
        }

        
    }
}
