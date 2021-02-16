using Terraria;
using Terraria.ModLoader;

namespace Memebound.Buffs
{
	public class DankEngineMount : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Dank Engine");
			Description.SetDefault("Speed, I am Thomas");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.mount.SetMount(ModContent.MountType<Mounts.DankEngine>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}
