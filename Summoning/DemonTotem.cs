using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Summoning
{
	public class DemonTotem : ModItem
	{
		public override void SetStaticDefaults()
		{
		Tooltip.SetDefault("Totem given by the Demonologist."
				+ "\nSummons a winged demon.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.rare = 10;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = 4;
			item.expert = true;
			item.consumable = true;
		}
	/*	public override bool CanUseItem(Player player)
		{
			return !NPC.AnyNPC(mod.NPCType("TheMaw"));
		}  */
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("WingedDjinn"));
			Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
			
			int choice = Main.rand.Next(3);
			if (choice == 0)
            {
				Main.NewText("Cede your life to me.");
			}
			if (choice == 1)
            {
				Main.NewText("Repent the folly of calling upon me.");
			}
			if (choice == 2)
            {
				Main.NewText("Arrogant human, know your place!");
			}
		
			return true;
		}
	}
}