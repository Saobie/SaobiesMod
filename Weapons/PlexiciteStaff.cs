using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class PlexiciteStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Infused staff conjures bladed Plexicite discs to launch at foes.");
		}
        public override void SetDefaults()
        {        
            item.damage = 20;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 50;
            item.height = 50;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = Item.buyPrice(0, 8, 45, 80);
            item.rare = 3;
            item.mana = 10;             //mana use
            item.UseSound = SoundID.Item60;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("PlexiDiscProjectile");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 8);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}