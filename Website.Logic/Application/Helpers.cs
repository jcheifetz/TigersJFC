using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website.Logic.Application
{
    public class Helpers
    {
        public class customDateProvider : IFormatProvider, ICustomFormatter
        {
            public object GetFormat(Type formatType)
            {
                if (formatType == typeof(ICustomFormatter))
                    return this;

                return null;
            }

            public string Format(string format, object arg, IFormatProvider formatProvider)
            {
                if (!(arg is DateTime)) throw new NotSupportedException();

                var dt = (DateTime)arg;

                string suffix;

                if (dt.Day % 10 == 1 && dt.Day != 11)
                {
                    suffix = "st";
                }
                else if (dt.Day % 10 == 2 && dt.Day != 12)
                {
                    suffix = "nd";
                }
                else if (dt.Day % 10 == 3 && dt.Day != 13)
                {
                    suffix = "rd";
                }
                else
                {
                    suffix = "th";
                }

                return string.Format("{0:dddd} {1}{2} {0:MMMM} {0:yyyy}", arg, dt.Day, suffix);
            }


        }
    }
}