using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Combats;
using Proje3.Combats;
using UnityEngine;

namespace Proje3.ScriptableObjects
{

    enum AttackTypeEnum : byte
    {
        Range,Melee
    }
    
    [CreateAssetMenu(fileName = "Attack Info",menuName = "Attack Information/Create New",order = 51)]
    public class RangeAttackSO : ScriptableObject
    {
        [SerializeField] private AttackTypeEnum _attackType;
        [SerializeField] private int _damage = 10;
        [SerializeField] float _floatValue=1f;
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private float _attackMaxDelay=0.25f;
        [SerializeField] private AnimatorOverrideController _animatorOverride;

        public int Damage => _damage;
        public float FloatValue => _floatValue;
        public LayerMask LayerMask => _layerMask;
        public float AttackMaxDelay => _attackMaxDelay;
        public AnimatorOverrideController AnimatorOverride => _animatorOverride;

        public IAttackType GetAttackType(Transform transform)
        {
            if (_attackType == AttackTypeEnum.Range)
            {
                return new RangeAttackType(transform, this);
            }
            else
            {
                return new MeleeAttackType(transform, this);
            }
        }
        
    }
}

