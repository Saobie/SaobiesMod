using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Summoning
{
	public class WickedWormFood : ModItem
	{
		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Summon item given by the Demonologist. Whats so wicked about it?"
				+ "\nSummons The Eater Of Worlds");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 3, 0, 0);
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
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.EaterofWorldsHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.DevourerHead);
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
		
			return true;
		}
	}
}