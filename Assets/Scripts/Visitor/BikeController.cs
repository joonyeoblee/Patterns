using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Visitor
{
    public class BikeController : MonoBehaviour
    {
        private List<IBikeElement> _bikesElements = new List<IBikeElement>();

        void Start()
        {
            _bikesElements.Add(gameObject.AddComponent<BikeShield>());
            _bikesElements.Add(gameObject.AddComponent<BikeEngine>());
            _bikesElements.Add(gameObject.AddComponent<BikeWeapon>());
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var bikeElement in _bikesElements)
            {
                bikeElement.Accept(visitor);
            }
        }
    }
}