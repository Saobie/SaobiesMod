using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace SaobiesMod.Items.Weapons
{
    public class StarLash : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Tome that summons cosmic tentacles to lash at foes."
            +"\nStars shoot out when hitting an enemy."
			 +"\nConsumes 3 Summoner Stones."
           + "\nSaps mana from foes.");
        }
        public override void SetDefaults()
        {        
            item.damage = 225;                        
            item.summon = true;                     //this make the item do magic damage
            item.width = 24;
            item.height = 28;
            item.useTime = 10;
            item.useAnimation = 30;
            item.useStyle = 5;        //this is how the item is holded
            item.noMelee = true;
            item.knockBack = 2;        
            item.value = Item.buyPrice(1, 12, 45, 80);
            item.rare = 2;
            item.mana = 9;             //mana use
            item.UseSound = SoundID.Item117;            //this is the sound when you use the item
            item.autoReuse = true;
			item.useAmmo = mod.ItemType("SummonerStone");
            item.shoot = mod.ProjectileType("StarLashProjectile");  //this make the item shoot your projectile
            item.shootSpeed = 12f;    //projectile speed when shoot
        }   
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
          {
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            Vector2 velocity = new Vector2(speedX, speedY).SafeNormalize(-Vector2.UnitY);
            Vector2 randomVel = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101)).SafeNormalize(-Vector2.UnitY);
            velocity = (velocity * 4f + randomVel).SafeNormalize(-Vector2.UnitY) * item.shootSpeed;
            float randAi0 = Main.rand.Next(10, 80) * 0.001f;
            if (Main.rand.Next(2) == 0)
            {
                randAi0 *= -1f;
            }
            float randAi1 = Main.rand.Next(10, 80) * 0.001f;
            if (Main.rand.Next(2) == 0)
            {
                randAi1 *= -1f;
            }
            Projectile.NewProjectile(position, velocity, type, damage, knockBack, player.whoAmI, randAi0, randAi1);
            return false;
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "StarBar", 12);
			recipe.AddIngredient(ItemID.LunarBar, 10);
			recipe.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
			recipe.AddIngredient(ItemID.SpellTome, 1);
			recipe.AddIngredient(ItemID.ManaCrystal, 3);
			recipe.AddIngredient(ItemID.FragmentNebula, 20);
			recipe.AddIngredient(ItemID.FragmentStardust, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}  
    }
}