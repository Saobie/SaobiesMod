using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{  
    public class FeederheadStaff : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a tiny horrible monster, hungry for more. Now they fight for you.");	//The (English) text shown below your weapon's name
		}
        public override void SetDefaults()
        {

            item.damage = 18;
            item.summon = true;
            item.mana = 10;
            item.width = 45;
            item.height = 45;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = Item.buyPrice(0, 20, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.NPCHit44;
            item.shoot = mod.ProjectileType("FeederheadSummon");
            item.shootSpeed = 7f;
			item.buffTime = 3600;
            item.buffType = mod.BuffType("FeederheadSummonBuff");
        }
		public override void AddRecipes()
		{
		ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 10);
			recipe.AddIngredient(mod, "HorribleClump", 17);
			recipe.AddIngredient(mod, "GhastlyHeart", 2);
			recipe.AddIngredient(ItemID.RottenChunk, 32);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 10);
			recipe.AddIngredient(mod, "HorribleClump", 17);
			recipe.AddIngredient(mod, "GhastlyHeart", 2);
			recipe.AddIngredient(ItemID.Vertebrae, 32);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}