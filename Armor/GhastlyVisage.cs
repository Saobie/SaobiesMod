using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class GhastlyVisage : ModItem
	{
		int BuffTimer1 = 0;
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Helm made from parts of a horrible monster. Pulsates with visions of the hunt."
							+ "\nPermanent Hunter, Dangersense, and Night Owl buff."
							+ "\n+40 max health."
							+ "\nImproved life regen.");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = Item.buyPrice(0, 6, 0, 0);
			item.rare = 3;
			item.defense = 9;
			
			BuffTimer1 = 0;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 40;
			player.lifeRegen += 3;
			player.AddBuff(BuffID.Dangersense, 2);
			player.AddBuff(BuffID.Hunter, 2);
			player.AddBuff(BuffID.NightOwl, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GhastlyChestplate") && legs.type == mod.ItemType("GhastlyGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+10% crit and damage. +2 max minions. Lava immune.";
			player.meleeDamage += 0.1f;
			player.thrownDamage += 0.1f;
			player.rangedDamage += 0.1f;
			player.magicDamage += 0.1f;
			player.minionDamage += 0.1f;
			player.meleeCrit += 10;
			player.rangedCrit += 10;
			player.magicCrit += 10;
			player.thrownCrit += 10;
			player.lavaImmune = true;
			player.maxMinions += 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 4);
			recipe.AddIngredient(mod, "HorrificTooth", 3);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.Vertebrae, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HorribleClump", 4);
			recipe.AddIngredient(mod, "HorrificTooth", 3);
			recipe.AddIngredient(mod, "FeelerMembrane", 1);
			recipe.AddIngredient(ItemID.RottenChunk, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 
	}
}