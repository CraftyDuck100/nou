using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items.Weapons
{
	internal class MikeBruhzowski : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Mike Bruhzowski");
			Tooltip.SetDefault("A Mike Wazowski bomb"
			+ $"\n[i:{ModContent.ItemType<MikeBruhzowski>()}]");
			ItemID.Sets.ItemsThatCountAsBombsForDemolitionistToSpawn[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.shootSpeed = 12f;
			item.shoot = ModContent.ProjectileType<Projectiles.MikeBruhzowski>();
			item.width = 64;
			item.height = 64;
			item.maxStack = 1;
			item.consumable = false;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 40;
			item.useTime = 40;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = ItemRarityID.Blue;
		}
	}
}
