using System;
using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Combats;
using Proje3.ScriptableObjects;
using UnityEngine;

namespace Proje3.Combats
{
    public class Health : MonoBehaviour,IHealth
    {

        [SerializeField] private HealtSO _healtInfo;

        private int _currentHealth;
        public bool IsDead => _currentHealth <= 0;

        private void Awake()
        {
            _currentHealth = _healtInfo.MaxHealth;
        }

        public void TakeDamager(int damage)
        {

            if(IsDead) return;
            
            _currentHealth -= damage;
            
            
        }
    }
    
}

