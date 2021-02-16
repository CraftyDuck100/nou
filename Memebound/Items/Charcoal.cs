using Memebound.Mounts;
using Memebound.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items
{
	public class Charcoal : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("T H O M A S");
			DisplayName.SetDefault("Charcoal");
		}

		public override void SetDefaults() {
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 30000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = ModContent.MountType<TankEngine>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Tails>(), 10);
			recipe.AddTile(ModContent.TileType<GoogleDrive>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}