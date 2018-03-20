using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class GhastlyChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			Tooltip.SetDefault("Chestplate made from parts of a horrible monster. You feel insatiable bloodlust."
				+ "\nImmunity to 'On Fire!', Cursed Inferno and Ichor"
                + "\nGreatly improve life regen"
				+ "\nPermanent Thorns buff."
                + "\nIncreases monster spawn rate");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 6, 0, 0);
			item.rare = 3;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Ichor] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
			player.AddBuff(BuffID.WaterCandle, 2);
			player.AddBuff(BuffID.Thorns, 2);
            player.lifeRegen += 5;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 5);
			recipe.AddIngredient(mod, "HorrificTooth", 3);
			recipe.AddIngredient(mod, "GhastlyHeart", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 5);
			recipe.AddIngredient(mod, "HorrificTooth", 3);
			recipe.AddIngredient(mod, "GhastlyHeart", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}