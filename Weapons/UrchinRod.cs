using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{  
    public class UrchinRod : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a Land Urchin to aid you.");	//The (English) text shown below your weapon's name
		}
        public override void SetDefaults()
        {

            item.damage = 10;
            item.summon = true;
            item.mana = 10;
            item.width = 45;
            item.height = 45;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = Item.buyPrice(0, 35, 0, 0);
            item.rare = 2;
            item.UseSound = SoundID.NPCDeath15;
            item.shoot = mod.ProjectileType("UrchinSummon");
            item.shootSpeed = 7f;
			item.buffTime = 3600;
            item.buffType = mod.BuffType("UrchinSummonBuff");
        }
    }
}