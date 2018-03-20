using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class Vilebubble : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Conjure cursed bubbles that replicate themselves."
			+ "\nMain bubble confuses enemies on contact."
			+ "\nSecondary bubbles lifesteal, and leave damaging orbs in their place.");
		}
        public override void SetDefaults()
        {        
            item.damage = 230;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 50;
            item.height = 50;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = Item.buyPrice(2, 8, 45, 80);
            item.rare = 10;
            item.mana = 21;             //mana use
            item.UseSound = SoundID.Item85;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("VilebubbleLarge");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CursedMetal", 9);
			recipe.AddIngredient(mod, "BloomBubbleScepter", 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.SpellTome, 3);
			recipe.AddIngredient(ItemID.Book, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}