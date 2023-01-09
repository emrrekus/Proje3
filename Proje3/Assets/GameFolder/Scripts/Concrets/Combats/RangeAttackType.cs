using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Combats;
using Proje3.ScriptableObjects;
using Unity.VisualScripting;
using UnityEngine;

namespace Proje3.Combats
{
    public class RangeAttackType : IAttackType
    {
        private RangeAttackSO _rangeAttackSo;
        private Camera _camera;
        


        public RangeAttackType(Transform transformObject,RangeAttackSO rangeAttackSo)
        {

            _camera = transformObject.GetComponent<Camera>();
            _rangeAttackSo = rangeAttackSo;
        }
        
        

        public void AttackAction()
        {
           
             Ray ray = _camera.ViewportPointToRay(Vector3.one/2f);
 
             if (Physics.Raycast(ray, out RaycastHit hit, _rangeAttackSo.FloatValue, _rangeAttackSo.LayerMask))
             {
                 if (hit.collider.TryGetComponent(out IHealth health))
                 {
                     health.TakeDamager(_rangeAttackSo.Damage);
                 }
             }
        }
    }
}

