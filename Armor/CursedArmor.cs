using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CursedArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("Armor made from metal wrought with evil and despair. Should you really wear this?"
				+ "\n20% of the damage nearby allies take is applied to you instead."
				+ "\nGreatly improved mana regen."
				+ "\n+3sec flight time."
				+ "\n+15% crit."
				+ "\n+50 max mana and +100 max hp"
				+ "\n-5% mana cost."
				+ "\n40% chance to not consume ammo."
				+ "\nEmits dull red light."
				+ "\nPermanent Titan and Thorns buff."
				+ "\nHeals mana when you are hit."
				+ "\nKnockback and lava immunity.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(1, 20, 0, 0);
			item.rare = 11;
			item.defense = 50;
		}

		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.hasPaladinShield = true;
			player.statLifeMax2 += 100;
			player.noKnockback = true;
			player.manaRegen += 4;
			player.wingTimeMax += 180;
			player.lifeRegen += 4;
			player.manaCost -= 0.05f;
			player.magicCrit += 15;
			player.meleeCrit += 15;
			player.rangedCrit += 15;
			player.thrownCrit += 15;
			player.magicCuffs = true;
			player.AddBuff(BuffID.Thorns, 2);
			player.AddBuff(BuffID.Titan, 2);
			Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.9f, 0.1f, 0.1f);
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
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