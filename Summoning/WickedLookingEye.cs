using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Summoning
{
	public class WickedLookingEye : ModItem
	{
		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Summon item given by the Demonologist. Whats so wicked about it?"
				+ "\nSummons The Eye Of Cthulu");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 2;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.consumable = true;
		}
	/*	public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPC(mod.NPCType("TheMaw"));
		}  */
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.ServantofCthulhu);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DemonEye);
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
		
			return true;
		}
	}
}