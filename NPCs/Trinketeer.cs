using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ID;
using Terraria;
using Terraria.ModLoader;
 
namespace SaobiesMod.NPCs            //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadHead]
    public class Trinketeer : ModNPC
    {
     public override string Texture
		{
			get
			{
				return "SaobiesMod/NPCs/Trinketeer";
			}
		}
		public override bool Autoload(ref string name)
		{
			name = "Trinketeer";
			return mod.Properties.Autoload;
		}
        public override void SetDefaults()
        {
            npc.townNPC = true; //This defines if the npc is a town Npc or not
            npc.friendly = true;  //this defines if the npc can hur you or not()
            npc.width = 18; //the npc sprite width
            npc.height = 46;  //the npc sprite height
            npc.aiStyle = 7; //this is the npc ai style, 7 is Pasive Ai
            npc.defense = 25;  //the npc defense
            npc.lifeMax = 250;// the npc life
            npc.HitSound = SoundID.NPCHit1;  //the npc sound when is hit
            npc.DeathSound = SoundID.NPCDeath1;  //the npc sound when he dies
            npc.knockBackResist = 0.5f;  //the npc knockback resistance
            Main.npcFrameCount[npc.type] = 25; //this defines how many frames the npc sprite sheet has
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 150; //this defines the npc danger detect range
            NPCID.Sets.AttackType[npc.type] = 3; //this is the attack type,  0 (throwing), 1 (shooting), or 2 (magic). 3 (melee)
            NPCID.Sets.AttackTime[npc.type] = 30; //this defines the npc attack speed
            NPCID.Sets.AttackAverageChance[npc.type] = 10;//this defines the npc atack chance
            NPCID.Sets.HatOffsetY[npc.type] = 4; //this defines the party hat position
            animationType = NPCID.Guide;  //this copy the guide animation
        }
        public override bool CanTownNPCSpawn(int numTownNPCs, int money) //Whether or not the conditions have been met for this town NPC to be able to move into town.
        {
            if (NPC.downedBoss3)  //so after the EoC is killed
            {
                return true;
            }
            return false;
        }
        public override bool CheckConditions(int left, int right, int top, int bottom)    //Allows you to define special conditions required for this town NPC's house
        {
            return true;  //so when a house is available the npc will  spawn
        }
        public override string TownNPCName()     //Allows you to give this town NPC any name when it spawns
        {
            switch (WorldGen.genRand.Next(2))
            {
                case 0:
                    return "Genis";
                case 1:
                    return "Genis";
                default:
                    return "Genis";
            }
        }
 
        public override void SetChatButtons(ref string button, ref string button2)  //Allows you to set the text for the buttons that appear on this town NPC's chat window.
        {
            button = "Browse Trinkets";   //this defines the buy button name
        }
        public override void OnChatButtonClicked(bool firstButton, ref bool openShop) //Allows you to make something happen whenever a button is clicked on this town NPC's chat window. The firstButton parameter tells whether the first button or second button (button and button2 from SetChatButtons) was clicked. Set the shop parameter to true to open this NPC's shop.
        {
 
            if (firstButton)
            {
                openShop = true;   //so when you click on buy button opens the shop
            }
        }
 
        public override void SetupShop(Chest shop, ref int nextSlot)       //Allows you to add items to this town NPC's shop. Add an item by setting the defaults of shop.item[nextSlot] then incrementing nextSlot.
        {
            if (NPC.downedSlimeKing)   //this make so when the king slime is killed the town npc will sell this
            {
                shop.item[nextSlot].SetDefaults(ItemID.DPSMeter);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.LifeformAnalyzer);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.Compass);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.DepthMeter);
				nextSlot++;  
				shop.item[nextSlot].SetDefaults(ItemID.ManaRegenerationBand);
				nextSlot++;
            }
			if (NPC.downedQueenBee)
			{
				shop.item[nextSlot].SetDefaults(ItemID.LavaCharm);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.SharkronBalloon);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.ObsidianRose);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.Stopwatch);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.NaturesGift);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.Bezoar);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.FeralClaws);
                nextSlot++;
			}
			if (NPC.downedGoblins)
			{	
				shop.item[nextSlot].SetDefaults(ItemID.MetalDetector);
                nextSlot++;	
				shop.item[nextSlot].SetDefaults(ItemID.TallyCounter);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.LuckyCoin);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("PlexiciteRing"));  //this is an example of how to add a modded item
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("SyntheticWings"));  //this is an example of how to add a modded item
				nextSlot++;
			}
			if (NPC.downedPlantBoss)
			{	
				shop.item[nextSlot].SetDefaults(ItemID.PaladinsShield);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.TatteredFairyWings);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.PygmyNecklace);
                nextSlot++;
			}
            if (NPC.downedGolemBoss)
            {
                shop.item[nextSlot].SetDefaults(ItemID.NecromanticScroll);
                nextSlot++;
            }
            if (NPC.downedMechBossAny)
			{
				shop.item[nextSlot].SetDefaults(ItemID.MagicQuiver);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.MoonStone);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.PowerGlove);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("GhastlyGaze"));  //this is an example of how to add a modded item
				nextSlot++;
			}
			if (NPC.downedMechBoss1)
			{
				shop.item[nextSlot].SetDefaults(ItemID.StarVeil);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.TitanGlove);
                nextSlot++;
			}
			if (NPC.downedMechBoss2)
			{
				shop.item[nextSlot].SetDefaults(ItemID.PhilosophersStone);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.FireGauntlet);
                nextSlot++;
			}
			if (NPC.downedMechBoss3)
			{
				shop.item[nextSlot].SetDefaults(ItemID.MagmaStone);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.SunStone);
                nextSlot++;
				shop.item[nextSlot].SetDefaults(ItemID.AvengerEmblem);
                nextSlot++;
			}
            shop.item[nextSlot].SetDefaults(ItemID.Shackle);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Aglet);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("GoodLuckBrooch"));  //this is an example of how to add a modded item
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.AnkletoftheWind);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.HermesBoots);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.WaterWalkingBoots);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.IceSkates);
            nextSlot++;
			shop.item[nextSlot].SetDefaults(ItemID.Radar);
            nextSlot++;
 
        }
 
        public override string GetChat()       //Allows you to give this town NPC a chat message when a player talks to it.
        {
         /*   int wizardNPC = NPC.FindFirstNPC(NPCID.Wizard);   //this make so when this npc is close to Wizard
            if (wizardNPC >= 0 && Main.rand.Next(4) == 0)    //has 1 in 3 chance to show this message
            {
                return "Yes " + Main.npc[wizardNPC].displayName + " is a wizard.";
            }
            int guideNPC = NPC.FindFirstNPC(NPCID.Guide); //this make so when this npc is close to the Guide
            if (guideNPC >= 0 && Main.rand.Next(4) == 0) //has 1 in 3 chance to show this message
            {
                return "Sure you can ask " + Main.npc[guideNPC].displayName + " how to make Ironskin potion or you can buy it from me..hehehe.";
            }   */
            switch (Main.rand.Next(7))    //this are the messages when you talk to the npc
            {
                case 0:
                    return "Pumpkin Head? Very original.";
                case 1:
                    return "Dont bother trying to remove the pumpkin.";
                case 2:
                    return "Any of these shinies interest you?";
                case 3:
                    return "Getting this stuff whats easy, i'll have you know.";
				case 4:
                    return "Maybe you should wear a pumpkin too...";
				case 5:
                    return "Only the best trinkets!";
				case 6:
                    return "I only sell the good stuff!";
                default:
                    return "Stop asking about my pumpkin!";
 
            }
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)//  Allows you to determine the damage and knockback of this town NPC attack
        {
            damage = 40;  //npc damage
            knockback = 2f;   //npc knockback
        }
 
        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)  //Allows you to determine the cooldown between each of this town NPC's attack. The cooldown will be a number greater than or equal to the first parameter, and less then the sum of the two parameters.
        {
            cooldown = 5;
            randExtraCooldown = 10;
        }
        //------------------------------------This is an example of how to make the npc use a sward attack-------------------------------
        public override void DrawTownAttackSwing(ref Texture2D item, ref int itemSize, ref float scale, ref Vector2 offset)//Allows you to customize how this town NPC's weapon is drawn when this NPC is swinging it (this NPC must have an attack type of 3). Item is the Texture2D instance of the item to be drawn (use Main.itemTexture[id of item]), itemSize is the width and height of the item's hitbox
        {
            scale = 1f;
            item = Main.itemTexture[mod.ItemType("DevouringBlade")]; //this defines the item that this npc will use
            itemSize = 56;
        }
 
        public override void TownNPCAttackSwing(ref int itemWidth, ref int itemHeight) //  Allows you to determine the width and height of the item this town NPC swings when it attacks, which controls the range of this NPC's swung weapon.
        {
            itemWidth = 56;
            itemHeight = 56;
        }
 
        //----------------------------------This is an example of how to make the npc use a gun and a projectile ----------------------------------
        public override void DrawTownAttackGun(ref float scale, ref int item, ref int closeness) //Allows you to customize how this town NPC's weapon is drawn when this NPC is shooting (this NPC must have an attack type of 1). Scale is a multiplier for the item's drawing size, item is the ID of the item to be drawn, and closeness is how close the item should be drawn to the NPC.
          {
              scale = 1f;
              item = mod.ItemType("StyngerBoltTome");  
              closeness = 20;
          }
          public override void TownNPCAttackProj(ref int projType, ref int attackDelay)//Allows you to determine the projectile type of this town NPC's attack, and how long it takes for the projectile to actually appear
          {
              projType = ProjectileID.Stynger;
              attackDelay = 1;
          }
 
          public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)//Allows you to determine the speed at which this town NPC throws a projectile when it attacks. Multiplier is the speed of the projectile, gravityCorrection is how much extra the projectile gets thrown upwards, and randomOffset allows you to randomize the projectile's velocity in a square centered around the original velocity
          {
              multiplier = 7f;
             // randomOffset = 4f;
 
          }   
 
    }
}