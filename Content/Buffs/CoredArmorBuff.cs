using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace CoredArmor.Content.Buffs
{
	public class CoredArmorBuff : ModBuff
	{
		public override void SetStaticDefaults() 
		{

		}

		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = int.MaxValue;
		}
	}
}