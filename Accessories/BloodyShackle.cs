using Terraria;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class BloodyShackle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shackle of the imprisoned, rusted with blood. A sense of malice can be felt eminating from it."
					+ "\nSeems to only fit the wrist of Dirty Dan"
					+ "\n+20 health, +5 defense, and +10% attack speed.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.rare = 3;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (player.name == "Dirty Dan")
			{
				player.meleeSpeed += 0.1f;
				player.statLifeMax2 += 20;
				player.statDefense += 5;
			}
		}
	}
}