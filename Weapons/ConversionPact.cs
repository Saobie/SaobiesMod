using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class ConversionPact : ModItem
    {
		public override void SetStaticDefaults()
		{
				Tooltip.SetDefault("Spell tome converts stats between each other."
							+ "\nPrimary use converts 75hp into 200mp, and applies Iron Skin for 1 minute."
							+ "\nSecondary use converts 200mp into 150hp, and applies Potion Sickness and Magic Power for 1 minute."
							+ "\nSecondary use has a 1 minute reuse delay. Primary use has no reuse delay.");
		}
							
        public override void SetDefaults()
        {
            item.damage = 0;
            item.magic = true;
			item.noMelee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 6;
            item.value = Item.buyPrice(0, 50, 0, 0);
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.useTurn = true;
 
 
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
 
        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)     //2 is right click
            {
 
                item.useTime = 20;
                item.useAnimation = 20;
                item.damage = 0;
                item.UseSound = SoundID.Item4;
				item.reuseDelay = 3600;
 
                if (player.statMana >= 200)             //when the player has 35+ mana he can use this item
                {
                    player.statMana -= 200;                //when you use the item use 35 mana
                    player.statLife += 150;                //when tou use the item gives you 35 life
					player.HealEffect(150);
					player.AddBuff(BuffID.MagicPower, 3600);
                }
                else
                {
                    return false;                    //this make that when you have 0 mana you cant use the item
                }
 
 
            }
            else
            {
				item.useTime = 20;
                item.useAnimation = 20;
                item.damage = 0;
                item.UseSound = SoundID.Item9;
 
                if (player.statLife >= 200)             
                {
                    player.statLife -= 75;               
                    player.statMana += 200;   
					player.ManaEffect(200);
					player.AddBuff(BuffID.Ironskin, 3600);
                }
                else
                {
                    return false;                    //this make that when you have 0 mana you cant use the item
                }
            }
            return base.CanUseItem(player);
        }
    }
}