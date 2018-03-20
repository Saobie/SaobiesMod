using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Projectiles
{
	public class LeechArrow : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.width = 13;
            projectile.height = 70;
			projectile.scale = 0.5f;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.penetrate = 1;
            projectile.aiStyle = 1;
            aiType = 1;
        }
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Leech Arrow");
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
			target.AddBuff(BuffID.Venom, 60);
		
		}  
		public override void Kill(int timeLeft)
        {
			Main.PlaySound(SoundID.Item10, projectile.position);
		}
		public override void AI()
        {
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 136, 0f, 0f, 0, default(Color), 1f);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 0, default(Color), 1.6f);
        }
	}
}