using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Controllers;
using Proje3.Abstracts.Movements;
using Proje3.Controllers;
using UnityEngine;
using UnityEngine.AI;

namespace Proje3.Movements
{
    public class MoveWithNavMesh : IMover
    {
        private NavMeshAgent _navMeshAgent;

        public MoveWithNavMesh(IEntityController entityController)
        {
            _navMeshAgent = entityController.transform.GetComponent<NavMeshAgent>();
        }
        public void MoveAction(Vector3 direction, float moveSpeed)
        {
            
            _navMeshAgent.SetDestination(direction);
            
        }
    }
}

