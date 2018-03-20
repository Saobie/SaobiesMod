using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{	
	public class SuperiorSuspiciousRing : ModItem
	{
		int BuffTimer = 0;		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Now enhansed gem with soul powers. Provides superior blessings and for longer."
					+ "\nProvides a random positive effect every 3 minutes for 3 minutes");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 50, 0, 0);
			item.rare = 6;
			item.accessory = true;
			BuffTimer = 0;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if(++ BuffTimer % 10800 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.Lifeforce, BuffID.Inferno, BuffID.NebulaUpDmg1, BuffID.NebulaUpLife1, BuffID.NebulaUpMana1, BuffID.ManaRegeneration, BuffID.Summoning, BuffID.Rage, BuffID.Regeneration, BuffID.Archery, BuffID.MagicPower, BuffID.Thorns, BuffID.AmmoReservation, BuffID.Battle, BuffID.Calm, BuffID.Dangersense, BuffID.Endurance, BuffID.Hunter, BuffID.Swiftness, BuffID.Ironskin, BuffID.Wrath};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 10800, false);
				BuffTimer = 0;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PureSuspiciousRing", 1);
			recipe.AddIngredient(ItemID.SoulofSight, 20);
			recipe.AddIngredient(ItemID.SoulofFright, 20);
			recipe.AddIngredient(ItemID.SoulofMight, 20);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}