using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Accessories
{
	
	public class GhastlyGaze : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Eyeball of a horrible monster. Seems to still seek out its next prey..."
					+ "\n+10% damage and crit."
					+ "\nGreatly improved life regen."
					+ "\n+20 max hp.");
				//	+ "\nLifesteal on hit");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.buyPrice(0, 18, 0, 0);
			item.rare = 10;
			item.expert = true;
			item.accessory = true;
		}
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeCrit += 10;
			player.meleeDamage += 1f;
			player.magicCrit += 10;
			player.magicDamage += 1f;
			player.rangedCrit += 10;
			player.rangedDamage += 1f;
			player.thrownCrit += 10;
			player.thrownDamage += 1f;
			player.minionDamage += 1f;
			player.lifeRegen += 5;
			player.statLifeMax2 += 20;
		//	player.GetModPlayer<ModPlayerClass>().GhastlyEyeball = true;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)  //This is called when the player attacks an NPC
			{
				player.statLife += 5; //any effect goes here, this gives the player 5 life upon attack of any NPC
				player.HealEffect(5);
			}
	}
}