﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MapEditor.Classes
{
    public class MapSegment
    {
        public Vector2 Location;
        public int Index { get; set; }
        public int Layer { get; set; }

        public MapSegment()
        {

        }
    }
}
