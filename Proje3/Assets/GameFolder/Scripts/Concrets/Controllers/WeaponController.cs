using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Proje3.Abstracts.Combats;
using Proje3.Combats;
using Proje3.ScriptableObjects;
using UnityEngine;

namespace Proje3.Controllers
{
    public class WeaponController : MonoBehaviour
    {
      
        [SerializeField] private bool _canFire;
        
        [SerializeField]  private Transform _transformObject;

        [SerializeField] private RangeAttackSO _attackSo;
       
        private float _currentTime;
        private IAttackType _attackType;

        private void Awake()
        {
            _attackType = new RangeAttackType(_transformObject.transform, _attackSo);
        }

        private void Update()
        {
            _currentTime += Time.deltaTime;

            _canFire = _currentTime > _attackSo.AttackMaxDelay;
        }

        public void Attack()
        {
            if(!_canFire) return;
            
            _attackType.AttackAction();

            _currentTime = 0f;
            
            
        }
    }
    
}

