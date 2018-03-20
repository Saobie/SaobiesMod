using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class SpelunkerRing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Special ring made from what looks like gold and ruby."
					+ "\nHighlights nearby treasure");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 15, 0, 0);
			item.rare = 3;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(BuffID.Spelunker, 2);
		}
	}
}