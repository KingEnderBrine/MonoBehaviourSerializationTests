#if UNITY_2019_3_OR_NEWER
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MonoBehaviourTests.CommonTestTypes;

namespace MonoBehaviourTests
{
    [CreateAssetMenu]
    public class InnerSerializeReferenceTestScriptableObject : ScriptableObject
    {
        public InnerSerializeReferenceClass innerSerializeReference;

        #region ResetValues

        public void ResetValues()
        {
            innerSerializeReference = new InnerSerializeReferenceClass { serializeReference = new SerializedClass() };
        }

        #endregion

        #region UnityEditor
#if UNITY_EDITOR
        [UnityEditor.CustomEditor(typeof(InnerSerializeReferenceTestScriptableObject))]
        public class Editor : UnityEditor.Editor
        {
            public override void OnInspectorGUI()
            {
                if (UnityEngine.GUILayout.Button("Reset"))
                {
                    (serializedObject.targetObject as InnerSerializeReferenceTestScriptableObject).ResetValues();
                }
                base.OnInspectorGUI();
            }
        }
#endif
        #endregion
    }
}
#endif