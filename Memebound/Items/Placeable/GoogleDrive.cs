using Terraria.ID;
using Terraria.ModLoader;

namespace Memebound.Items.Placeable
{
	public class GoogleDrive : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This will be the first platform you will use to make m e m e s");
		}

		public override void SetDefaults() {
			item.width = 28;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Tiles.GoogleDrive>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}