using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class MiniTrident : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 22;
            projectile.height = 60;
			projectile.scale = 0.3f;
            projectile.friendly = false;
            projectile.penetrate = 3;                       //this is the projectile penetration
            Main.projFrames[projectile.type] = 1;           //this is projectile frames
            projectile.hostile = true;
            projectile.magic = true;                        //this make the projectile do magic damage
            projectile.tileCollide = false;                 //this make that the projectile does not go thru walls
            projectile.ignoreWater = true;
        }
 
        public override void AI()
        {
			
		//	int num3;
					//	for (int num20 = 0; num20 < 4; num20 = num3 + 1)
					//	{
						//	float num21 = projectile.velocity.X / 4f * (float)num20;
						//	float num22 = projectile.velocity.Y / 4f * (float)num20;
							Dust.NewDust(projectile.position, projectile.width, projectile.height, 258, 0f, 0f, 0, default(Color), 1f);
					//		Main.dust[num23].position.X = projectile.Center.X - num21;
					//		Main.dust[num23].position.Y = projectile.Center.Y - num22;
					//		Dust dust3 = Main.dust[num23];
					//		dust3.velocity *= 0f;
					//		Main.dust[num23].scale = 0.2f;
					//		num3 = num20;
					//	}
                                                                //this is projectile dust
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
       //     projectile.alpha = (int)projectile.localAI[0] * 2;
	   
			Lighting.AddLight(projectile.Center, ((255 - projectile.alpha) * 0.15f) / 255f, ((255 - projectile.alpha) * 0.45f) / 255f, ((255 - projectile.alpha) * 0.05f) / 255f);
           
            if (projectile.localAI[0] > 180f) //projectile time left before disappears
            {
                projectile.Kill();
            }
           
        }
		
		
	/*	public override bool OnTileCollide(ref Vector2 velocityChange)  //Thanks to Diverman Sam for this wonderful code for bouncing off walls!
        {
            if (projectile.velocity.X != velocityChange.X)
            {
                projectile.velocity.X = -velocityChange.X/2;
            }
            if (projectile.velocity.Y != velocityChange.Y)
            {
                projectile.velocity.Y = -velocityChange.Y/2;
            }
            return false;
        }  */
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