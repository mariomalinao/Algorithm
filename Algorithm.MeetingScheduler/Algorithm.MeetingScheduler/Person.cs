using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.MeetingScheduler
{
    public class Person
    {
        public string Name { get; set; }
        public IList<Meeting> Meetings { get; set; }

        internal static void Select(Func<object, object> value)
        {
            throw new NotImplementedException();
        }
    }
}
