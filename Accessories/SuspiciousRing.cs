using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{	
	public class SuspiciousRing : ModItem
	{
		int BuffTimer = 0;		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Ring sold by the Suspicious Person. He claims the ring may curse or bless you at random."
					+ "\nProvides a random effect, positive or negative, every 1 minute for 30 seconds");
		}
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 35, 0, 0);
			item.rare = 3;
			item.accessory = true;
			BuffTimer = 0;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if(++ BuffTimer % 3600 == 0 && player.whoAmI == Main.myPlayer) 
			{ 
				int[] buffChoices = { BuffID.OnFire, BuffID.Poisoned, BuffID.Bleeding, BuffID.Lifeforce, BuffID.Rage, BuffID.Regeneration, BuffID.CursedInferno, BuffID.Archery, BuffID.MagicPower, BuffID.Thorns, BuffID.Frostburn, BuffID.Cursed, BuffID.Blackout, BuffID.Darkness, BuffID.AmmoReservation, BuffID.Battle, BuffID.Calm, BuffID.Dangersense, BuffID.Endurance, BuffID.Hunter, BuffID.Ichor, BuffID.Swiftness, BuffID.Slow, BuffID.Ironskin, BuffID.Wrath, BuffID.Confused};
				player.AddBuff(buffChoices[Main.rand.Next(buffChoices.Length)], 1800, false);
				BuffTimer = 0;
			}
		}
	}
}