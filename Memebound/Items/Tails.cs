using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items
{
	public class Tails : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("E");
		}

		public override void SetDefaults() {
			item.width = 32;
			item.height = 32;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}
	}
}