using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class PlexiciteGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Greaves made from Plexicite, a glass-like metal. Augments magical synergy."
				+ "\n+20 max mana."
				+ "\nSlightly improved mana regen");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 8, 0, 0);
			item.rare = 3;
			item.alpha = 100;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.manaRegen += 1;
			player.statManaMax2 += 20;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}