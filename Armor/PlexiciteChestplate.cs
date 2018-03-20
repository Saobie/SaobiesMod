using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PlexiciteChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("Armor made from Plexicite, a glass-like metal. Augments magical synergy."
				+ "\nSlightly improve mana regen."
				+ "\n+6% minion and magic damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.rare = 3;
			item.alpha = 100;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.minionDamage += 0.06f;
			player.magicDamage += 0.06f;
			player.manaRegen += 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PlexiciteBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}