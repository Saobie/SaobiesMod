using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class PalisadeLightning : ModProjectile
    {
        public override void SetDefaults()
        {
   //         projectile.CloneDefaults(ProjectileID.CultistBossLightningOrbArc);
			projectile.hostile = false;
			projectile.friendly = true;
            aiType = 466;
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