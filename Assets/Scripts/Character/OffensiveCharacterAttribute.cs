using UnityEngine;

namespace Character
{
    [CreateAssetMenu]
    public class OffensiveCharacterAttribute : CharacterAttributes
    {
        [SerializeField] private float maxHealth = 10f;
        [SerializeField] private float attackDamage = 3f;
        [SerializeField] private float attackSpeed = 1f;

        public float MaxHealth => maxHealth;
        public float AttackDamage => attackDamage;
        public float AttackSpeed => attackSpeed;
    }
}