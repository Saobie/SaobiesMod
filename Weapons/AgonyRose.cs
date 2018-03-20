using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class AgonyRose : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bathe the earth in flames.");
			Item.staff[item.type] = true;
		}
        public override void SetDefaults()
        {        
            item.damage = 100;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 50;
            item.height = 50;
            item.useTime = 10;
            item.useAnimation = 50;
			item.reuseDelay = 50;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 5;        
            item.value = Item.buyPrice(0, 65, 45, 80);
            item.rare = 8;
            item.mana = 20;             //mana use
            item.UseSound = SoundID.Item73;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = ProjectileID.InfernoFriendlyBolt;  //this make the item shoot your projectile
            item.shootSpeed = 10f;    //projectile speed when shoot
        }   
		public override bool AltFunctionUse(Player player)
        {
            return true;
        }
		public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
                item.damage = 300;                        
				item.magic = true;                     //this make the item do magic damage
				item.useTime = 20;
				item.useAnimation = 20;
				item.useStyle = 5;        //this is how the item is holded
				item.noMelee = true;
				item.knockBack = 2;       
				item.mana = 60;             //mana use
				item.UseSound = SoundID.Item101;            //this is the sound when you use the item
				item.autoReuse = true;
				item.shoot = mod.ProjectileType("AgonyFire"); //this make the item shoot your projectile
				item.shootSpeed = 15f;    //projectile speed when shoot             
            }
			else
            {
				item.damage = 100;                        
				item.magic = true;                     //this make the item do magic damage
				item.useTime = 10;
				item.useAnimation = 50;
				item.reuseDelay = 50;
				item.useStyle = 5;        //this is how the item is holded
				item.noMelee = true;
				item.knockBack = 10;        
				item.mana = 30;             //mana use
				item.UseSound = SoundID.Item73;            //this is the sound when you use the item
				item.autoReuse = true;
				item.shoot = ProjectileID.InfernoFriendlyBolt;  //this make the item shoot your projectile
				item.shootSpeed = 10f; 				
            }
            return base.CanUseItem(player);
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteBar", 8);
			recipe.AddIngredient(mod, "BoilbloomStaff", 1);
			recipe.AddIngredient(ItemID.Flamelash, 1);
			recipe.AddIngredient(ItemID.Obsidian, 100);
			recipe.AddIngredient(ItemID.Fireblossom, 10);
			recipe.AddIngredient(ItemID.Hellstone, 60);
			recipe.AddIngredient(ItemID.ObsidianRose, 1);
			recipe.AddIngredient(ItemID.InfernoFork, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}