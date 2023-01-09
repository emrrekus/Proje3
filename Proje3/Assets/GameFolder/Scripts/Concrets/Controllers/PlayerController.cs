
using System.Collections;
using System.Collections.Generic;
using Proje3.Abstracts.Controllers;
using Proje3.Abstracts.Inputs;
using Proje3.Abstracts.Movements;
using Proje3.Animations;
using Proje3.Movements;
using UnityEngine;

namespace Proje3.Controllers
{
    public class PlayerController : MonoBehaviour,IEntityController
    {
        [Header("Movement Information")] [SerializeField]
         float _moveSpeed = 5f;
        [SerializeField]  float _turnSpeed = 3f;
        [SerializeField] private Transform _turnTransform;
        [SerializeField] private WeaponController _currentWeapon;
        
        
        private IInputReader _input;
        private IMover _mover;
        private PlayerAnimation _animation;
        private IRotator _xRotation;
        private IRotator _yRotation;
        
        private Vector3 _direction;
    

        public Transform TurnTransform => _turnTransform;
        private void Awake()
        {
            _input = GetComponent<IInputReader>();
            _mover = new MoveWithPlayerController(this);
            _animation = new PlayerAnimation(this);
            _xRotation = new RotatorX(this);
            _yRotation = new RotatorY(this);
        }

        private void Update()
        {
            _direction = _input.Direction;
         
          
            if (_input.IsAttackButtonPress)
            {
                _currentWeapon.Attack();
            }
        }

        private void FixedUpdate()
        {
            _mover.MoveAction(_direction,_moveSpeed);
            
        }

        private void LateUpdate()
        {
            _xRotation.RotationAction(_input.Rotation.x,_turnSpeed);
            _yRotation.RotationAction(_input.Rotation.y, _turnSpeed);
            _animation.MoveAnimations(_direction.magnitude);
        }

        
    }
}

