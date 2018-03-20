using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class PlexiciteRing : ModItem
	{
		int BuffTimer1 = 0;	
		int BuffTimer2 = 0;	
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ring made of plexicite metal. Strong magical synergy"
					+ "\nApplies Summoning and Mana Regeneration buffs every 2 minutes, for 45 seconds."
					+ "\n+3% magic and minion damage. +6% magic crit.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 3;
			item.accessory = true;
			
			BuffTimer1 = 0;	
			BuffTimer2 = 0;	
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
				player.magicDamage += 0.03f;
				player.minionDamage += 0.03f;
				player.magicCrit += 6;
				
				if(++ BuffTimer1 % 7200 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.Summoning};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 2700, false);
				BuffTimer1 = 0;
			}
			if(++ BuffTimer2 % 7200 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.ManaRegeneration};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 2700, false);
				BuffTimer2 = 0;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 9);
			recipe.AddIngredient(ItemID.Sapphire, 8);
			recipe.AddIngredient(ItemID.Ruby, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}