using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items
{
	public class DestroyerDrill : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("A Tooth Drill that is reinforced with Pure Bloodstone" +
			"\n[c/FFAF00:Don't try this at home kids]");
			DisplayName.SetDefault("Destroyer Drill");
		}

		public override void SetDefaults() {
			item.damage = 100;
			item.melee = true;
			item.width = 16;
			item.height = 24;
			item.useTime = 1;
			item.useAnimation = 1;
			item.channel = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.pick = 999999999;
			item.tileBoost += 999999999;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 6;
			item.value = Item.buyPrice(0, 22, 50, 0);
			item.rare = ItemRarityID.Cyan;
			item.UseSound = SoundID.Item23;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Projectiles.DestroyerDrill>();
			item.shootSpeed = 40f;
		}
	}
}