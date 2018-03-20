using Terraria;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class BeginnersGuideToMagicAndMayhem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Introductory book for those seeking to delve into the world of magic. Offers good pointers for newbies."
					+ "\nThis book was checked out by someone specifc, only they can use it."
					+ "\n+10% magic and minion damage. +1 max minions. +20 max mana");
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
			if (player.name == "Creepy Larry")
			{
				player.magicDamage += 0.1f;
				player.minionDamage += 0.1f;
				player.maxMinions += 1;
				player.statManaMax2 += 20;
			}
			if (player.name == "Alice")
			{
				player.magicDamage += 0.1f;
				player.statManaMax2 += 20;
				player.minionDamage += 0.1f;
				player.maxMinions += 1;
			}
			if (player.name == "Very Black Larry")
			{
				player.magicDamage += 0.1f;
				player.statManaMax2 += 20;
				player.minionDamage += 0.1f;
				player.maxMinions += 1;
			}
		}
	}
}