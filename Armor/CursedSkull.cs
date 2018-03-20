using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SaobiesMod.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CursedSkull : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Skull whos eyes have seen into the depths of despair. Should you really put this on your head?."
							+ "\nImproved mana and hp regen."
							+ "\nEmits dull red light."
							+ "\n-5% mana cost."
							+ "\n+10% damage."
							+ "\nIncreased invincibility time."
							+ "\nIncreased mana and heart pickup range."
							+ "\n+50 max mana and hp."
							+ "\nThe nightmare never ends.");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 20;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 11;
			item.expert = true;
			item.defense = 40;
		}
		
		public override void UpdateEquip(Player player)
		{
			player.statManaMax2 += 50;
			player.statLifeMax2 += 50;
			player.manaRegen += 3;
			player.longInvince = true;
			player.manaRegenBonus += 3;
			player.lifeRegen += 3;
			player.manaCost -= 0.05f;
			player.minionDamage += 0.1f;
			player.meleeDamage += 0.1f;
			player.magicDamage += 0.1f;
			player.thrownDamage += 0.1f;
			player.rangedDamage += 0.1f;
			player.manaMagnet = true;
			player.lifeMagnet = true;
			Lighting.AddLight((int)(player.Center.X / 16f), (int)(player.Center.Y / 16f), 0.9f, 0.1f, 0.1f);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CursedArmor") && legs.type == mod.ItemType("CursedGreaves");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Immune to mana sickness and desert winds. +15% damage. Automatically uses mana potions when needed. +3 minions and sentries.";
			player.maxMinions += 3;
			player.maxTurrets += 3;
			player.magicDamage += 0.15f;
			player.meleeDamage += 0.15f;
			player.rangedDamage += 0.15f;
			player.minionDamage += 0.15f;
			player.thrownDamage += 0.15f;
			player.manaFlower = true;
			player.buffImmune[BuffID.ManaSickness] = true;
			player.buffImmune[BuffID.WindPushed] = true;
			player.AddBuff(mod.BuffType("LucidNightmare"), 2);
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CursedMetal", 12);
			recipe.AddIngredient(ItemID.ObsidianSkull, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		} 
	}
}