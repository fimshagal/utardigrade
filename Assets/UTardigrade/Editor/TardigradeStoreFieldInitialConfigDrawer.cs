using UTardigrade.Runtime;
using UnityEditor;
using UnityEngine;

namespace UTardigrade.Editor
{
    [CustomPropertyDrawer(typeof(TardigradeStoreFieldInitialConfig))]
    public sealed class TardigradeStoreFieldInitialConfigDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.BeginProperty(position, label, property);

            var lineHeight = EditorGUIUtility.singleLineHeight;
            var spacing = EditorGUIUtility.standardVerticalSpacing;

            var r = new Rect(position.x, position.y, position.width, lineHeight);
            property.isExpanded = EditorGUI.Foldout(r, property.isExpanded, label, true);

            if (!property.isExpanded)
            {
                EditorGUI.EndProperty();
                return;
            }

            EditorGUI.indentLevel++;

            r.y += lineHeight + spacing;
            var typeProp = property.FindPropertyRelative("type");
            EditorGUI.PropertyField(r, typeProp);

            r.y += lineHeight + spacing;
            var valueProp = GetValuePropertyForSelectedType(property, typeProp);

            if (valueProp == null)
            {
                r.height = lineHeight * 2f;
                EditorGUI.HelpBox(r, "No matching value field found for selected type.", MessageType.Warning);
            }
            else
            {
                r.height = EditorGUI.GetPropertyHeight(valueProp, true);
                EditorGUI.PropertyField(r, valueProp, true);
            }

            EditorGUI.indentLevel--;
            EditorGUI.EndProperty();
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var lineHeight = EditorGUIUtility.singleLineHeight;
            var spacing = EditorGUIUtility.standardVerticalSpacing;

            if (!property.isExpanded)
                return lineHeight;

            var typeProp = property.FindPropertyRelative("type");
            var valueProp = GetValuePropertyForSelectedType(property, typeProp);

            var valueHeight = valueProp == null ? lineHeight * 2f : EditorGUI.GetPropertyHeight(valueProp, true);

            // Foldout + Type + Value (with spacings between rows)
            return lineHeight
                   + spacing + lineHeight
                   + spacing + valueHeight;
        }

        private static SerializedProperty GetValuePropertyForSelectedType(SerializedProperty root, SerializedProperty typeProp)
        {
            if (typeProp == null || typeProp.propertyType != SerializedPropertyType.Enum)
                return null;

            var type = (FieldType)typeProp.enumValueIndex;
            var relativeName = type switch
            {
                FieldType.Int => "valueInt",
                FieldType.Long => "valueLong",
                FieldType.Float => "valueFloat",
                FieldType.Double => "valueDouble",
                FieldType.Decimal => "valueDecimal",
                FieldType.String => "valueString",
                FieldType.Vector2 => "valueVector2",
                FieldType.Vector3 => "valueVector3",
                FieldType.ArrayInt => "valueArrayInt",
                FieldType.ArrayLong => "valueArrayLong",
                FieldType.ArrayFloat => "valueArrayFloat",
                FieldType.ArrayDouble => "valueArrayDouble",
                FieldType.ArrayDecimal => "valueArrayDecimal",
                FieldType.ArrayString => "valueArrayString",
                FieldType.ArrayVector2 => "valueArrayVector2",
                FieldType.ArrayVector3 => "valueArrayVector3",
                _ => null
            };

            return string.IsNullOrEmpty(relativeName) ? null : root.FindPropertyRelative(relativeName);
        }
    }
}



