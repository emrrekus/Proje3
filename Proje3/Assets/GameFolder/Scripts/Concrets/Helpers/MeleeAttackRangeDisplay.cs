using System;
using System.Collections;
using System.Collections.Generic;
using Proje3.ScriptableObjects;
using UnityEngine;

namespace Proje3.Helpers
{
    public class MeleeAttackRangeDisplay : MonoBehaviour
    {
        [SerializeField] private RangeAttackSO _attackSo;
        private void OnDrawGizmos()
        {
            OnDrawGizmosSelected();
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(this.transform.position,_attackSo.FloatValue);
        }
    }
}

