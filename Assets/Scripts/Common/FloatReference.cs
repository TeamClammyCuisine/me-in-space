using System;
using UnityEngine;

namespace Common
{
    [Serializable]
    public class FloatReference
    {
        [SerializeField]
        private bool useConstant = true;
        [SerializeField]
        private float constantValue;
        [SerializeField]
        private FloatVariable variable = ScriptableObject.CreateInstance<FloatVariable>();

        public float Value
        {
            get => useConstant ? constantValue : variable.Value;
            set
            {
                if (useConstant)
                    constantValue = value;
                else
                    variable.Value = value;
            } 
        }
    }
}
