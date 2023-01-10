using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Proje3.Abstracts.Combats;
using Proje3.ScriptableObjects;
using UnityEngine;

namespace Proje3.Combats
{
    public class MeleeAttackType : IAttackType
    {
        private Transform _transformObject;
        [CanBeNull] private RangeAttackSO _rangeAttackSo;
        public MeleeAttackType(Transform transformObject, RangeAttackSO rangeAttackSo)
        {

            _transformObject = transformObject;
            _rangeAttackSo = rangeAttackSo;
        }
        public void AttackAction()
        {
            Vector3 attackPoint = _transformObject.position;
            Collider[] colliders =Physics.OverlapSphere(attackPoint,_rangeAttackSo.FloatValue,_rangeAttackSo.LayerMask);

            foreach (Collider collider in colliders )
            {
                if (collider.TryGetComponent(out IHealth health))
                {
                    health.TakeDamager(_rangeAttackSo.Damage);
                }
            }
        }
    }
}

