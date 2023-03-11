using MonoBehaviourTests.CommonTestTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MonoBehaviourTests
{
    [CreateAssetMenu]
    public class CommonSerializationTestScriptableObject : ScriptableObject
    {
        #region Primitives, enums and string

        public bool @bool;
        public byte @byte;
        public sbyte @sbyte;
        public char @char;
        public short @short;
        public ushort @ushort;
        public int @int;
        public uint @uint;
        public long @long;
        public ulong @ulong;
        public float @float;
        public double @double;

        public TestEnum testEnum;
        public TestEnumByte testEnumByte;
        public TestEnumShort testEnumShort;
        //Shouldn't be serialized, why, Unity???
        public TestEnumLong testEnumLong;

        public string @string;

        #endregion

        #region Array and List

        public string[] string_array;
        //Shouldn't be serialized
        public string[][] string_2d_array;
        public List<string>[] string_list_array;

        public List<string> string_list;
        //Shouldn't be serialized
        public List<List<string>> string_2d_list;
        public List<string[]> string_array_list;

        //Should be serialized, starting from 2020.1
        public GenericClass<int>[] genericClass_int_array;
        public List<GenericClass<int>> genericClass_int_list;
        //Shouldn't be serialized
        public GenericClass<int>[][] genericClass_int_2d_array;
        public List<List<GenericClass<int>>> genericClass_int_2d_list;

        #endregion

        #region Simple classes

        public SerializedClass serializedClass;
        //Shouldn't be serialized
        public NonSerializedClass nonSerializedClass;

        public SerializedClass.PublicNestedSerializedClass publicNestedSerializedClass;
        //Shouldn't be serialized
        public SerializedClass.PublicNestedNonSerializedClass publicNestedNonSerializedClass;

        #endregion

        #region Structs

        public SerializedStruct serializedStruct;
        //Shouldn't be serialized
        public NonSerializedStruct nonSerializedStruct;

        public SerializedStruct.PublicNestedSerializedStruct publicNestedSerializedStruct;
        //Shouldn't be serialized
        public SerializedStruct.PublicNestedNonSerializedStruct publicNestedNonSerializedStruct;

        #endregion

        #region Depth

        public SelfReference selfReference;
        public CyclicReferencePart1 cyclicReference;
        public HighLevelDepth highLevelDepth;
        public HighLevelDepthStruct highLevelDepthStruct;
        public HighLevelDepthInheritance highLevelDepthInheritance;

        public ArrayHighLevelDepth arrayHighLevelDepth;

        public SelfReferenceArray selfReferenceArray;
        public CyclicReferenceArrayPart1 cyclicReferenceArrayPart1;

        public SelfReference[] selfReference_array;
        public List<SelfReference> selfReference_list;

#if UNITY_2020_2_OR_NEWER || (UNITY_2019_4 && !UNITY_2019_4_0 && !UNITY_2019_4_1 && !UNITY_2019_4_2 && !UNITY_2019_4_3 && !UNITY_2019_4_4 && !UNITY_2019_4_5 && !UNITY_2019_4_6 && !UNITY_2019_4_7 && !UNITY_2019_4_8) || (UNITY_2020_1 && !UNITY_2020_1_0 && !UNITY_2020_1_1 && !UNITY_2020_1_2 && !UNITY_2020_1_3)
        public DepthLevel8 oneLevelPastDepthLimit;
        public StructDepthLevel8 structOneLevelPastDepthLimit;
        
        public DepthLevel9 limitLevelDepth;
        public StructDepthLevel9 structLimitLevelDepth;

        public DepthLevel10 oneLevelBeforeDepthLimit;
        public StructDepthLevel10 structOneLevelBeforeDepthLimit;
#else
        public DepthLevel11 oneLevelPastDepthLimit;
        public StructDepthLevel11 structOneLevelPastDepthLimit;

        public DepthLevel12 limitLevelDepth;
        public StructDepthLevel12 structLimitLevelDepth;

        public DepthLevel13 oneLevelBeforeDepthLimit;
        public StructDepthLevel13 structOneLevelBeforeDepthLimit;
#endif
        #endregion

        #region Generic classes

        public GenericClassImplementation genericClassImplementation;
        //Should be serialized, starting from 2020.1
        public GenericClass<int> genericClass_int;
        public GenericClass<string> genericClass_string;

        public GenericMonoBehaviourImplementation genericMonoBehaviourImplementation;
        //Should be serialized, starting from 2020.1
        public GenericMonoBehaviour<int> genericMonoBehaviour_int;
        public GenericMonoBehaviour<string> genericMonoBehaviour_string;

        public GenericScriptableObjectImplementation genericScriptableObjectImplementation;
        //Should be serialized, starting from 2020.1
        public GenericScriptableObject<int> genericScriptableObject_int;
        public GenericScriptableObject<string> genericScriptableObject_string;

        public SecondLevelGenericClassImplementation secondLevelGenericClassImplementation;
        //Should be serialized, starting from 2020.1
        public SecondLevelGenericClass<int> secondLevelGenericClass;

        #endregion

        #region Abstract classes

        public AbstractClassImplementation1 abstractClassImplementation1;
        //Shouldn't be serialized
        public AbstractClass abstractClass;

        #endregion

        #region Interfaces

        //Shouldn't be serialized
        public Interface @interface;

        #endregion

        #region System.Collections

        //Shouldn't be serialized
        public System.Collections.Generic.Dictionary<string, int> dictionary_string_int;
        public System.Collections.Generic.HashSet<int> hashSet_int;
        public System.Collections.ArrayList arrayList;
        public System.Collections.BitArray bitArray;
        public System.Collections.Queue queue;
        public System.Collections.SortedList sortedList;
        public System.Collections.Stack stack;
        public System.Collections.Generic.LinkedList<int> linkedList_int;
        public System.Collections.Generic.Queue<int> queue_int;
        public System.Collections.Generic.SortedDictionary<int, int> sortedDictionary_int_int;
        public System.Collections.Generic.SortedList<int, int> sortedList_int_int;
#if UNITY_2019_1_OR_NEWER
        public System.Collections.Generic.SortedSet<int> sortedSet_int;
#endif
        public System.Collections.Generic.Stack<int> stack_int;
        public System.Collections.Generic.KeyValuePair<int, int> keyValuePair_int_int;

        #endregion

        #region UnityEngine objects

        public UnityEngine.Object unityObject;
        public SimpleMonoBehaviour simpleMonoBehaviour;
        public AbstractMonoBehaviour abstractMonoBehaviour;
        public SimpleScriptableObject simpleScriptableObject;
        public AbstractScriptableObject abstractScriptableObject;

        public UnityEngine.Object[] unityObjectArray;
        public SimpleMonoBehaviour[] simpleMonoBehaviourArray;
        public AbstractMonoBehaviour[] abstractMonoBehaviourArray;
        public SimpleScriptableObject[] simpleScriptableObjectArray;
        public AbstractScriptableObject[] abstractScriptableObjectArray;
        
        public List<UnityEngine.Object> unityObjectList;
        public List<SimpleMonoBehaviour> simpleMonoBehaviourList;
        public List<AbstractMonoBehaviour> abstractMonoBehaviourList;
        public List<SimpleScriptableObject> simpleScriptableObjectList;
        public List<AbstractScriptableObject> abstractScriptableObjectList;

        public SelfReferenceMonoBehaviour selfReferenceMonoBehaviour;

        #endregion

        #region Unity special types

        public UnityEngine.Color color;
        public UnityEngine.Color32 color32;
        public UnityEngine.Gradient gradient;
        public UnityEngine.Vector2 vector2;
        public UnityEngine.Vector3 vector3;
        public UnityEngine.Vector4 vector4;
        public UnityEngine.LayerMask layerMask;
        public UnityEngine.Quaternion quaternion;
        public UnityEngine.Bounds bounds;
        public UnityEngine.Rect rect;
        public UnityEngine.Matrix4x4 matrix4X4;
        public UnityEngine.AnimationCurve animationCurve;
        public UnityEngine.GUIStyle guiStyle;
#if UNITY_2017_2_OR_NEWER
        public UnityEngine.Vector2Int vector2Int;
        public UnityEngine.Vector3Int vector3Int;
        public UnityEngine.BoundsInt boundsInt;
#endif
        public UnityEngine.RectOffset rectOffset;
        #endregion

        #region ResetValues

        public void ResetValues()
        {
            @bool = true;
            @byte = 5;
            @sbyte = 8;
            @char = 'c';
            @short = 4636;
            @ushort = 65475;
            @int = 456756;
            @uint = 3252;
            @long = 54876;
            @ulong = 12542643;
            @float = 534.527F;
            @double = 543.534;

            @string = "some string";

            string_array = new[] { "string 1", "string 2" };
            string_2d_array = new[] { new[] { "string 1.1", "string 1.2" }, new[] { "string 2.1", "string 2.2" } };
            string_list_array = new List<string>[] { new List<string> { "string 1.1", "string 1.2" }, new List<string> { "string 2.1", "string 2.2" } };

            string_list = new List<string> { "string 1", "string 2" };
            string_2d_list = new List<List<string>> { new List<string> { "string 1.1", "string 1.2" }, new List<string> { "string 2.1", "string 2.2" } };
            string_array_list = new List<string[]> { new[] { "string 1.1", "string 1.2" }, new[] { "string 2.1", "string 2.2" } };

            genericClass_int_array = new GenericClass<int>[] { new GenericClass<int>(), new GenericClass<int>() };
            genericClass_int_list = new List<GenericClass<int>> { new GenericClass<int>(), new GenericClass<int>() };
            genericClass_int_2d_array = new GenericClass<int>[][] { new[] { new GenericClass<int>(), new GenericClass<int>() }, new[] { new GenericClass<int>(), new GenericClass<int>() } };
            genericClass_int_2d_list = new List<List<GenericClass<int>>> { new List<GenericClass<int>> { new GenericClass<int>(), new GenericClass<int>() }, new List<GenericClass<int>> { new GenericClass<int>(), new GenericClass<int>() } };

            serializedClass = new SerializedClass();
            nonSerializedClass = new NonSerializedClass();

            serializedStruct = new SerializedStruct(false);
            nonSerializedStruct = new NonSerializedStruct(false);

            genericClassImplementation = new GenericClassImplementation();
            genericClass_int = new GenericClass<int>();
            genericClass_string = new GenericClass<string>();

            abstractClassImplementation1 = new AbstractClassImplementation1();
            abstractClass = new AbstractClassImplementation1();

            @interface = new ClassInterfaceImplementation();

            dictionary_string_int = new Dictionary<string, int>();
            hashSet_int = new HashSet<int>();
            arrayList = new ArrayList();
            bitArray = new BitArray(0);
            queue = new Queue();
            sortedList = new SortedList();
            stack = new Stack();
            linkedList_int = new LinkedList<int>();
            queue_int = new Queue<int>();
            sortedDictionary_int_int = new SortedDictionary<int, int>();
            sortedList_int_int = new SortedList<int, int>();
#if UNITY_2019_1_OR_NEWER
            sortedSet_int = new SortedSet<int>();
#endif
            stack_int = new Stack<int>();
            keyValuePair_int_int = new KeyValuePair<int, int>(1, 2);

            color = new Color(0.5F, 0.21F, 0.67F);
            color32 = new Color32(32, 65, 124, 23);
            gradient = new Gradient { alphaKeys = new[] { new GradientAlphaKey(0.5f, 0.5F) }, colorKeys = new[] { new GradientColorKey(new Color(0.7F, 0.1F, 0.5F), 0.7F) } };
            vector2 = new Vector2(2, 7);
            vector3 = new Vector3(654, 43, 21);
            vector4 = new Vector4(432, 35, 546, 546);
            layerMask = new LayerMask() { value = 546 };
            quaternion = new Quaternion(0.1F, 0.6F, 0.35F, 0.86F);
            bounds = new Bounds(new Vector3(43, 543, 543), new Vector3(432, 432, 432));
            rect = new Rect(21, 32, 543, 65);
            matrix4X4 = new Matrix4x4(new Vector4(432, 654, 546, 1), new Vector4(43, 35, 9, 325), new Vector4(457, 37685, 12, 54632), new Vector4(434352, 31245, 3232, 53424));
            animationCurve = new AnimationCurve(new Keyframe(0.5F, 2, 2, 25), new Keyframe(21, 32, 54, 54));
            guiStyle = new GUIStyle();
#if UNITY_2017_2_OR_NEWER
            vector2Int = new Vector2Int(321, 231);
            vector3Int = new Vector3Int(645, 546, 575);
            boundsInt = new BoundsInt(123, 213, 13, 4235, 435, 435);
#endif
            rectOffset = new RectOffset(54, 6546, 457, 546);
        }

        #endregion

        #region UnityEditor
#if UNITY_EDITOR
        [UnityEditor.CustomEditor(typeof(CommonSerializationTestScriptableObject))]
        public class Editor : UnityEditor.Editor
        {
            public override void OnInspectorGUI()
            {
                if (UnityEngine.GUILayout.Button("Reset"))
                {
                    (serializedObject.targetObject as CommonSerializationTestScriptableObject).ResetValues();
                }
                base.OnInspectorGUI();
            }
        }
#endif
        #endregion
    }
}