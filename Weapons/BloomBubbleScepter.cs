using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class BloomBubbleScepter : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Conjures bloody bubbles that release lifestealing orbs when they pop.");
			Item.staff[item.type] = true;
		}
        public override void SetDefaults()
        {        
            item.damage = 25;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 50;
            item.height = 50;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 1;        
            item.value = Item.buyPrice(0, 32, 0, 0);
            item.rare = 4;
            item.mana = 18;             //mana use
            item.UseSound = SoundID.Item85;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BloomBubbleProjectile");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BloodSiphon", 1);
			recipe.AddIngredient(ItemID.CrimsonTigerfish, 6);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddIngredient(ItemID.TissueSample, 30);
			recipe.AddIngredient(ItemID.Vertebrae, 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BloodSiphon", 1);
			recipe.AddIngredient(ItemID.Ebonkoi, 6);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddIngredient(ItemID.ShadowScale, 30);
			recipe.AddIngredient(ItemID.RottenChunk, 18);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}