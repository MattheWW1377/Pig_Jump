using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigJump.Classes
{
    public class Bullet
    {
        public Physics physics;
        public Image sprite;

        public Bullet(PointF pos)
        {
            sprite = Properties.Resources.bullet;
            physics = new Physics(pos, new Size(-25, 20));
        }

        public void MoveUp()
        {
            physics.transform.position.Y -= 40;
        }

        public void DrawSprite(Graphics g)
        {
            g.DrawImage(sprite, physics.transform.position.X, physics.transform.position.Y, physics.transform.size.Width, physics.transform.size.Height);
        }
    }
}
