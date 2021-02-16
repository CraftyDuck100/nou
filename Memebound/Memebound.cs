using Memebound.Tiles;
using Memebound.Items;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace Memebound
{
	public class Memebound : Mod
	{
		//public override void Load() {
			//AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ThomasTheDankEngine"), ItemType("ThomasMusicBox"), TileType("ThomasMusicBox"));
		//}
		public override void UpdateMusic(ref int music, ref MusicPriority priority) {
			if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active) {
				return;
			}
			if (Main.LocalPlayer.HasBuff(BuffType("DankEngineMount"))) {
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/ThomasTheDankEngine");
				priority = MusicPriority.Environment;
			}
			if (Main.LocalPlayer.HasBuff(BuffType("TankEngineMount"))) {
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/ThomasTheTankEngine");
				priority = MusicPriority.Environment;
			}

		}
	}
}