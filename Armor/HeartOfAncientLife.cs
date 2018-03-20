using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class HeartOfAncientLife : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("Life is 10% what happens to you, and 90% how you receive it."
				+ "\n20% of the damage nearby allies take is applied to you instead."
				+ "\nKnockback and lava immunity."
				+ "\n+3sec flight time."
                + "\nPermanent Thorns and Titan buff."
                + "\n+100 max hp."
				+ "\n40% chance to not consume ammo."
				+ "\nImproved life regen.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(1, 30, 0, 0);
			item.rare = 9;
			item.defense = 45;
		}

		public override void UpdateEquip(Player player)
		{
			player.wingTimeMax += 180;
			player.noKnockback = true;
            player.lavaImmune = true;
			player.statLifeMax2 += 100;
			player.lifeRegen += 1;
            player.AddBuff(BuffID.Thorns, 2);
            player.AddBuff(BuffID.Titan, 2);
            player.hasPaladinShield = true;
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .40f;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AncientLifewood", 75);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.LifeFruit, 3);
			recipe.AddIngredient(ItemID.LifeCrystal, 2);
			recipe.AddIngredient(ItemID.PaladinsShield, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}