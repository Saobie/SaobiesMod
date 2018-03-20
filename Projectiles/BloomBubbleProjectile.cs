using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class BloomBubbleProjectile : ModProjectile
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
			Dust dust = Dust.NewDustDirect(projectile.position, projectile.width, projectile.height, 258, 0f, 0f, 100, default(Color), 2f);
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
           
			
			Vector2 velocity = Vector2.UnitX.RotateRandom(MathHelper.TwoPi);
			float speed = 7f;
			int numProj = 6;
			for (int i = 0; i < numProj; i++)
			{
				Projectile.NewProjectile (projectile.Center, velocity.RotatedBy(MathHelper.TwoPi / numProj * i) * speed, mod.ProjectileType("BloodSiphonProjectile2"), damage / 4, 0, Main.myPlayer, 0f, 0f);
			}
			target.AddBuff(BuffID.Venom, 300);
			
			if (Main.rand.Next(7) == 0)
			{
				target.AddBuff(BuffID.Confused, 120);
			}
				
		}
		public override void Kill(int timeLeft)
        {
			
			
			Vector2 position = projectile.Center;
			Main.PlaySound(SoundID.Item54, (int)position.X, (int)position.Y);
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X * 1.2f, projectile.velocity.Y * 1.2f, mod.ProjectileType("BloodSiphonProjectile2"), projectile.damage / 4, 0, Main.myPlayer, 0f, 0f);
		}
       
    }
}