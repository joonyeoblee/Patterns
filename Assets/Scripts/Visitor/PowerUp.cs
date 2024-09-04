using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Visitor;

namespace Visitor
{
    [CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
    public class PowerUp : ScriptableObject, IVisitor
    {

        public void Visit(BikeShield bikeShield)
        {

        }

        public void Visit(BikeEngine bikeEngine)
        {

        }

        public void Visit(BikeWeapon bikeWeapon)
        {

        }
    }
}