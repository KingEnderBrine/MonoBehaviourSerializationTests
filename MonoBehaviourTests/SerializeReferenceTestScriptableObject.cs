#if UNITY_2019_3_OR_NEWER
using MonoBehaviourTests.CommonTestTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MonoBehaviourTests
{
    [CreateAssetMenu]
    public class SerializeReferenceTestScriptableObject : ScriptableObject
    {
        #region Primitives 

        //Shouldn't be serialized
        [SerializeReference]
        public byte byte_Type;
        [SerializeReference]
        public int int_Type;
        [SerializeReference]
        public bool bool_Type;
        [SerializeReference]
        public string string_Type;

        #endregion

        #region Simple classes

        [SerializeReference]
        public SerializedClass serializedClass_Type;
        [SerializeReference]
        public NonSerializedClass nonSerializedClass_Type;
        [SerializeReference]
        public InnerSerializeReferenceClass innerSerializeReferenceClass_Type;

        #endregion

        #region Structs

        //Shouldn't be serialized
        [SerializeReference]
        public SerializedStruct serializedStruct_Type;
        [SerializeReference]
        public NonSerializedStruct nonSerializedStruct_Type;
        [SerializeReference]
        public InnerSerializeReferenceStruct innerSerializeReferenceStruct_Type;

        #endregion

        #region Generic classes

        //Shouldn't be serialized
        [SerializeReference]
        public GenericClass<int> genericClass_int_Type;
        [SerializeReference]
        public GenericClass<string> genericClass_string_Type;
        [SerializeReference]
        public GenericClass<int> genericClass_int_Type_GenericClassImplementation_value;
        [SerializeReference]
        public InnerSerializeReferenceGenericClass<AbstractClass> innerSerializeReferenceGenericClass_AbstractClass_Type_AbstractClassImplementation1_Value;
        //Should be always serialized
        [SerializeReference]
        public GenericClassImplementation genericClassImplementation_Type;

        #endregion

        #region Abstract classes

        [SerializeReference]
        public AbstractClass abstractClass_Type_AbstractClassImplementation1_Value;
        [SerializeReference]
        public AbstractClass abstractClass_Type_AbstractClassImplementation2_Value;
        [SerializeReference]
        public AbstractClassImplementation1 abstractClassImplementation1_Type;

        #endregion

        #region Interfaces

        [SerializeReference]
        public Interface interface_Type_ClassInterfaceImplementation_Value;
        [SerializeReference]
        public Interface interface_Type_StructInterfaceImplementation_Value;

        #endregion

        #region Objects

        [SerializeReference]
        public object object_Type_null_value;
        [SerializeReference]
        public object object_Type_int_value;
        [SerializeReference]
        public object object_Type_string_value;
        [SerializeReference]
        public object object_Type_bool_value;
        [SerializeReference]
        public object object_Type_NonSerializedClass_value;
        [SerializeReference]
        public object object_Type_NonSerializedStruct_value;
        [SerializeReference]
        public object object_Type_GenericClassImpelementation_value;
        [SerializeReference]
        public List<object> object_List_Type_NonSerializedClass_value;
        [SerializeReference]
        public object[] object_Array_Type_NonSerializedClass_value;
        //Serialized as null at least in Unity < 2021.3
        [SerializeReference]
        public object object_Type_GenericClass_int_value;
        //Crashes Unity but not something that needs to be detected by generator
        [SerializeReference]
        public object object_Type_Array_object_value;
        [SerializeReference]
        public object object_Type_List_object_value;

        #endregion

        #region Unity objects

        //Should be a normal PPtr
        [SerializeReference]
        public UnityEngine.Object unity_object_Type_this_value;

        #endregion

        #region ResetValues

        public void ResetValues()
        {
            byte_Type = 3;
            int_Type = 2;
            bool_Type = true;
            string_Type = "some string";

            serializedClass_Type = new SerializedClass();
            nonSerializedClass_Type = new NonSerializedClass();
            innerSerializeReferenceClass_Type = new InnerSerializeReferenceClass { serializeReference = new NonSerializedClass() };

            serializedStruct_Type = new SerializedStruct(false);
            nonSerializedStruct_Type = new NonSerializedStruct(false);
            innerSerializeReferenceStruct_Type = new InnerSerializeReferenceStruct { serializeReference = new NonSerializedStruct(false) };

            genericClass_int_Type = new GenericClass<int>();
            genericClass_string_Type = new GenericClass<string>();
            genericClass_int_Type_GenericClassImplementation_value = new GenericClassImplementation();
            innerSerializeReferenceGenericClass_AbstractClass_Type_AbstractClassImplementation1_Value = new InnerSerializeReferenceGenericClass<AbstractClass>() { serializeReference = new AbstractClassImplementation1() };
            genericClassImplementation_Type = new GenericClassImplementation();

            abstractClass_Type_AbstractClassImplementation1_Value = new AbstractClassImplementation1();
            abstractClass_Type_AbstractClassImplementation2_Value = new AbstractClassImplementation2();
            abstractClassImplementation1_Type = new AbstractClassImplementation1();

            interface_Type_ClassInterfaceImplementation_Value = new ClassInterfaceImplementation();
            interface_Type_StructInterfaceImplementation_Value = new StructInterfaceImplementation();

            object_Type_null_value = null;
            object_Type_int_value = 5;
            object_Type_string_value = "some string";
            object_Type_bool_value = true;
            object_Type_NonSerializedClass_value = new NonSerializedClass();
            object_Type_NonSerializedStruct_value = new NonSerializedStruct(false);
            object_Type_GenericClassImpelementation_value = new GenericClassImplementation();
            object_List_Type_NonSerializedClass_value = new List<object> { new NonSerializedClass() };
            object_Array_Type_NonSerializedClass_value = new object[] { new NonSerializedClass() };

            //object_Type_GenericClass_int_value = new GenericClass<int>();
            //object_Type_Array_object_value = new object[] { new NonSerializedClass() };
            //object_Type_List_object_value = new List<object> { new NonSerializedClass() };

            unity_object_Type_this_value = this;
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