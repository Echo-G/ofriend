using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.CameraModifiers;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
namespace ofriend.NPCs
{
    public class CoilHead : ModNPC
    {
        public override void SetDefaults()
        {
            NPC.width = 36;
            NPC.height = 118;
            NPC.damage = 114514;
            NPC.lifeMax = 1919810;
            NPC.defense = 100;
            NPC.scale = 1.5f;
            NPC.knockBackResist = 0f;
            NPC.value = Item.buyPrice(1, 0, 0, 0);
            NPC.lavaImmune = true;
            NPC.noGravity = false;
            NPC.noTileCollide = false;
            NPC.npcSlots = 10;
            NPC.boss = false;
            NPC.dontTakeDamage = true;
            NPC.aiStyle = -1;
        }
        public override void AI()
        {
            if (NPC.target < 0 || NPC.target == 255 || Main.player[NPC.target].dead || !Main.player[NPC.target].active)
            {
                NPC.TargetClosest();
            }

            Player player = Main.player[NPC.target];
            //为寻找合适的玩家作为对象

            if (player.dead)
            {
                // 追，如果死了就找下一个
                NPC.velocity.Y -= 0.04f;
                // 在最多2个屏幕内找
                NPC.EncourageDespawn(2);
                return;
            }
            //NPC.velocity = new Vector2(10, 12);
            NPC.TargetClosest(true);
            Player p = Main.player[NPC.target];
            //NPC.velocity = 12 * (p.Center - NPC.Center).SafeNormalize(Vector2.Zero);
            NPC.velocity = Vector2.Normalize(p.Center - NPC.Center) * 10f;
            if (Math.Sign(Main.LocalPlayer.direction) == Math.Sign(NPC.Center.X - Main.LocalPlayer.Center.X))
            {
                NPC.velocity = new Vector2(0, 0);
            }

        }
        //public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
        //{
        //    int Coil = Mod.Find<ModGore>("").Type;
        //    var entitySource = NPC.GetSource_Death();
        //    Gore.NewGore(entitySource, NPC.position, new Vector2(Main.rand.Next(-6, 7), Main.rand.Next(-6, 7)), Coil);

        //    PunchCameraModifier modifier = new PunchCameraModifier(NPC.Center, (Main.rand.NextFloat() * ((float)Math.PI * 2f)).ToRotationVector2(), 20f, 6f, 20, 1000f, FullName);
        //    Main.instance.CameraModifiers.Add(modifier);
        //}
    }
}
