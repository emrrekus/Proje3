using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje3.ScriptableObjects
{
    
    [CreateAssetMenu(fileName = "Attack Info",menuName = "Attack Information/Create New",order = 51)]
    public class RangeAttackSO : ScriptableObject
    {
        [SerializeField] private int _damage = 10;
        [SerializeField] float _floatValue=1f;
        [SerializeField] private LayerMask _layerMask;
        [SerializeField] private float _attackMaxDelay=0.25f;

        public int Damage => _damage;
        public float FloatValue => _floatValue;
        public LayerMask LayerMask => _layerMask;
        public float AttackMaxDelay => _attackMaxDelay;
    }
}

