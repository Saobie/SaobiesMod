using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Projectiles
{
    public class StarLashProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Lash");
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ShadowFlame);
            aiType = ProjectileID.ShadowFlame;
        }

        public override bool PreKill(int timeLeft)
        {
            projectile.type = ProjectileID.ShadowFlame;
            return true;
        }


        /*     public override bool OnTileCollide(Vector2 oldVelocity)
             {
                 for (int i = 0; i < 5; i++)
                 {
                     int a = Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y - 16f, Main.rand.Next(-10, 11) * .25f, Main.rand.Next(-10, -5) * .25f, mod.ProjectileType("BubbleStarStar"), (int)(projectile.damage * .5f), 0, projectile.owner);
                     Main.projectile[a].aiStyle = 1;
                     Main.projectile[a].tileCollide = true;
                 }
                 return true;
             }  */
        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            Player player = Main.player[projectile.owner];

            if (projectile.owner == Main.myPlayer && !Main.LocalPlayer.moonLeech)
            {
                int heal = damage;
                int damages = player.statManaMax2 - player.statMana;
                if (heal > damages)
                {
                    heal = damages;
                }
                player.statMana += heal / 4;
                player.ManaEffect(heal);
            }
            Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, projectile.velocity.X, projectile.velocity.Y, mod.ProjectileType("BubbleStarStar"), damage / 3, 0, Main.myPlayer, 0f, 0f);
        }
    }
}