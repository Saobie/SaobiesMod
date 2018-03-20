using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class GreatDominion : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Usher in a new order.");
			Item.staff[item.type] = true;
		}
        public override void SetDefaults()
        {           
			item.damage = 350;
            item.magic = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded       
            item.value = Item.buyPrice(1, 12, 45, 80);
        }   
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
              int numberProjectiles = 6 + Main.rand.Next(3); //This defines how many projectiles to shot. 4 + Main.rand.Next(2)= 4 or 5 shots
			//   position += Vector2.Normalize(new Vector2(speedX, speedY)) * 200f;
              for (int i = 0; i < numberProjectiles; i++)
              {
                  Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(6)); // This defines the projectiles random spread . 30 degree spread.
                  Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
              }
              return false;
          }  
		  
		public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
                item.damage = 150;                        
				item.magic = true;                     //this make the item do magic damage
				item.useTime = 20;
				item.useAnimation = 20;
				item.useStyle = 5;        //this is how the item is holded
				item.noMelee = true;
				item.knockBack = 2;       
				item.mana = 3;             //mana use
				item.UseSound = SoundID.Item101;            //this is the sound when you use the item
				item.autoReuse = true;
				item.shoot = mod.ProjectileType("DominionShard"); //this make the item shoot your projectile
				item.shootSpeed = 19f;    //projectile speed when shoot             
            }
			else
            {
				item.damage = 500;                        
				item.magic = true;                     //this make the item do magic damage
				item.useTime = 30;
				item.useAnimation = 30;
				item.useStyle = 5;        //this is how the item is holded
				item.noMelee = true;
				item.knockBack = 10;        
				item.rare = 9;
				item.mana = 21;             //mana use
				item.UseSound = SoundID.Item15;            //this is the sound when you use the item
				item.autoReuse = true;
				item.shoot = mod.ProjectileType("DominionCrystal");  //this make the item shoot your projectile
				item.shootSpeed = 14f; 				
            }
            return base.CanUseItem(player);
        }
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaCrystal, 20);
			recipe.AddIngredient(ItemID.CrystalShard, 100);
			recipe.AddIngredient(ItemID.SoulofLight, 50);
			recipe.AddIngredient(ItemID.LightShard, 20);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.RainbowCrystalStaff, 1);
			recipe.AddIngredient(ItemID.CrystalSerpent, 1);
			recipe.AddIngredient(ItemID.NebulaArcanum, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}