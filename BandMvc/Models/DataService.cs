namespace BandMvc.Models
{
    public class DataService
    {
        static List<Band> bands= new List<Band>()
        {
            new Band{ Id= 0, Name = "System of a Down", Description = "System of a Down is an Armenian American heavy metal band formed in Glendale, California, in 1994. Since 1997, the band has consisted of Serj Tankian; Daron Malakian; Shavo Odadjian; and John Dolmayan, who replaced original drummer Andy Khachaturian" },
            new Band{ Id= 1, Name = "Bullet for my valentine", Description = "Bullet for My Valentine, often abbreviated as BFMV, are a Welsh heavy metal band from Bridgend, formed in 1998. The band is currently composed of Matthew Tuck, Michael Paget, Jason Bowld and Jamie Mathias. Former members include Michael Thomas, Jason James and Nick Crandle; the latter were on bass." },
            new Band{ Id= 2, Name = "Likin Park", Description = "Linkin Park is an American rock band from Agoura Hills, California. The band's current lineup comprises vocalist/rhythm guitarist/keyboardist Mike Shinoda, lead guitarist Brad Delson, bassist Dave Farrell, DJ/turntablist Joe Hahn and drummer Rob Bourdon, all of whom are founding members" },
        };

        public Band GetBandById(int id) 
        {
            return bands.Single(o => o.Id == id); 
        }

        public Band[] GetAlBands()
        {
            return bands.ToArray();
        }
    }
}
