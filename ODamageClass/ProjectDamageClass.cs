using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace ofriend.ODamageClass
{
    public class ProjectDamageClass : DamageClass
    {
        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            if (damageClass == DamageClass.Generic)
                return StatInheritanceData.Full;
            return StatInheritanceData.None;
            if (damageClass == DamageClass.Magic)
            {
                return new StatInheritanceData(
                    damageInheritance: 1f,
                    critChanceInheritance: 1f,
                    attackSpeedInheritance: 0.5f,
                    armorPenInheritance: 2f,
                    knockbackInheritance: 1f);
            }
        }
        public override bool GetEffectInheritance(DamageClass damageClass)
        {
            if (damageClass == DamageClass.Magic)
                return true;

            return false;
        }
        public override void SetDefaultStats(Player player)
        {
            // 此方法让你设置此伤害类型的默认属性加成 (像原版的伤害默认有+4%暴击率)
            // 此处我们使其默认拥有+4%暴击率和+10盔甲穿透
            player.GetCritChance<ProjectDamageClass>() += 4;
            player.GetArmorPenetration<ProjectDamageClass>() += 10;
            player.GetDamage<ProjectDamageClass>() += 10;
            // 你也可以在这里写伤害 (GetDamage), 击退 (GetKnockback), 和攻速 (GetAttackSpeed)
        }
    }
}
