using System;
using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Inputs;
using Proje3.Abstracts.Movements;
using Proje3.Animations;
using Proje3.Movements;
using UnityEngine;

namespace Proje3.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movement Information")] [SerializeField]
        private float _moveSpeed = 5f;
        private IInputReader _input;
        private IMover _mover;
        private PlayerAnimation _animation;
        
        private Vector3 _direction;
        private void Awake()
        {
            _input = GetComponent<IInputReader>();
            _mover = new MoveWithPlayerController(this);
            _animation = new PlayerAnimation(this);
        }

        private void Update()
        {
            _direction = _input.Direction;
        }

        private void FixedUpdate()
        {
            _mover.MoveAction(_direction,_moveSpeed);
        }

        private void LateUpdate()
        {
            _animation.MoveAnimations(_direction.magnitude);
        }
    }
}

