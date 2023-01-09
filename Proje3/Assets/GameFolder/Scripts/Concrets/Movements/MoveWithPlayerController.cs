using System.Collections;
using System.Collections.Generic;
using Mono.Cecil.Cil;
using Proje3.Abstracts.Controllers;
using Proje3.Abstracts.Movements;
using Proje3.Controllers;
using UnityEngine;

namespace Proje3.Movements
{
    public class MoveWithPlayerController : IMover
    {
        private CharacterController _characterController;
        

        public MoveWithPlayerController(IEntityController entityController)
        {
            _characterController = entityController.transform.GetComponent<CharacterController>();
            
        }

       
        
        public void MoveAction(Vector3 direction,float moveSpeed)
        {
            if(direction.magnitude==0f) return;
            Vector3 wordlPostion = _characterController.transform.TransformDirection(direction);
            Vector3 movement = wordlPostion * moveSpeed * Time.deltaTime;
            _characterController.Move(movement);
        }
    }
}

