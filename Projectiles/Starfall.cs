using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class Starfall : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 38;
            projectile.height = 38;
            projectile.friendly = true;
            projectile.penetrate = 3;                       //this is the projectile penetration
            Main.projFrames[projectile.type] = 1;           //this is projectile frames
            projectile.hostile = false;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f; 
            if (projectile.localAI[0] > 800f) //projectile time left before disappears
            {
                projectile.Kill();
            }          
        }
        public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
        {
            projectile.frameCounter++; //increase the frameCounter by one
            if (projectile.frameCounter >= 10) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
            {
                projectile.frame++; //go to the next frame
                projectile.frameCounter = 0; //reset the counter
                if (projectile.frame > 3) //if past the last frame
                    projectile.frame = 0; //go back to the first frame
            }
            return true;
        }  
    }
}