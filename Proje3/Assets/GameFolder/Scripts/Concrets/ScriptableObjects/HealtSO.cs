using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje3.ScriptableObjects
{
    [CreateAssetMenu(fileName = "Health Info",menuName = "Health Information/Create New",order = 51)]
    public class HealtSO : ScriptableObject
    {
        [SerializeField] private int _maxHealth;

        public int MaxHealth => _maxHealth;
    }
}

