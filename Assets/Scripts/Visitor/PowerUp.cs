using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Visitor;

namespace Visitor
{
    [CreateAssetMenu(fileName = "PowerUp", menuName = "PowerUp")]
    public class PowerUp : ScriptableObject, IVisitor
    {

        public string powerupName;
        public GameObject powerupPrefab;
        public string powerupDescription;

        [Tooltip("Fully heal shield")]
        public bool healShield;

        [Range(0.0f, 50f)]
        [Tooltip("Boost turbo settings up to increments of 50/mph")]
        public float turboBoost;

        [Range(0.0f, 25)]
        [Tooltip("Boost turbo range in increments of up to 25 units")]
        public int weaponRange;

        [Range(0.0f, 50f)]
        [Tooltip("Boost weapon strength in increments of up to 50%")]
        public float weaponStrength;

        public void Visit(BikeShield bikeShield)
        {
            if (healShield)
                bikeShield.health = 100.0f;
        }

        public void Visit(BikeEngine bikeEngine)
        {

        }

        public void Visit(BikeWeapon bikeWeapon)
        {

        }
    }
}