using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class PolytithriteGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Expertly forged greaves from refined Polytithrite. Seems to guide your attacks to enemy weak spots."
				+ "\nFall damage immunity."
				+ "\nImproved mana regen."
				+ "\n20% increased movement speed.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.rare = 8;
			item.defense = 12;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxRunSpeed += 0.20f;
			player.noFallDmg = true;
			player.manaRegen += 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteBar", 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}