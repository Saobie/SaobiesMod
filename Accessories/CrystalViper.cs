using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Accessories
{
    public class CrystalViper : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Viper");
			Tooltip.SetDefault("Parasitic crystal worm. You are its host now."
						+ "\nFunctions as a hook and weapon."
						+ "\nManasteal on hit."
						+ "\nApplies Frostburn to target."
						+ "\nStrengthens with its host.");
		}

		public override void SetDefaults()
		{		
				item.damage = 50;
				item.knockBack = 7f;
				item.useStyle = 5;
				item.width = 18;
				item.autoReuse = true;
				item.height = 28;
				item.UseSound = SoundID.Item101;
				item.useAnimation = 30;
				item.useTime = 30;
				item.rare = 10;
				item.accessory = true;
				item.expert = true;
				item.magic = true;
				item.value = Item.buyPrice(0, 25, 0, 0);
				item.shootSpeed = 18f; // how quickly the hook is shot.
				item.shoot = mod.ProjectileType("CrystalViperProjectile");
		}
	/*	public override void GetWeaponDamage(Player player, ref int damage)
		{
			if (NPC.downedMechBossAny)
			{
				numBoss += 20;
			}
			if (NPC.downedMechBoss1)
			{
				if (NPC.downedMechBoss2)
				{
					if (NPC.downedMechBoss1)
					{
						numBoss += 20;
					}
				}
			}
			if (NPC.downedPlantBoss)
			{
				numBoss += 20;
			}
			if (NPC.downedGolemBoss)
			{
				numBoss += 20;
			}
		}
		public override void GetWeaponKnockback(Player player, ref float knockback)
		{
			if (NPC.downedMechBossAny)
			{
				numBoss += 0.2;
			}
			if (NPC.downedMechBoss1)
			{
				if (NPC.downedMechBoss2)
				{
					if (NPC.downedMechBoss1)
					{
						numBoss += 0.2;
					}
				}
			}
			if (NPC.downedPlantBoss)
			{
				numBoss += 0.2;
			}
			if (NPC.downedGolemBoss)
			{
				numBoss += 0.2;
			}
		}
		public override void GetWeaponCrit(Player player, ref int crit)
		{
			if (NPC.downedMechBossAny)
			{
				numBoss += 2;
			}
			if (NPC.downedMechBoss1)
			{
				if (NPC.downedMechBoss2)
				{
					if (NPC.downedMechBoss1)
					{
						numBoss += 2;
					}
				}
			}
			if (NPC.downedPlantBoss)
			{
				numBoss += 2;
			}
			if (NPC.downedGolemBoss)
			{
				numBoss += 2;
			}
		}		
		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			numBoss++;
		} */
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			player.statLife += 5;
			target.AddBuff(BuffID.Frostburn, 200);	

		}
	}
}