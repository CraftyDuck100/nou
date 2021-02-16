using Memebound.Items;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace Memebound
{
	// ModPlayer classes provide a way to attach data to Players and act on that data. ExamplePlayer has a lot of functionality related to 
	// several effects and items in ExampleMod. See SimpleModPlayer for a very simple example of how ModPlayer classes work.
	public class MemePlayer : ModPlayer
	{
		public bool GlobalTeleporter = true;
		public bool GlobalTeleporterUp = true;
		
		public const int maxExampleLifeFruits = 10;
		public int exampleLifeFruits;

		public bool ZoneExample;

		public override void ResetEffects() {
			player.statLifeMax2 += exampleLifeFruits * 2;
			GlobalTeleporter = true;
			GlobalTeleporterUp = true;
		}
		public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
			ModPacket packet = mod.GetPacket();
			packet.Write((byte)player.whoAmI);
			packet.Write(exampleLifeFruits);
			packet.Send(toWho, fromWho);
		}
		public override TagCompound Save() {
			return new TagCompound {
				{"exampleLifeFruits", exampleLifeFruits},
			};
		}

		public override void Load(TagCompound tag) {
			exampleLifeFruits = tag.GetInt("exampleLifeFruits");
		}
		public override void ProcessTriggers(TriggersSet triggersSet) {
			if (GlobalTeleporterUp && Main.mapFullscreen == true && Main.mouseRight && Main.keyState.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.LeftControl))
			{
				int mapWidth = Main.maxTilesX * 16;
				int mapHeight = Main.maxTilesY * 16;
				Vector2 cursorPosition = new Vector2(Main.mouseX, Main.mouseY);
				
				cursorPosition.X -= Main.screenWidth / 2;
				cursorPosition.Y -= Main.screenHeight / 2;

				Vector2 mapPosition = Main.mapFullscreenPos;
				Vector2 cursorWorldPosition = mapPosition;

				cursorPosition /= 16;
				cursorPosition *= 16 / Main.mapFullscreenScale;
				cursorWorldPosition += cursorPosition;
				cursorWorldPosition *= 16;

				cursorWorldPosition.Y -= player.height;
				if (cursorWorldPosition.X < 0) cursorWorldPosition.X = 0;
				else if (cursorWorldPosition.X + player.width > mapWidth) cursorWorldPosition.X = mapWidth - player.width;
				if (cursorWorldPosition.Y < 0) cursorWorldPosition.Y = 0;
				else if (cursorWorldPosition.Y + player.height > mapHeight) cursorWorldPosition.Y = mapHeight - player.height;
					
				player.Teleport(cursorWorldPosition, 0, 0);
				Main.mapFullscreen = false;
				
				for (int index = 0; index < 120; ++index)
				Main.dust[Dust.NewDust(player.position, player.width, player.height, 15, Main.rand.NextFloat(-10f,10f), Main.rand.NextFloat(-10f,10f), 150, Color.Cyan, 1.2f)].velocity *= 0.75f;
			}
	if (GlobalTeleporter && Main.mapFullscreen == true && Main.mouseRight && Main.keyState.IsKeyUp(Microsoft.Xna.Framework.Input.Keys.LeftControl))
	{
		int mapWidth = Main.maxTilesX * 16;
					int mapHeight = Main.maxTilesY * 16;
					Vector2 cursorPosition = new Vector2(Main.mouseX, Main.mouseY);

					cursorPosition.X -= Main.screenWidth / 2;
					cursorPosition.Y -= Main.screenHeight / 2;

					Vector2 mapPosition = Main.mapFullscreenPos;
					Vector2 cursorWorldPosition = mapPosition;

					cursorPosition /= 16;
					cursorPosition *= 16 / Main.mapFullscreenScale;
					cursorWorldPosition += cursorPosition;
					cursorWorldPosition *= 16;

					cursorWorldPosition.Y -= player.height;
					if (cursorWorldPosition.X < 0) cursorWorldPosition.X = 0;
					else if (cursorWorldPosition.X + player.width > mapWidth) cursorWorldPosition.X = mapWidth - player.width;
					if (cursorWorldPosition.Y < 0) cursorWorldPosition.Y = 0;
					else if (cursorWorldPosition.Y + player.height > mapHeight) cursorWorldPosition.Y = mapHeight - player.height;
					
					player.Teleport(cursorWorldPosition, 0, 0);
					Main.mapFullscreen = false;
					Item[] inventory = player.inventory;
					for (int k = 0; k < inventory.Length; k++)
					{
						if (inventory[k].type == mod.ItemType("GlobalTeleporter"))
						{
							inventory[k].stack--;
							break;
						}
					}
					for (int index = 0; index < 120; ++index)
					Main.dust[Dust.NewDust(player.position, player.width, player.height, 15, Main.rand.NextFloat(-10f,10f), Main.rand.NextFloat(-10f,10f), 150, Color.Cyan, 1.2f)].velocity *= 0.75f;
			}
		}
	}
}
