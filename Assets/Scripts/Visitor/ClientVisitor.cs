using System.Collections;
using System.Collections.Generic;
using Chapter.EventBus;
using UnityEngine;

namespace Visitor
{
    partial class ClientVisitor : MonoBehaviour
    {
        public PowerUp enginePowerUp;
        public PowerUp weaponPowerUp;
        public PowerUp shieldPowerUp;

        private BikeController _bikeController;

        void Start()
        {
            _bikeController = gameObject.AddComponent<BikeController>();
        }

        void OnGUI()
        {
            if (GUILayout.Button("PowerUp Shield"))
                _bikeController.Accept(shieldPowerUp);

            if (GUILayout.Button("PowerUp Weapon"))
                _bikeController.Accept(weaponPowerUp);

            if (GUILayout.Button("PowerUp Engine"))
                _bikeController.Accept(enginePowerUp);
        }

    }
}