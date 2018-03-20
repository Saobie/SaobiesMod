using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class SwordBeam : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tome that summons an ethereal sword to launch at foes."
					+ "\nConsumes 1 Summoner Stone.");
		}
        public override void SetDefaults()
        {        
            item.damage = 16;                        
            item.summon = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = Item.buyPrice(0, 12, 45, 80);
            item.rare = 2;
            item.mana = 9;             //mana use
            item.UseSound = SoundID.Item15;            //this is the sound when you use the item
            item.autoReuse = true;
			item.useAmmo = mod.ItemType("SummonerStone");
            item.shoot = ProjectileID.EnchantedBeam;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 1 + Main.rand.Next(0); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }  
    }
}