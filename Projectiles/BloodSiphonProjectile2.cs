using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class BloodSiphonProjectile2 : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 20;
            projectile.friendly = true;
            projectile.penetrate = 1;                       
            Main.projFrames[projectile.type] = 1;           
            projectile.hostile = false;
            projectile.magic = true;                       
            projectile.tileCollide = true;                 
            projectile.ignoreWater = true;
			projectile.aiStyle = 36;
			projectile.alpha = 250;
        }
 
        public override void AI()
        {
			
			
		Dust.NewDust(projectile.position, projectile.width, projectile.height, 258, 0f, 0f, 0, default(Color), 1f);
		projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
       
           
            if (projectile.localAI[0] > 600f) 
            {
                projectile.Kill();
            }
           
        }
		
		
		
		public override void Kill(int timeLeft)
        {
			Vector2 position = projectile.Center;
			Main.PlaySound(SoundID.Item54, (int)position.X, (int)position.Y);
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			
           Player player = Main.player[projectile.owner];

                    if (projectile.owner == Main.myPlayer && !Main.LocalPlayer.moonLeech)
					{
						int heal = damage / 2;
						if (damage <= 2);
						{
							player.statLife += 1;
							player.HealEffect(1);
						}
						int damages = player.statLifeMax2 - player.statLife;
							if (heal > damages)
							{
								heal = damages;
							}
							player.statLife += heal;
							player.HealEffect(heal);
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