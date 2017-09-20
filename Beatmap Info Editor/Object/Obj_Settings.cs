﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor.Object
{
    public class OsuFile
    {
        public int Version { get; set; }
        public obj_General General { get; set; }
        public obj_Editor Editor { get; set; }
        public obj_Metadata Metadata { get; set; }
        public obj_Difficulty Difficulty { get; set; }
        public obj_Events Events { get; set; }
        public obj_TimingPoints TimingPoints { get; set; }
        public obj_Colours Colours { get; set; }
        public obj_HitObjects HitObjects { get; set; }
        public string TheRestText { get; set; }

        public string FileName
        {
            get
            {
                string title = Metadata.Artist + " - " + Metadata.Title + " (" + Metadata.Creator + ")" +
                    (Metadata.Version != "" ? " [" + Metadata.Version + "]" : "") + ".osu";
                return title.Replace(@"\", "").Replace(@"/", "").Replace(@":", "").Replace(@"*", "")
                    .Replace(@"?", "").Replace("\"", "").Replace(@"<", "").Replace(@">", "").Replace(@"|", "");
            }
        }
        public override string ToString()
        {
            return "osu file format v" + Version.ToString() + Environment.NewLine + TheRestText + General + Editor + Metadata +
                Difficulty + Events + TimingPoints + Colours + HitObjects + TheRestText;
        }
    }
}
