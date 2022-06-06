﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigJump.Classes
{
    public class Player
    {
        public Physics physics;
        public Image sprite;

        public Player()
        {
            sprite = Properties.Resources.man2;
            physics = new Physics(new PointF(100, 350), new Size(50, 50));
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite, physics.transform.position.X, physics.transform.position.Y, physics.transform.size.Width, physics.transform.size.Height);
        }
    }
}
