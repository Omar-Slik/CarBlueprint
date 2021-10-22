using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBlueprint
{
    public class SerielNumber
    {
        public long SerielNum { get; set; }
        public SerielNumber()
        {
            GetNumber();
        }
        public long GetNumber()
        {
            long LongRandom(long min, long max, Random rand)
            {
                long result = rand.Next((Int32)(min >> 32), (Int32)(max >> 32));
                result = (result << 32);
                result = result | (long)rand.Next((Int32)min, (Int32)max);
                return result;

            }
            long r = LongRandom(11111111111111, 999999999999999999, new Random());
            SerielNum = r;
            return r;
        }
    }
}
