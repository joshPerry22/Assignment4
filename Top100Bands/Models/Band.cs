using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Top100Bands.Models
{
    public class Band
    {
        public Band(int rank)
        {
            BandRanking = rank; //read only property, removed the setter
        }
        public int? BandRanking { get;  } = 999; //if null sets to 999
        public string BandName { get; set; }
        public float BandPoints { get; set; }

        
        public static Band[] GetBands()
        {

            Band b1 = new Band(1)
            {
                //BandRanking = 1,
                BandName = "Led Zeppelin",
                BandPoints = 528

            };

            Band b2 = new Band(2)
            {
               // BandRanking = 2,
                BandName = "Beatles",
                BandPoints = 514
            };

            Band b3 = new Band(3)
            {
               // BandRanking = 3,
                BandName = "Pink Floyd",
                BandPoints = 506
            };

            Band b4 = new Band(4)
            {
               // BandRanking = null,

                BandName = "The Jimi Hendrix Experience",
            };

            return new Band[] { b1,b2,b3,b4 };
        }
    }
}
