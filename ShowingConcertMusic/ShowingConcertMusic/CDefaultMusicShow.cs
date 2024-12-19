﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowingConcertMusic
{
    internal class CDefaultMusicShow : CMusicShow
    {
        public string typeMusicShowOrOriginOrGenresOfMusic {  get; private set; }
        
        public CDefaultMusicShow(string cityName, string misucShowName, string nameMisucPlace, string misucGroup, string dateMisucPlace, string typeMusicShowOrOriginOrGenresOfMusic) : base(cityName, misucShowName, nameMisucPlace, misucGroup, dateMisucPlace)
        {
            this.typeMusicShowOrOriginOrGenresOfMusic = typeMusicShowOrOriginOrGenresOfMusic;
            
        }

        
        
    }
}
