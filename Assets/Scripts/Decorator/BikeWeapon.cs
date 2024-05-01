using UnityEngine;
using System.Collections;

namespace Decorator
{
    public class BikeWeapon : MonoBehaviour
    {
        public WeaponConfig weaponConfig;
        public WeaponAttachment mainWeaponAttachment;
        public WeaponAttachment secondaryWeaponAttachment;

        private bool _isFiring;
        private IWeapon _weapon;
        private bool _isDecorated;

        public void Start()
        {
            // weaponConfig = new WeaponConfig();
            _weapon = new Weapon(weaponConfig);
        }

        void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label(new Rect(5, 50, 150, 100), "Range: " + _weapon.Range);
            GUI.Label(new Rect(5, 70, 150, 100), "Strength: " + _weapon.Strength);
            GUI.Label(new Rect(5, 90, 150, 100), "CoolDown: " + _weapon.Cooldown);
            GUI.Label(new Rect(5, 110, 150, 100), "Firing Rate: " + _weapon.Rate);
            GUI.Label(new Rect(5, 130, 150, 100), "Weapon Firing: " + _isFiring);

            if (mainWeaponAttachment && _isDecorated)
                GUI.Label(new Rect(5, 150, 250, 100), "Main Attachment: " + mainWeaponAttachment.name);

            if (secondaryWeaponAttachment && _isDecorated)
                GUI.Label(new Rect(5, 170, 250, 100), "Secondary Attachment: " + secondaryWeaponAttachment.name);
        }

        public void ToggleFire()
        {
            _isFiring = !_isFiring;
            if (_isFiring)
            {
                StartCoroutine(FireWeapon());
            }
        }

        IEnumerator FireWeapon()
        {
            float firingRate = 1.0f / _weapon.Rate;

            while (_isFiring)
            {
                yield return new WaitForSeconds(firingRate);
                Debug.Log("Fire");
            }
        }

        public void Reset()
        {
            _weapon = new Weapon(weaponConfig);
            _isDecorated = !_isDecorated;
        }

        public void Decorate()
        {
            if (mainWeaponAttachment && !secondaryWeaponAttachment)
            {
                _weapon = new WeaponDecorator(_weapon, mainWeaponAttachment);
            }

            if (mainWeaponAttachment && secondaryWeaponAttachment)
            {
                _weapon = new WeaponDecorator(_weapon, secondaryWeaponAttachment);
            }
            _isDecorated = !_isDecorated;
        }
    }
}