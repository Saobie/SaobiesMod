using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Weapons
{
	public class DevouringBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Sword made from parts of a horrible monster. Seems as though its still alive. Hungry.");	//The (English) text shown below your weapon's name
		}

		public override void SetDefaults()
		{
			item.damage = 80;			//The damage of your weapon
			item.melee = true;			//Is your weapon a melee weapon?
			item.width = 40;			//Weapon's texture's width
			item.height = 40;			//Weapon's texture's height
			item.useTime = 30;			//The time span of using the weapon. Remember in terraria, 60 frames is a second.
			item.useAnimation = 30;			//The time span of the using animation of the weapon, suggest set it the same as useTime.
			item.useStyle = 1;			//The use style of weapon, 1 for swinging, 2 for drinking, 3 act like shortsword, 4 for use like life crystal, 5 for use staffs or guns
			item.knockBack = 6;			//The force of knockback of the weapon. Maximum is 20
			item.value = Item.buyPrice(0, 12, 45, 80);
			item.rare = 3;				//The rarity of the weapon, from -1 to 13
			
			item.UseSound = SoundID.Item1;		//The sound when the weapon is using
			item.autoReuse = true;			//Whether the weapon can use automatically by pressing mousebutton
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 6);
			recipe.AddIngredient(mod, "HorribleClump", 5);
			recipe.AddIngredient(mod, "GhastlyHeart", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorrificTooth", 6);
			recipe.AddIngredient(mod, "HorribleClump", 5);
			recipe.AddIngredient(mod, "GhastlyHeart", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(3) == 0)
			{
				//Emit dusts when swing the sword
				Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, 6);
				item.shoot = ProjectileID.BallofFire;
				item.shootSpeed = 12f;
			}
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add Onfire buff to the NPC for 1 second
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 300);	
			target.AddBuff(BuffID.Ichor, 60);
			player.statLife += 5; 
			player.HealEffect(5);
			
		/*	if (Main.rand.Next(5) == 0)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, ProjectileID.Flamelash, damage, Main.myPlayer);    
			}  */
		}
	}
}
