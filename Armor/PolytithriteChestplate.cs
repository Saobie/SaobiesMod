using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PolytithriteChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("Expertly forged armor from refined Polytithrite. ASeems to guide your attacks to enemy weak spots."
				+ "\nGreatly improved mana regen."
				+ "\nPermanent Titan and Yhorns buff."
				+ "\nKnockback immunity.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 29, 0, 0);
			item.rare = 8;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{
			player.noKnockback = true;
			player.manaRegen += 4;
			player.AddBuff(BuffID.Thorns, 2);
			player.AddBuff(BuffID.Titan, 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteBar", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}