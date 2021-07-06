using System;
using UnityEngine;

namespace Character.Movement
{
    public class PlayerMovementController : MonoBehaviour, IMovementController
    {
        private Controls _controls;

        [SerializeField] private CharacterAttributes characterAttributes;

        public float MovementSpeed => characterAttributes != null ? characterAttributes.MovementSpeed : 5f;

        public void Move()
        {
            var direction = _controls.Player.Movement.ReadValue<float>();
            var x = direction;

            transform.rotation = Quaternion.Euler(0, x < 0 ? 180 : 0, 0);

            x *= Time.deltaTime * MovementSpeed;

            transform.Translate(Math.Abs(x), 0, 0);
        }

        private void Awake()
        {
            _controls = new Controls();
            characterAttributes = characterAttributes == null
                ? characterAttributes
                : ScriptableObject.CreateInstance<OffensiveCharacterAttribute>();
        }

        private void OnEnable()
        {
            _controls.Player.Enable();
        }

        private void OnDisable()
        {
            _controls.Player.Disable();
        }
    }
}