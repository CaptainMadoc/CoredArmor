using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Linq;
using System.Collections.Generic;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using CoredArmor.Content.Items;
using CoredArmor.Content.Buffs;

namespace CoredArmor.Content
{

	public class MyModPlayer : ModPlayer
    {
        if (Player.HasBuff(ModContent.BuffType<CoredArmorBuff>))

    {public override void HideDrawLayers(PlayerDrawSet drawInfo)
        {
            drawInfo.hideEntirePlayer = true;
        }
    
    }

}
