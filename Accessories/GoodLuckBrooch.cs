using Terraria;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class GoodLuckBrooch : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Pendant given to those set on a long adventure. Runic symbols are carved into it, said to give good luck"
					+ "\nUnextrordinary to the common person. But perhaps in the right hands...");
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
				player.statLifeMax2 += 20;
				player.lifeRegen += 3;
				player.moveSpeed += 10f;
		}
	}
}