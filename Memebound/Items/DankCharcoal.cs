using Memebound.Mounts;
using Memebound.Tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items
{
	public class DankCharcoal : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Beware of the Dank Engine"
			+ "\n[c/FF0000:HEADPHONE WARNING]");
			DisplayName.SetDefault("Dank Charcoal");
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
			item.mountType = ModContent.MountType<DankEngine>();
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