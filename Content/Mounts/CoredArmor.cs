using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using CoredArmor.Content.Items;

namespace CoredArmor.Content.Mounts
{
	// This mount is a car with wheels which behaves simillarly to the unicorn mount. The car has 3 baloons attached to the back.
	public class CoredArmor : ModMount
	{
			public override void SetStaticDefaults() {
			// Movement
			MountData.jumpHeight = 0; // How high the mount can jump.
			MountData.acceleration = 2f; // The rate at which the mount speeds up.
			MountData.jumpSpeed = 0f; // The rate at which the player and mount ascend towards (negative y velocity) the jump height when the jump button is presssed.
			MountData.blockExtraJumps = true; // Determines whether or not you can use a double jump (like cloud in a bottle) while in the mount.
			MountData.heightBoost = 20; // Height between the mount and the ground
			MountData.fallDamage = 0f; // Fall damage multiplier.
			MountData.runSpeed = 5f; // The speed of the mount
			MountData.dashSpeed = 5f; // The speed the mount moves when in the state of dashing.
			MountData.flightTimeMax = int.MaxValue; // The amount of time in frames a mount can be in the state of flying.

			// Misc
			MountData.fatigueMax = int.MaxValue;
			MountData.usesHover = true;

			// Frame data and player offsets
			MountData.totalFrames = 1;
			int[] array = new int[MountData.totalFrames];
			for (int l = 0; l < array.Length; l++) array[l] = 0; // Amount of animation frames for the mount
			MountData.playerYOffsets = new int[] { 0 }; // Fills an array with values for less repeating code
			MountData.xOffset = 10;
			MountData.yOffset = 10;
			MountData.playerHeadOffset = 22;
			MountData.bodyFrame = 0;
			// Standing
			MountData.standingFrameCount = 0;
			MountData.standingFrameDelay = 0;
			MountData.standingFrameStart = 0;
			// Running
			MountData.runningFrameCount = 0;
			MountData.runningFrameDelay = 0;
			MountData.runningFrameStart = 0;
			// Flying
			MountData.flyingFrameCount = 0;
			MountData.flyingFrameDelay = 0;
			MountData.flyingFrameStart = 0;
			// In-air
			MountData.inAirFrameCount = 0;
			MountData.inAirFrameDelay = 0;
			MountData.inAirFrameStart = 0;
			// Idle
			MountData.idleFrameCount = 0;
			MountData.idleFrameDelay = 0;
			MountData.idleFrameStart = 0;
			MountData.idleFrameLoop = true;
			// Swim
			MountData.swimFrameCount = MountData.inAirFrameCount;
			MountData.swimFrameDelay = MountData.inAirFrameDelay;
			MountData.swimFrameStart = MountData.inAirFrameStart;

			if (!Main.dedServ) {
				MountData.textureWidth = MountData.backTexture.Width() + 20;
				MountData.textureHeight = MountData.backTexture.Height();
			}
		}

		public override void SetMount(Player player, ref bool skipDust)
		{
			skipDust = true;
		}

		public override void Dismount(Player player, ref bool skipDust)
		{
			skipDust = true;
		}
	}
}