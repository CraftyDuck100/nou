using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;
 
namespace Memebound.Items.Potions
{
     public class PanikBrew : ModItem
    {
        public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Panik Brew");
			Tooltip.SetDefault("Panik");
        }    
		public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                 //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 99;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 30;
            item.value = Item.sellPrice(0, 0, 50, 0);
			item.value = Item.buyPrice(0, 1, 50, 0);
            item.rare = 3;
            item.buffType = 63;           //this is where you put your Buff
            item.buffTime = 36000;    //this is the buff duration        10 = 10 Second
            return;
        }
    }
}
