using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class HorribleMaggot : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Maggot found in the body of a horrible monster."
					+ "\nCareful not to let it too close to any orifices...");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 18, 0, 0);
			item.rare = 10;
			item.expert = true;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if(player.HasItem(mod.ItemType("EvolutionWorm")))
			{
				player.AddBuff(mod.BuffType("Symbiosis"), 2);
			}
			else
				
			player.statLifeMax2 = 100;
		}
	}
}