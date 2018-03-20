using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{  
    public class ProbeRod : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons laser firing probes to aid you.");	//The (English) text shown below your weapon's name
		}
        public override void SetDefaults()
        {

            item.damage = 28;
            item.summon = true;
            item.mana = 10;
            item.width = 45;
            item.height = 45;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 35, 0, 0);
            item.rare = 5;
            item.UseSound = SoundID.NPCHit44;
            item.shoot = mod.ProjectileType("ProbeSummon");
            item.shootSpeed = 7f;
			item.buffTime = 3600;
            item.buffType = mod.BuffType("ProbeSummonBuff");
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.HallowedBar, 35);
			recipe.AddIngredient(ItemID.IronBar, 25);
			recipe.AddIngredient(ItemID.MechanicalBatteryPiece, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddIngredient(ItemID.SoulofNight, 15);
			recipe.AddIngredient(ItemID.HallowedBar, 35);
			recipe.AddIngredient(ItemID.LeadBar, 25);
			recipe.AddIngredient(ItemID.MechanicalBatteryPiece, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}