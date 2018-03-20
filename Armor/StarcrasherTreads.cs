using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class StarcrasherTreads : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Keep your eyes on the stars, and your feet on the ground."
				+ "\nGreatly increased mana regen and movement speed."
				+ "\nFall damage immunity."
				+ "\nEmits blue light."
				+ "\n-5% mana cost."
				+ "\n+1 max sentries."
				+ "\n+50 max mana."
				+ "\n+5% magic damage and crit.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(3, 20, 0, 0);
			item.rare = 9;
			item.defense = 26;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.moveSpeed += 0.3f;
			player.manaRegen += 6;
			player.manaRegenBonus += 6;
			player.manaCost -= 0.05f;
			player.maxTurrets += 1;
			player.maxRunSpeed += 0.3f;
			player.noFallDmg = true;
			player.magicDamage += 0.05f;
			player.magicCrit += 5;
			Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.0f, 0.0f, 0.3f);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 12);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}