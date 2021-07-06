using Character.Movement;
using UnityEngine;

namespace Character
{
    [RequireComponent(typeof(PlayerMovementController))]
    public class Player : MonoBehaviour, IPlayer
    {
        //TODO: Add state memento for time travel
        [SerializeField] private OffensiveCharacterAttribute characterAttribute;
        [SerializeField] private ICharacter powerUp = null;

        public IMovementController MovementController { get; private set; }
        public CharacterAttributes CharacterAttributes => characterAttribute;
        public ICharacter PowerUp => powerUp;

        private void Awake()
        {
            MovementController = GetComponent<IMovementController>() ??
                                 gameObject.AddComponent<PlayerMovementController>();
            
            characterAttribute = characterAttribute == null
                ? characterAttribute
                : ScriptableObject.CreateInstance<OffensiveCharacterAttribute>();
        }

        private void FixedUpdate()
        {
            MovementController.Move();
        }
    }
}