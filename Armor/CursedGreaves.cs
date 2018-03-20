using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CursedGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Greaves made from metal wrought with evil and despair. Should you really wear this?."
				+ "\nGreatly increased mana regen and movement speed."
				+ "\nFall damage immunity."
				+ "\nEmits dull red light."
				+ "\n-5% mana cost.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(3, 20, 0, 0);
			item.rare = 9;
			item.defense = 35;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.3f;
			player.manaRegen += 6;
			player.manaRegenBonus += 6;
			player.manaCost -= 0.05f;
			player.maxRunSpeed += 0.3f;
			player.noFallDmg = true;
			Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.9f, 0.1f, 0.1f);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CursedMetal", 12);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}