using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class VilebubbleSmall : ModProjectile
    {
 
 
        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.penetrate = 1; 
            projectile.magic = true; 
 
            projectile.aiStyle = 70; 
        }
		public override void AI()
        {
			Lighting.AddLight((int)(projectile.Center.X / 16f), (int)(projectile.Center.Y / 16f), 0.8f, 0.2f, 0.2f);
			Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 20, 0f, 0f, 100, new Color(90, 0, 0), 2f);
			dust.noGravity = true;
			
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
			
			if (projectile.localAI[0] > 300f) 
            {
                projectile.Kill();
            }
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Player player = Main.player[projectile.owner];

                    if (projectile.owner == Main.myPlayer && !Main.LocalPlayer.moonLeech)
					{
						int heal = damage;
						int damages = player.statLifeMax2 - player.statLife;
							if (heal > damages)
							{
								heal = damages;
							}
							player.statLife += heal;
							player.HealEffect(heal);
					}
			
			if (Main.rand.Next(7) == 0)
			{
				target.AddBuff(BuffID.Venom, 300);
			}
				
		}
		public override void Kill(int timeLeft)
        {
			
			
			Vector2 position = projectile.Center;
			Main.PlaySound(SoundID.Item54, (int)position.X, (int)position.Y);
			Vector2 velocity = Vector2.UnitX.RotateRandom(MathHelper.TwoPi);
			float speed = 4f;
			int numProj = 1;
			for (int i = 0; i < numProj; i++)
			{
				Projectile.NewProjectile (projectile.Center, velocity.RotatedBy(MathHelper.TwoPi / numProj * i) * speed, mod.ProjectileType("VilebubbleBead"), projectile.damage / 2, 0, Main.myPlayer, 0f, 0f);
			}
		}
       
    }
}