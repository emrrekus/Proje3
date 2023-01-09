using System;
using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Combats;
using Proje3.Abstracts.Controllers;
using Proje3.Abstracts.Movements;
using Proje3.Animations;
using Proje3.Movements;
using UnityEngine;
using UnityEngine.AI;

namespace Proje3.Controllers
{
    public class EnemyController : MonoBehaviour, IEntityController
    {
        [SerializeField] private Transform _playerPrefab;

        private IMover _mover;
        private IHealth health;
        private PlayerAnimation _animation;
        private NavMeshAgent _navMeshAgent;

        private void Awake()
        {
            _mover = new MoveWithNavMesh(this);
            _animation = new PlayerAnimation(this);
            _navMeshAgent = GetComponent<NavMeshAgent>();
            health = GetComponent<IHealth>();
        }

        private void Update()
        {
            if(health.IsDead) return;
            _mover.MoveAction(_playerPrefab.transform.position, 10f);
        }

        private void LateUpdate()
        {
            
            _animation.MoveAnimations(_navMeshAgent.velocity.magnitude);
        }
    }
}