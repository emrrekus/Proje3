using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje3.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private bool _canFire;
        [SerializeField] private float _attackMaxDelay=0.25f;
        [SerializeField] private Camera _camera;
        [SerializeField] float distance=100f;
        [SerializeField] private LayerMask _layerMask;
        private float _currentTime;
        private void Update()
        {
            _currentTime += Time.deltaTime;

            _canFire = _currentTime > _attackMaxDelay;
        }

        public void Attack()
        {
            if(!_canFire) return;

            Ray ray = _camera.ViewportPointToRay(Vector3.one/2f);

            if (Physics.Raycast(ray, out RaycastHit hit, distance, _layerMask))
            {
                Debug.Log((hit.collider.gameObject.name));
            }
            _currentTime = 0f;

        }
    }
    
}

