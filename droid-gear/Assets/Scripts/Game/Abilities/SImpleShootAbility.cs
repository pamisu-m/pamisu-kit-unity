using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using Game.Common;
using Game.Configs;
using Game.Framework;
using Game.Props;
using UnityEngine;

namespace Game.Abilities
{
    public class SimpleShootAbility : Ability
    {

        private Character _target;
        
        public SimpleShootAbility(AbilityConfig config) : base(config)
        {
        }

        public override void SetTarget(AbilityTargetInfo info)
        {
            _target = info.MainTarget;
        }

        public override void ClearTarget()
        {
            _target = null;
        }

        protected override async UniTask DoActivate(CancellationToken cancellationToken)
        {
            if (_target == null)
            {
                Debug.LogError($"Ability {Config.Id} do activate failed: Target is null");
                return;
            }

            Owner.Model.Anim.SetTrigger(AnimConst.RangedAttack1);

            // pre-delay
            if (Config.ActPreDelay != 0)
                await UniTask.Delay(TimeSpan.FromSeconds(Config.ActPreDelay), 
                    DelayType.DeltaTime, 
                    PlayerLoopTiming.Update, 
                    cancellationToken);

            // act
            var damage = new Damage(Owner, -Owner.AttrComp[AttributeType.Damage].Value);
            var firePoint = Owner.Model.FirePoints[0];
            var direction = _target.Trans.position - firePoint.position;
            var proj = await Owner.Pooler.Spawn<Projectile>(Config.PrefabRes.RuntimeKey.ToString());
            proj.SetupEntity(Owner.Region);
            proj.Activate(damage, firePoint.position, direction, Owner.Go.layer);

            // post-delay
            if (Config.ActPostDelay != 0)
                await UniTask.Delay(TimeSpan.FromSeconds(Config.ActPostDelay), 
                    DelayType.DeltaTime, 
                    PlayerLoopTiming.Update, 
                    cancellationToken);
            
            // cooldown affected by attack speed
            var attackSpeed = Owner.AttrComp[AttributeType.AttackSpeed].Value;
            if (attackSpeed != 0)
                Cooldown = Config.Cooldown / attackSpeed;
            else
                Cooldown = Config.Cooldown;
        }
        
    }
}