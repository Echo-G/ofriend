﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using ofriend;
using Microsoft.Xna.Framework;

namespace ofriend.Projectile
{
    public class DreamSeal : ModProjectile
    {
        Player player => Main.player[Projectile.owner]; 
        public override void SetDefaults()
        {
            Projectile.width = 64;
            Projectile.height = 64;
            Projectile.scale = 1f;
            Projectile.ignoreWater = true;
            Projectile.tileCollide = true;
            Projectile.penetrate = 5;
            Projectile.timeLeft = 1800;//存在时间待定）
            Projectile.alpha = 0;
            Projectile.friendly = true;
            Projectile.DamageType = ModContent.GetInstance<ODamageClass.ProjectDamageClass>();
            Projectile.aiStyle = -1;
        }

        public override bool PreAI()
        {
            return true;
        }
        float timer = 0;//定义一个计时器字段
        public override void AI()
        {
            Projectile.rotation = Projectile.velocity.ToRotation();
            timer++;

            NPC target = FindClosestNPC();
            if (target != null)
            {
                MoveTowardsTarget(target.Center);
            }
            else
            {
                MoveTowardsTarget(player.Center);
            }
        }

        private NPC FindClosestNPC()
        {
            NPC closestNPC = null;
            float closestDistance = 1000f;
            foreach (NPC npc in Main.npc)
            {
                if (!npc.active || npc.friendly) continue;
                float distance = Vector2.Distance(npc.Center, player.Center);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestNPC = npc;
                }
            }
            return closestNPC;
        }

        private void MoveTowardsTarget(Vector2 targetPos)
        {
            float maxSpeed = 20f;
            float accSpeed = 0.5f;
            Vector2 directionToTarget = targetPos - Projectile.Center;
            float targetSpeedX = directionToTarget.X * accSpeed;
            float targetSpeedY = directionToTarget.Y * accSpeed;

            if (Projectile.velocity.X * directionToTarget.X < 0)
                targetSpeedX *= 2;
            if (Projectile.velocity.Y * directionToTarget.Y < 0)
                targetSpeedY *= 2;

            Projectile.velocity.X = MathHelper.Clamp(Projectile.velocity.X + targetSpeedX, -maxSpeed, maxSpeed);
            Projectile.velocity.Y = MathHelper.Clamp(Projectile.velocity.Y + targetSpeedY, -maxSpeed, maxSpeed);
        }

        //public override void AI()
        //{
        //    Projectile.rotation = Projectile.velocity.ToRotation();//让贴图方向等于速度方向 
        //    timer++;//我们还是需要一个计时器的，用来控制角度
        //    NPC target = null;
        //    float distanceMax = 1000f;
        //    foreach (NPC npc in Main.npc)
        //    {
        //        // 如果npc活着且敌对
        //        if (!npc.active || npc.friendly) continue;
        //        // 计算与玩家的距离，可以改成与弹幕的距离
        //        float currentDistance = Vector2.Distance(npc.Center, player.Center);
        //        // 如果npc距离比当前最大距离小
        //        if (currentDistance < distanceMax)
        //        {
        //            // 就把最大距离设置为npc和玩家的距离
        //            // 并且暂时选取这个npc为距离最近npc
        //            distanceMax = currentDistance;
        //            target = npc;
        //        }
        //    }
        //    if (target != null)
        //    {
        //        Vector2 targetPos = target.Center;//Main.MouseWorld;//找NPC作为被追目标
        //        float MaxSpeed = 20f;//设定横纵向最大速度
        //        float accSpeed = 0.5f;//设定横纵向加速度
        //                              //原理：比较目标和自己的横向或者纵向坐标差，然后给自己的速度加上向着差值变小前进的加速度
        //                              //如果自己的速度坐标差一样，说明自己正在原理目标，需要更大的加速度，这里我设定的是2倍
        //        if (Projectile.Center.X - targetPos.X < 0f)
        //            Projectile.velocity.X += Projectile.velocity.X < 0 ? 2 * accSpeed : accSpeed;
        //        else
        //            Projectile.velocity.X -= Projectile.velocity.X > 0 ? 2 * accSpeed : accSpeed;

        //        if (Projectile.Center.Y - targetPos.Y < 0f)
        //            Projectile.velocity.Y += Projectile.velocity.Y < 0 ? 2 * accSpeed : accSpeed;
        //        else
        //            Projectile.velocity.Y -= Projectile.velocity.Y > 0 ? 2 * accSpeed : accSpeed;
        //        if (Math.Abs(Projectile.velocity.X) > MaxSpeed)//如果横向速度超越最大值，则回到最大值
        //            Projectile.velocity.X = MaxSpeed * Math.Sign(Projectile.velocity.X);
        //        if (Math.Abs(Projectile.velocity.Y) > MaxSpeed)//如果纵向速度超越最大值，则回到最大值
        //            Projectile.velocity.Y = MaxSpeed * Math.Sign(Projectile.velocity.Y);
        //    }
        //    else
        //    {
        //        Vector2 targetPos = player.Center;//Main.MouseWorld;//找NPC作为被追目标
        //        float MaxSpeed = 20f;//设定横纵向最大速度
        //        float accSpeed = 0.5f;//设定横纵向加速度
        //                              //原理：比较目标和自己的横向或者纵向坐标差，然后给自己的速度加上向着差值变小前进的加速度
        //                              //如果自己的速度坐标差一样，说明自己正在原理目标，需要更大的加速度，这里我设定的是2倍
        //        if (Projectile.Center.X - targetPos.X < 0f)
        //            Projectile.velocity.X += Projectile.velocity.X < 0 ? 2 * accSpeed : accSpeed;
        //        else
        //            Projectile.velocity.X -= Projectile.velocity.X > 0 ? 2 * accSpeed : accSpeed;

        //        if (Projectile.Center.Y - targetPos.Y < 0f)
        //            Projectile.velocity.Y += Projectile.velocity.Y < 0 ? 2 * accSpeed : accSpeed;
        //        else
        //            Projectile.velocity.Y -= Projectile.velocity.Y > 0 ? 2 * accSpeed : accSpeed;
        //        if (Math.Abs(Projectile.velocity.X) > MaxSpeed)//如果横向速度超越最大值，则回到最大值
        //            Projectile.velocity.X = MaxSpeed * Math.Sign(Projectile.velocity.X);
        //        if (Math.Abs(Projectile.velocity.Y) > MaxSpeed)//如果纵向速度超越最大值，则回到最大值
        //            Projectile.velocity.Y = MaxSpeed * Math.Sign(Projectile.velocity.Y);
        //    }
        //}
    }
}
