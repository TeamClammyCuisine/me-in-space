using UnityEngine;

public class OffensiveCharacterAttribute : MonoBehaviour, ICharacterAttributes
{
    [SerializeField] private float health = 10f;
    [SerializeField] private float attackDamage = 3f;
    [SerializeField] private float attackSpeed = 1f;

    public float Health => health;
    public float AttackDamage => attackDamage;
    public float AttackSpeed => attackSpeed;
}