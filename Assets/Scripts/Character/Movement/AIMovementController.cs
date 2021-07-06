using System;
using UnityEngine;

namespace Character.Movement
{
    public class AIMovementController : MonoBehaviour, IMovementController
    {

        [SerializeField] private CharacterAttributes characterAttributes;

        public float MovementSpeed => characterAttributes != null ? characterAttributes.MovementSpeed : 5f;

        private void Awake()
        {
            characterAttributes = characterAttributes == null
                ? characterAttributes
                : ScriptableObject.CreateInstance<PassiveCharacterAttributes>();
        }

        public void Move()
        {
            //TODO: Implement AI Movement Controller Move Method
        }
    }
}