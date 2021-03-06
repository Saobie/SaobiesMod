using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Projectiles
{
    public class VilebubbleBead : ModProjectile
    {
 
 
        public override void SetDefaults()
        {
            projectile.width = 16;
            projectile.height = 16;
            projectile.friendly = true;
            projectile.penetrate = -11; 
            projectile.magic = true; 
 
            projectile.aiStyle = 0; 
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
    }
}