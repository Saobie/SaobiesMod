using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class BloodSiphon : ModItem
    {
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Scepter hand crafted by the Suspicious Person. Its bolts drain the life of those hit, and heals the user.");
			Item.staff[item.type] = true;
		}
        public override void SetDefaults()
        {        
            item.damage = 14;                        
            item.magic = true;                     //this make the item do magic damage
            item.width = 50;
            item.height = 50;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 1;        
            item.value = Item.buyPrice(0, 27, 0, 0);
            item.rare = 3;
            item.mana = 10;             //mana use
            item.UseSound = SoundID.Item60;            //this is the sound when you use the item
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("BloodSiphonProjectile");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
    }
}