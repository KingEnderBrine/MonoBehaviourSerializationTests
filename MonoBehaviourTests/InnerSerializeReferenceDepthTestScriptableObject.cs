#if UNITY_2019_3_OR_NEWER
using MonoBehaviourTests.CommonTestTypes;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace MonoBehaviourTests
{
    [CreateAssetMenu]
    public class InnerSerializeReferenceDepthTestScriptableObject : ScriptableObject
    {
        public InnerReferenceHighLevelDepth innerReferenceHighLevelDepth;
#if UNITY_2020_2_OR_NEWER || (UNITY_2019_4 && !UNITY_2019_4_0 && !UNITY_2019_4_1 && !UNITY_2019_4_2 && !UNITY_2019_4_3 && !UNITY_2019_4_4 && !UNITY_2019_4_5 && !UNITY_2019_4_6 && !UNITY_2019_4_7 && !UNITY_2019_4_8) || (UNITY_2020_1 && !UNITY_2020_1_0 && !UNITY_2020_1_1 && !UNITY_2020_1_2 && !UNITY_2020_1_3)
        public InnerReferenceDepthLevel8 just_after_the_limit;
#else
        public InnerReferenceDepthLevel11 just_after_the_limit;
#endif
        #region ResetValues
        public void ResetValues()
        {
            innerReferenceHighLevelDepth = new InnerReferenceHighLevelDepth
            {
                depthLevel1Field = new InnerReferenceDepthLevel1
                {
                    depthLevel2Field = new InnerReferenceDepthLevel2
                    {
                        depthLevel3Field = new InnerReferenceDepthLevel3
                        {
                            depthLevel4Field = new InnerReferenceDepthLevel4
                            {
                                depthLevel5Field = new InnerReferenceDepthLevel5
                                {
                                    depthLevel6Field = new InnerReferenceDepthLevel6
                                    {
                                        depthLevel7Field = new InnerReferenceDepthLevel7
                                        {
                                            depthLevel8Field = new InnerReferenceDepthLevel8
                                            {
                                                depthLevel9Field = new InnerReferenceDepthLevel9
                                                {
                                                    depthLevel10Field = new InnerReferenceDepthLevel10
                                                    {
                                                        depthLevel11Field = new InnerReferenceDepthLevel11
                                                        {
                                                            depthLevel12Field = new InnerReferenceDepthLevel12
                                                            {
                                                                depthLevel13Field = new InnerReferenceDepthLevel13
                                                                {
                                                                    depthLevel14Field = new InnerReferenceDepthLevel14
                                                                    {
                                                                        depthLevel15Field = new InnerReferenceDepthLevel15
                                                                        {
                                                                            depthLevel16Field = new InnerReferenceDepthLevel16
                                                                            {
                                                                                depthLevel17Field = new InnerReferenceDepthLevel17
                                                                                {
                                                                                    depthLevel18Field = new InnerReferenceDepthLevel18
                                                                                    {
                                                                                        depthLevel19Field = new InnerReferenceDepthLevel19
                                                                                        {
                                                                                            depthLevel19InnerReferenceField = new SerializedClass()
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }

        #endregion

        #region UnityEditor
#if UNITY_EDITOR
        [UnityEditor.CustomEditor(typeof(SerializeReferenceTestScriptableObject))]
        public class Editor : UnityEditor.Editor
        {
            public override void OnInspectorGUI()
            {
                if (UnityEngine.GUILayout.Button("Reset"))
                {
                    (serializedObject.targetObject as SerializeReferenceTestScriptableObject).ResetValues();
                }
                base.OnInspectorGUI();
            }
        }
#endif
        #endregion
    }
}
#endif