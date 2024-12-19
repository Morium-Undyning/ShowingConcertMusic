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

        protected CMusicShow(string cityName, string misucShowName, string nameMisucPlace, string misucGroup, string dateMisucPlace) 
        {
            this.cityName = cityName;
            this.misucShowName = misucShowName;
            this.nameMisucPlace = nameMisucPlace;
            this.misucGroup = misucGroup;
            this.dateMisucPlace = dateMisucPlace;
        }

        
    }
}
