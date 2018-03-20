using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PolytithriteHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Expertly forged armor from refined Polytithrite. Seems to guide your attacks to enemy weak spots."
							+ "\nImproved mana regen."
							+ "\n+50 max health and mana");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = Item.buyPrice(0, 20, 0, 0);
			item.rare = 8;
			item.defense = 14;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 50;
			player.statManaMax2 += 50;
			player.manaRegen += 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("PolytithriteChestplate") && legs.type == mod.ItemType("PolytithriteGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+30% Crit chance. +2 max minions. +15% melee speed. Extremely improved hp regen. Immune to various debuffs and lava.";
			player.meleeCrit += 30;
			player.thrownCrit += 30;
			player.rangedCrit += 30;
			player.magicCrit += 30;
			player.meleeSpeed += 1.5f;
			player.lifeRegen += 8;
			player.lavaImmune = true;
			player.maxMinions += 2;
			player.buffImmune[BuffID.Frozen] = true;
			player.buffImmune[BuffID.OnFire] = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Ichor] = true;
			player.buffImmune[BuffID.ManaSickness] = true;
			player.buffImmune[BuffID.CursedInferno] = true;
			player.buffImmune[BuffID.WindPushed] = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PolytithriteBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 
	}
}