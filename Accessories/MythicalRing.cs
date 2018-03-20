using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{	
	public class MythicalRing : ModItem
	{
		int BuffTimer1 = 0;	
		int BuffTimer2 = 0;	
		int BuffTimer3 = 0;	
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The ring reacted to the celestial fragments, almost as if it was always intended to do so"
					+ "\nProvides 3 buffs, one low tier, one mid tier, one high tier"
					+ "\nLow tier buff applied every 5 minutes for 5 minutes"
					+ "\nMid tier buff applied every 3 minutes for 3 minutes"
					+ "\nHigh tier buff applied every minute for 1 minute"
					+ "\nAlso provides the effects of the Fused and Crate rings");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 60, 0, 0);
			item.rare = 8;
			item.accessory = true;
			BuffTimer1 = 0;
			BuffTimer2 = 0;
			BuffTimer3 = 0;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.AddBuff(BuffID.Spelunker, 2);
			player.AddBuff(BuffID.Dangersense, 2);
			player.AddBuff(BuffID.Hunter, 2);
			player.AddBuff(BuffID.Shine, 2);
			player.AddBuff(BuffID.Mining, 2);
			player.AddBuff(BuffID.Crate, 2);
			
			if(++ BuffTimer1 % 18000 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.Inferno, BuffID.Battle, BuffID.Calm, BuffID.ObsidianSkin, BuffID.Ironskin, BuffID.Thorns, BuffID.Gills, BuffID.Invisibility, BuffID.Heartreach, BuffID.WeaponImbueFire, BuffID.WeaponImbuePoison, BuffID.WeaponImbueCursedFlames, BuffID.HeartLamp, BuffID.AmmoBox, BuffID.BeetleMight1, BuffID.BeetleEndurance1, BuffID.Mining, BuffID.Sunflower, BuffID.Bewitched, BuffID.NebulaUpMana1, BuffID.NebulaUpDmg1, BuffID.NebulaUpLife1};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 18000, false);
				BuffTimer1 = 0;
			}
			if(++ BuffTimer2 % 10800 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.AmmoReservation, BuffID.Regeneration, BuffID.ManaRegeneration, BuffID.MagicPower, BuffID.Archery, BuffID.WellFed, BuffID.Clairvoyance, BuffID.Summoning, BuffID.Warmth, BuffID.Honey, BuffID.Panic, BuffID.WeaponImbueIchor, BuffID.WeaponImbueVenom, BuffID.WeaponImbueGold, BuffID.BeetleMight2, BuffID.BeetleEndurance2, BuffID.Titan, BuffID.Lifeforce, BuffID.Endurance, BuffID.Rage, BuffID.Wrath, BuffID.StarInBottle, BuffID.Sharpened, BuffID.DryadsWard, BuffID.NebulaUpMana2, BuffID.NebulaUpDmg2, BuffID.NebulaUpLife2};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 10800, false);
				BuffTimer2 = 0;
			}
			if(++ BuffTimer3 % 3600 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = {BuffID.RapidHealing, BuffID.ShadowDodge, BuffID.IceBarrier, BuffID.WeaponImbueNanites, BuffID.BeetleMight3, BuffID.BeetleEndurance3, BuffID.NebulaUpMana3, BuffID.NebulaUpDmg3, BuffID.NebulaUpLife3, BuffID.ParryDamageBuff, BuffID.SolarShield3};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 3600, false);
				BuffTimer3 = 0;
			}
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SuperiorSuspiciousRing", 1);
			recipe.AddIngredient(mod, "PlexiciteRing", 1);
			recipe.AddIngredient(mod, "CrateRing", 1);
			recipe.AddIngredient(mod, "PolytithriteRing", 1);
			recipe.AddIngredient(mod, "FusedRing", 1);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}