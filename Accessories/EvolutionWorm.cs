using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Accessories
{
    public class EvolutionWorm : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Evolution Worm");
			Tooltip.SetDefault("Parasite pulled from the flesh of a horrible monster. It resides in you now."
						+ "\nFunctions as a hook and weapon."
						+ "\nLifesteal on hit."
						+ "\nApplies venom to target."
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
				item.UseSound = SoundID.NPCDeath13;
				item.useAnimation = 30;
				item.useTime = 30;
				item.rare = 10;
				item.accessory = true;
				item.expert = true;
				item.melee = true;
				item.value = Item.buyPrice(0, 25, 0, 0);
				item.shootSpeed = 18f; // how quickly the hook is shot.
				item.shoot = mod.ProjectileType("EvolutionWormProjectile");
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
*	public override void ModifyTooltips(List<TooltipLine> tooltips)
		{
			numBoss++;
		} */
	}
}