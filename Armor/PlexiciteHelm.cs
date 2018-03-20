using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PlexiciteHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Helmet made from Plexicite, a glass-like metal. Augments magical synergy."
							+ "\n+4% magic and minion damage."
							+ "\n+50 max mana");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = Item.buyPrice(0, 10, 0, 0);
			item.rare = 3;
			item.alpha = 100;
			item.defense = 8;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.minionDamage += 0.04f;
			player.magicDamage += 0.04f;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("PlexiciteChestplate") && legs.type == mod.ItemType("PlexiciteGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+10% minion and magic damage. +50 max mp. Can turn invisible. +3 minions. Greatly improve mana regen.";
			player.minionDamage += 0.1f;
			player.magicDamage += 0.1f;
			player.shroomiteStealth = true;
			player.statManaMax2 += 50;
			player.maxMinions += 3;
			player.manaRegen += 6;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 
	}
}