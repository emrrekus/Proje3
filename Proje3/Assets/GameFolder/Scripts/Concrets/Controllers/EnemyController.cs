using System;
using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Controllers;
using Proje3.Abstracts.Movements;
using Proje3.Movements;
using UnityEngine;

namespace Proje3.Controllers
{
    public class EnemyController : MonoBehaviour, IEntityController
    {
        [SerializeField] private Transform _playerPrefab;

        private IMover _mover;

        private void Awake()
        {
            _mover = new MoveWithNavMesh(this);
        }

        private void Update()
        {
            _mover.MoveAction(_playerPrefab.transform.position, 10f);
        }
    }
}