using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje3.Abstracts.Combats
{
    public interface IHealth 
    {
         bool IsDead { get; }
         void TakeDamager(int damage);
    }
}

