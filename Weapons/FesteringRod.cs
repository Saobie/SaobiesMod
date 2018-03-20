using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class FesteringRod : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Staff built from parts of a horrible monster. Spews wicked fires, the likes of those drawn from the creatures great jaws itself.");
		}
        public override void SetDefaults()
        {        
            item.damage = 30;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = Item.buyPrice(0, 12, 45, 80);
            item.rare = 3;
            item.mana = 16;             //mana use
            item.UseSound = SoundID.Item60;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = ProjectileID.DD2FlameBurstTowerT1Shot;  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 3 + Main.rand.Next(0); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(12)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }  
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 4);
			recipe.AddIngredient(mod, "HorribleClump", 10);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 4);
			recipe.AddIngredient(mod, "HorribleClump", 10);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}