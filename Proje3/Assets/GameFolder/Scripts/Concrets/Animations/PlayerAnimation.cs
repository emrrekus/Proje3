using System.Collections;
using System.Collections.Generic;
using Proje3.Controllers;
using UnityEngine;

namespace Proje3.Animations
{
    public class PlayerAnimation
    {
        private Animator _animator;

        public PlayerAnimation(PlayerController entity)
        {
            _animator = entity.GetComponentInChildren<Animator>();
        }

        public void MoveAnimations(float moveSpeed)
        {
            if(_animator.GetFloat("moveSpeed")== moveSpeed) return;
            _animator.SetFloat("moveSpeed", moveSpeed, 0.1f, Time.deltaTime);
        }
    }
}

