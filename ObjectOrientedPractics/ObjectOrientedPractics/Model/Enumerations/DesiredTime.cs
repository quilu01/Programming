using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Enumerations
{
    public class DesiredTime
    {
        private static string[] _desiredTimes = new string[6];
        private static bool _cached = false;
        public static string[] DesiredTimes
        {
            get
            {
                
                if (!_cached)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        _desiredTimes[i] = $"{i * 2 + 9}:00 - {i * 2 + 11}:00";
                    }
                    _cached = true;
                    
                    return _desiredTimes;
                }
                else
                {
                    return _desiredTimes;
                }
            }
        }
    }
}
