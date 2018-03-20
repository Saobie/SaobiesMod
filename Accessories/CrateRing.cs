using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class CrateRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Enchanted ring said to give luck when fishing. Made from an unrecognized crystal."
					+ "\nImproves chances of fishing up crates.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 35, 0, 0);
			item.rare = 3;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(BuffID.Crate, 2);
		}
	}
}