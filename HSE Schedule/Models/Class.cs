using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace HSE_Schedule.Models
{
    class Class
    {
        public Class(string discipline, DateTime startTime, DateTime endTime, string auditorium, string lecturer,
            string type, string location, string group)
        {
            Discipline = discipline ?? throw new ArgumentNullException(nameof(discipline));
            StartTime = startTime;
            EndTime = endTime;
            Auditorium = auditorium ?? throw new ArgumentNullException(nameof(auditorium));
            Lecturer = lecturer ?? throw new ArgumentNullException(nameof(lecturer));
            Type = type ?? throw new ArgumentNullException(nameof(type));
            Location = location ?? throw new ArgumentNullException(nameof(location));
            Group = group ?? throw new ArgumentNullException(nameof(group));
        }

        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public string Discipline { get; private set; }
        public string Lecturer { get; private set; }
        public string Location { get; private set; }
        public string Type { get; private set; }
        public string Auditorium { get; private set; }
        public string Group { get; private set; }

    }
}