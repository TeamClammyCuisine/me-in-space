using UnityEngine;

namespace Character
{
    public abstract class CharacterAttributes : ScriptableObject
    {
        [SerializeField] private string characterName = "";
        [SerializeField] private float movementSpeed = 5;
        [SerializeField] private Sprite sprite = null;
        
        public string CharacterName => characterName;
        public float MovementSpeed => movementSpeed;
        public Sprite Sprite => sprite;
    }
}