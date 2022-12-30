using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Proje3.Abstracts.Inputs
{
    public interface IInputReader 
    {
        Vector3 Direction { get; }
        Vector2 Rotation { get; }
    }
}





