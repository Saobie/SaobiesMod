using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class StarcrasherAegis : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("I will endure the darkness, for it shows me the stars."
				+ "\nGreatly improved mana regen."
				+ "\n+10% magic crit."
				+ "\n+50 max mana."
				+ "\n-5% mana cost."
				+ "\nEmits blue light."
				+ "\nPermanent Titan and Thorns buff."
				+ "\nStars rain down when you are hit."
				+ "\nHeals mana when you are hit."
				+ "\nKnockback and lava immunity.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(1, 20, 0, 0);
			item.rare = 9;
			item.defense = 34;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.noKnockback = true;
			player.manaRegen += 4;
			player.manaCost -= 0.05f;
			player.magicCrit += 10;
			player.starCloak = true;
			player.magicCuffs = true;
			player.AddBuff(BuffID.Thorns, 2);
			player.AddBuff(BuffID.Titan, 2);
			Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.1f, 0.1f, 0.5f);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 12);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.MagicCuffs, 1);
			recipe.AddIngredient(ItemID.StarCloak, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}