using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class GhastlyGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Greaves made from parts of a horrible monster. The thrill of the chase seeps within you."
				+ "\n20% increased movement speed."
				+ "\nImproved life regen."
				+ "\nKnockback immunity.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = Item.buyPrice(0, 6, 0, 0);
			item.rare = 3;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxRunSpeed += 0.2f;
			player.noKnockback = true;
            player.lifeRegen += 3;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 8);
			recipe.AddIngredient(mod, "HorrificTooth", 3);
			recipe.AddIngredient(ItemID.Vertebrae, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 8);
			recipe.AddIngredient(mod, "HorrificTooth", 3);
			recipe.AddIngredient(ItemID.RottenChunk, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
	}
}