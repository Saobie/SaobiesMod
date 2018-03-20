using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class PolytithriteRing : ModItem
	{
		int BuffTimer = 0;	
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ring made of precious polytithrite. Somewhat heavy for its size."
					+ "\nGrants a chance to dodge every 2 minutes seconds, for 45 seconds"
					+ "\n+10% melee speed" 
					+ "\n+15% crit chance, +20 max hp.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 7;
			item.accessory = true;
			BuffTimer = 0;	
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.meleeCrit += 15;
				player.meleeSpeed += 0.1f;
				player.rangedCrit += 15;
				player.magicCrit += 15;
				player.thrownCrit += 15;
				player.statLifeMax2 += 20;
			if(++ BuffTimer % 7200 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.ShadowDodge};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 2700, false);
				BuffTimer = 0;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteBar", 14);
			recipe.AddIngredient(ItemID.Diamond, 4);
			recipe.AddIngredient(ItemID.Sapphire, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}