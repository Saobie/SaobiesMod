using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Weapons
{
	public class RitualDagger : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Apparently used for blood sacrifices a long time ago."
					+ "\nFormer property of a long forgotten paladin."
					+ "\nHeals 15 hp when hitting enemies."
					+ "\nConfused enemies.");
		}

		public override void SetDefaults()
		{
			item.damage = 250;			
			item.melee = true;			
			item.width = 40;			
			item.height = 40;			
			item.useTime = 10;			
			item.useAnimation = 10;			
			item.useStyle = 3;			
			item.knockBack = 6;			
			item.value = Item.buyPrice(0, 15, 45, 80);
			item.rare = 7;				
			item.UseSound = SoundID.Item1;		
			item.autoReuse = true;			
		}
        public override void ModifyHitNPC(Player player, NPC target, ref int damage, ref float knockBack, ref bool crit)
        {
            base.ModifyHitNPC(player, target, ref damage, ref knockBack, ref crit);
			damage += target.defense / 2;
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Confused, 180);
			player.statLife += 15; 
			player.HealEffect(15);
			
			if (target.type == NPCID.Paladin) 
			{
				if (SaobiesModWorld.downedMoonLord) 
				{
					if (target.life <= 0)
					{ 
						if (Main.rand.Next(4) == 0)							
							{
							NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("WrithingNightmare"));
							Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
							Main.NewText("The nightmare has begun.");
							}
					}
				}
			}
		}
	}
}
