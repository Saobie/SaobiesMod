using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{	
	public class PureSuspiciousRing : ModItem
	{
		int BuffTimer = 0;		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Purified ring, rid of the curse possibility it originally had. Indefinate blessings upon the wearer."
					+ "\nProvides a random positive effect every 2 minutes for 2 minutes");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 40, 0, 0);
			item.rare = 4;
			item.accessory = true;
			BuffTimer = 0;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if(++ BuffTimer % 6400 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.Lifeforce, BuffID.Gravitation, BuffID.Inferno, BuffID.ManaRegeneration, BuffID.ObsidianSkin, BuffID.Summoning, BuffID.Rage, BuffID.Regeneration, BuffID.Archery, BuffID.MagicPower, BuffID.Thorns, BuffID.AmmoReservation, BuffID.Battle, BuffID.Calm, BuffID.Dangersense, BuffID.Endurance, BuffID.Hunter, BuffID.Swiftness, BuffID.Ironskin, BuffID.Wrath};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 6400, false);
				BuffTimer = 0;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SuspiciousRing", 1);
			recipe.AddIngredient(ItemID.PurificationPowder, 50);
			recipe.AddIngredient(ItemID.SoulofLight, 20);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}