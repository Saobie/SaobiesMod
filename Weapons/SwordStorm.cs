using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class SwordStorm : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Launches a flurry of ethereal swords at foes."
								+ "\nConsumes 4 Summoner Stone.");
		}
        public override void SetDefaults()
        {        
            item.damage = 24;                        
            item.summon = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 15;
            item.useAnimation = 60;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = Item.buyPrice(0, 18, 45, 80);
            item.rare = 2;
            item.mana = 12;             //mana use
            item.UseSound = SoundID.Item15;            //this is the sound when you use the item
            item.autoReuse = true;
			item.useAmmo = mod.ItemType("SummonerStone");
            item.shoot = ProjectileID.SkyFracture;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 1 + Main.rand.Next(0); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(4)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }  
		  public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SwordBeam", 1);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(ItemID.Book, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}