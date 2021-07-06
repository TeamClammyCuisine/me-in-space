using UnityEngine;

namespace Common
{
    [CreateAssetMenu]
    public class FloatVariable : ScriptableObject
    {
        [SerializeField]
        private float value = 0f;

        public float Value
        {
            get => value;
            set => this.value = value;
        }
    }
}
