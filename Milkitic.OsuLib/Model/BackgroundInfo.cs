﻿using System.Globalization;

namespace Milkitic.OsuLib.Model
{
    public class BackgroundInfo
    {
        public string Unknown1 { get; set; }
        public string Unknown2 { get; set; }
        public string Filename { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public override string ToString()
        {
            return string.Join(",", Unknown1, Unknown2, $"\"{Filename}\"", X.ToString(CultureInfo.InvariantCulture),
                Y.ToString(CultureInfo.InvariantCulture));
        }
    }
}