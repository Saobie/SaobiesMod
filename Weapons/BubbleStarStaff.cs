using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class BubbleStarStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Staff that calls forth the might of the cosmos.");
			Item.staff[item.type] = true;
		}
        public override void SetDefaults()
        {        
            item.damage = 140;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 50;
            item.height = 50;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 1;        
            item.value = Item.buyPrice(1, 27, 0, 0);
            item.rare = 9;
            item.mana = 15;             //mana use
            item.UseSound = SoundID.Item60;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BubbleStarProjectile");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }  
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 7 + Main.rand.Next(2); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
			//   position += Vector2.Normalize(new Vector2(speedX, speedY)) * 200f;
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 12);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(ItemID.Flairon, 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
    }
}