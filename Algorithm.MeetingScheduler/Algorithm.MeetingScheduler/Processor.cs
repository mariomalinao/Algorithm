using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.MeetingScheduler
{
    public class Processor
    {
        private const int END_OF_DAY = 17;

        public Processor()
        {
            Persons = new List<Person>();
        }

        public void Run()
        {
            var blockedTime = new HashSet<int>();
            BuildData();

            var collatedMeetings = Persons.SelectMany(s => s.Meetings);

            collatedMeetings.ToList().ForEach(x => {
                var counter = x.StartTime;
                while (counter < x.EndTime)
                {
                    blockedTime.Add(counter);
                    counter++;
                }
            });

            FreeHours.AddRange(WorkHours.Except(blockedTime));

            foreach(var hour in FreeHours)
            {
                if (hour < END_OF_DAY)
                    Console.WriteLine($"Free time from {hour:d2}:00 to {hour+1:d2}:00");
            }
        }

        private List<int> WorkHours = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        private List<int> FreeHours = new List<int>();
        private IList<Person> Persons { get; set; }
        private void BuildData()
        {
            var marioPerson = new Person()
            {
                Name = "Mario Malinao",
                Meetings = new List<Meeting> {
                    new Meeting() { StartTime = 13, EndTime = 14 },
                    new Meeting() { StartTime = 15, EndTime = 16 }
                }
            };

            var keanuPerson = new Person()
            {
                Name = "Keanu Reeves",
                Meetings = new List<Meeting> {
                    new Meeting() { StartTime = 12, EndTime = 13 },
                    new Meeting() { StartTime = 15, EndTime = 16 }
                }
            };

            var peterPerson = new Person()
            {
                Name = "Peter Griffin",
                Meetings = new List<Meeting> {
                    new Meeting() { StartTime = 12, EndTime = 13 },
                    new Meeting() { StartTime = 13, EndTime = 14 }
                }
            };

            Persons.Add(marioPerson);
            Persons.Add(keanuPerson);
            Persons.Add(peterPerson);
        }
    }
}
