using UnityEditor;
using UnityEngine;

namespace Common
{
    [CustomPropertyDrawer(typeof(FloatReference))]
    public class FloatReferenceDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

            var constantRect = new Rect(position.x, position.y, position.height, position.height);
            SetConstant(property, EditorGUI.Toggle(constantRect, property.FindPropertyRelative("useConstant").boolValue));

            var valueRect = new Rect(position.x + position.height, position.y, position.width - position.height,
                position.height);

            if (property.FindPropertyRelative("useConstant").boolValue)
                property.FindPropertyRelative("constantValue").floatValue = EditorGUI.FloatField(valueRect,
                    property.FindPropertyRelative("constantValue").floatValue);
            else
                EditorGUI.ObjectField(valueRect, property.FindPropertyRelative("variable"), GUIContent.none);
        
            EditorGUI.EndProperty();
        }

        private static void SetConstant(SerializedProperty property, bool value)
        {
            property.FindPropertyRelative("useConstant").boolValue = value;
            property.serializedObject.ApplyModifiedProperties();
        }
    }
}