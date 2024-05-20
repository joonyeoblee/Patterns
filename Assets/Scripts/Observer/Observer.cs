using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Observer
{
    public abstract class Observer : MonoBehaviour
    {
        public abstract void Notify(Subject subject);
    }
}