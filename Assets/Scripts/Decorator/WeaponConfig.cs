using UnityEngine;


namespace Decorator
{
    [CreateAssetMenu(fileName = "NewWeaponConfig", menuName = "Weapon/Config", order = 1)]
    public class WeaponConfig : ScriptableObject, IWeapon
    {
        [Range(0, 50)]
        [Tooltip("Increase the range of fire per second")]
        [SerializeField]
        private float rate;

        [Range(0, 50)]
        [Tooltip("Increase weapon range")]
        [SerializeField]
        private float range;

        [Range(0, 100)]
        [Tooltip("Increase weapon strength")]
        [SerializeField]
        private float strength;

        [Range(0, 5)]
        [Tooltip("Reduce cooldown duration")]
        [SerializeField]
        private float cooldown;

        public string weaponName;
        public GameObject weaponPrefab;
        public string weaponDescription;

        public float Range => range;
        public float Rate => rate;
        public float Strength => strength;
        public float Cooldown => cooldown;
    }
}