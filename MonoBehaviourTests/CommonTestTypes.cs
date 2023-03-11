using System;
using UnityEngine;

namespace MonoBehaviourTests.CommonTestTypes
{
    public enum TestEnum { A, B, C, D, E, F }
    public enum TestEnumByte : byte { A, B, C, D, E, F }
    public enum TestEnumShort : short { A, B, C, D, E, F }
    public enum TestEnumLong : long { A, B, C, D, E, F }

    [Serializable]
    public class SerializedClass
    {
        public int public_int = 4374;
        public string public_string = "grsdgte";
        public TestEnum public_testEnum = TestEnum.A;
        public UnityEngine.Object public_unityObject;
        public UnityEngine.Object[] public_unityObject_array;

        [SerializeField]
        private PrivateNestedSerializedClass privateNestedSerializedClass;
        [SerializeField]
        private PrivateNestedNonSerializedClass privateNestedNonSerializedClass;

        private int private_int = 124;
        private string private_string = "6348sgfd";
        private TestEnum private_testEnum = TestEnum.B;
        private UnityEngine.Object private_unityObject;

        [SerializeField]
        private int private_serialize_int = 1254452;
        [SerializeField]
        private string private_serialize_string = "gfdhjf3kuyuy8sgfd";
        [SerializeField]
        private TestEnum private_serialize_testEnum = TestEnum.C;
        [SerializeField]
        private UnityEngine.Object private_serialize_unityObject;

        [NonSerialized]
        public int public_nonSerialize_int = 475476;
        [NonSerialized]
        public string public_nonSerialize_string = "52tr grhs dtdgte";
        [NonSerialized]
        public TestEnum public_nonSerialize_testEnum = TestEnum.D;
        [NonSerialized]
        public UnityEngine.Object public_nonSerialize_unityObject;

        [HideInInspector]
        public int public_hideInspector_int = 5379;
        [HideInInspector]
        public string public_hideInspector_string = "9863 4803 012 fas";
        [HideInInspector]
        public TestEnum public_hideInspector_testEnum = TestEnum.E;
        [HideInInspector]
        public UnityEngine.Object public_hideInspector_unityObject;

        [HideInInspector]
        private int private_hideInspector_int = 98790;
        [HideInInspector]
        private string private_hideInspector_string = "gsfs5 ye rsedg ";
        [HideInInspector]
        private TestEnum private_hideInspector_testEnum = TestEnum.F;
        [HideInInspector]
        private UnityEngine.Object private_hideInspector_unityObject;


        [Serializable]
        public class PublicNestedSerializedClass
        {
            public int public_int = 4374;
            public string public_string = "grsdgte";
        }

        [Serializable]
        private class PrivateNestedSerializedClass
        {
            public int public_int = 4374;
            public string public_string = "grsdgte";
        }

        public class PublicNestedNonSerializedClass
        {
            public int public_int = 4374;
            public string public_string = "grsdgte";
        }

        private class PrivateNestedNonSerializedClass
        {
            public int public_int = 4374;
            public string public_string = "grsdgte";
        }
    }

    public class NonSerializedClass
    {
        public int public_int = 4374;
        public string public_string = "grsdgte";
        public TestEnum public_testEnum = TestEnum.A;
        public UnityEngine.Object public_unityObject;

        private int private_int = 124;
        private string private_string = "6348sgfd";
        private TestEnum private_testEnum = TestEnum.B;
        private UnityEngine.Object private_unityObject;

        [SerializeField]
        private int private_serialize_int = 1254452;
        [SerializeField]
        private string private_serialize_string = "gfdhjf3kuyuy8sgfd";
        [SerializeField]
        private TestEnum private_serialize_testEnum = TestEnum.C;
        [SerializeField]
        private UnityEngine.Object private_serialize_unityObject;

        [NonSerialized]
        public int public_nonSerialize_int = 475476;
        [NonSerialized]
        public string public_nonSerialize_string = "52tr grhs dtdgte";
        [NonSerialized]
        public TestEnum public_nonSerialize_testEnum = TestEnum.D;
        [NonSerialized]
        public UnityEngine.Object public_nonSerialize_unityObject;

        [HideInInspector]
        public int public_hideInspector_int = 5379;
        [HideInInspector]
        public string public_hideInspector_string = "9863 4803 012 fas";
        [HideInInspector]
        public TestEnum public_hideInspector_testEnum = TestEnum.E;
        [HideInInspector]
        public UnityEngine.Object public_hideInspector_unityObject;

        [HideInInspector]
        private int private_hideInspector_int = 98790;
        [HideInInspector]
        private string private_hideInspector_string = "gsfs5 ye rsedg ";
        [HideInInspector]
        private TestEnum private_hideInspector_testEnum = TestEnum.F;
        [HideInInspector]
        private UnityEngine.Object private_hideInspector_unityObject;
    }

#if UNITY_2019_3_OR_NEWER
    [Serializable]
    public class InnerSerializeReferenceClass
    {
        [SerializeReference]
        public object serializeReference;

        [SerializeReference]
        private PrivateNestedSerializedClass privateNestedSerializedClass;
        [SerializeReference]
        private PrivateNestedNonSerializedClass privateNestedNonSerializedClass;

        [Serializable]
        private class PrivateNestedSerializedClass
        {
            public int public_int = 4374;
            public string public_string = "grsdgte";
        }

        private class PrivateNestedNonSerializedClass
        {
            public int public_int = 4374;
            public string public_string = "grsdgte";
        }
    }
#endif

    [Serializable]
    public struct SerializedStruct
    {
        public int public_int;
        public string public_string;
        public TestEnum public_testEnum;
        public UnityEngine.Object public_unityObject;

        [SerializeField]
        private PrivateNestedSerializedStruct privateNestedSerializedStruct;
        [SerializeField]
        private PrivateNestedNonSerializedStruct privateNestedNonSerializedStruct;

        private int private_int;
        private string private_string;
        private TestEnum private_testEnum;
        private UnityEngine.Object private_unityObject;

        [SerializeField]
        private int private_serialize_int;
        [SerializeField]
        private string private_serialize_string;
        [SerializeField]
        private TestEnum private_serialize_testEnum;
        [SerializeField]
        private UnityEngine.Object private_serialize_unityObject;

        [NonSerialized]
        public int public_nonSerialize_int;
        [NonSerialized]
        public string public_nonSerialize_string;
        [NonSerialized]
        public TestEnum public_nonSerialize_testEnum;
        [NonSerialized]
        public UnityEngine.Object public_nonSerialize_unityObject;

        [HideInInspector]
        public int public_hideInspector_int;
        [HideInInspector]
        public string public_hideInspector_string;
        [HideInInspector]
        public TestEnum public_hideInspector_testEnum;
        [HideInInspector]
        public UnityEngine.Object public_hideInspector_unityObject;

        [HideInInspector]
        private int private_hideInspector_int;
        [HideInInspector]
        private string private_hideInspector_string;
        [HideInInspector]
        private TestEnum private_hideInspector_testEnum;
        [HideInInspector]
        private UnityEngine.Object private_hideInspector_unityObject;

        public SerializedStruct(bool _ = false) : this()
        {
            public_int = 4374;
            public_string = "grsdgte";
            public_testEnum = TestEnum.A;

            privateNestedSerializedStruct = new PrivateNestedSerializedStruct();
            privateNestedNonSerializedStruct = new PrivateNestedNonSerializedStruct();

            private_int = 124;
            private_string = "6348sgfd";
            private_testEnum = TestEnum.B;

            private_serialize_int = 1254452;
            private_serialize_string = "gfdhjf3kuyuy8sgfd";
            private_serialize_testEnum = TestEnum.C;

            public_nonSerialize_int = 475476;
            public_nonSerialize_string = "52tr grhs dtdgte";
            public_nonSerialize_testEnum = TestEnum.D;

            public_hideInspector_int = 5379;
            public_hideInspector_string = "9863 4803 012 fas";
            public_hideInspector_testEnum = TestEnum.E;

            private_hideInspector_int = 98790;
            private_hideInspector_string = "gsfs5 ye rsedg ";
            private_hideInspector_testEnum = TestEnum.F;
        }

        [Serializable]
        public struct PublicNestedSerializedStruct
        {
            public int public_int;
            public string public_string;

            public PublicNestedSerializedStruct(bool _ = false) : this()
            {
                public_int = 4374;
                public_string = "grsdgte";
            }
        }

        [Serializable]
        private struct PrivateNestedSerializedStruct
        {
            public int public_int;
            public string public_string;

            public PrivateNestedSerializedStruct(bool _ = false) : this()
            {
                public_int = 4374;
                public_string = "grsdgte";
            }
        }

        public struct PublicNestedNonSerializedStruct
        {
            public int public_int;
            public string public_string;

            public PublicNestedNonSerializedStruct(bool _ = false) : this()
            {
                public_int = 4374;
                public_string = "grsdgte";
            }
        }

        private struct PrivateNestedNonSerializedStruct
        {
            public int public_int;
            public string public_string;

            public PrivateNestedNonSerializedStruct(bool _ = false) : this()
            {
                public_int = 4374;
                public_string = "grsdgte";
            }
        }
    }

    public struct NonSerializedStruct
    {
        public int public_int;
        public string public_string;
        public TestEnum public_testEnum;
        public UnityEngine.Object public_unityObject;

        private int private_int;
        private string private_string;
        private TestEnum private_testEnum;
        private UnityEngine.Object private_unityObject;

        [SerializeField]
        private int private_serialize_int;
        [SerializeField]
        private string private_serialize_string;
        [SerializeField]
        private TestEnum private_serialize_testEnum;
        [SerializeField]
        private UnityEngine.Object private_serialize_unityObject;

        [NonSerialized]
        public int public_nonSerialize_int;
        [NonSerialized]
        public string public_nonSerialize_string;
        [NonSerialized]
        public TestEnum public_nonSerialize_testEnum;
        [NonSerialized]
        public UnityEngine.Object public_nonSerialize_unityObject;

        [HideInInspector]
        public int public_hideInspector_int;
        [HideInInspector]
        public string public_hideInspector_string;
        [HideInInspector]
        public TestEnum public_hideInspector_testEnum;
        [HideInInspector]
        public UnityEngine.Object public_hideInspector_unityObject;

        [HideInInspector]
        private int private_hideInspector_int;
        [HideInInspector]
        private string private_hideInspector_string;
        [HideInInspector]
        private TestEnum private_hideInspector_testEnum;
        [HideInInspector]
        private UnityEngine.Object private_hideInspector_unityObject;

        public NonSerializedStruct(bool _ = false) : this()
        {
            public_int = 4374;
            public_string = "grsdgte";
            public_testEnum = TestEnum.A;

            private_int = 124;
            private_string = "6348sgfd";
            private_testEnum = TestEnum.B;

            private_serialize_int = 1254452;
            private_serialize_string = "gfdhjf3kuyuy8sgfd";
            private_serialize_testEnum = TestEnum.C;

            public_nonSerialize_int = 475476;
            public_nonSerialize_string = "52tr grhs dtdgte";
            public_nonSerialize_testEnum = TestEnum.D;

            public_hideInspector_int = 5379;
            public_hideInspector_string = "9863 4803 012 fas";
            public_hideInspector_testEnum = TestEnum.E;

            private_hideInspector_int = 98790;
            private_hideInspector_string = "gsfs5 ye rsedg ";
            private_hideInspector_testEnum = TestEnum.F;
        }
    }

#if UNITY_2019_3_OR_NEWER
    [Serializable]
    public struct InnerSerializeReferenceStruct
    {
        [SerializeReference]
        public object serializeReference;

        [SerializeReference]
        private PrivateNestedSerializedStruct privateNestedSerializedStruct;
        [SerializeReference]
        private PrivateNestedNonSerializedStruct privateNestedNonSerializedStruct;


        [Serializable]
        private struct PrivateNestedSerializedStruct
        {
            public int public_int;
            public string public_string;

            public PrivateNestedSerializedStruct(bool _ = false) : this()
            {
                public_int = 4374;
                public_string = "grsdgte";
            }
        }

        private struct PrivateNestedNonSerializedStruct
        {
            public int public_int;
            public string public_string;

            public PrivateNestedNonSerializedStruct(bool _ = false) : this()
            {
                public_int = 4374;
                public_string = "grsdgte";
            }
        }
    }
#endif

    [Serializable]
    public class GenericClass<T>
    {
        public T genericClassField;
    }

    [Serializable]
    public class GenericClassImplementation : GenericClass<int>
    {
        public int genericClassImplementationField;
    }

    [Serializable]
    public class SecondLevelGenericClass<T> : GenericClass<T>
    {
        public byte secondLevelGenericClassField;
    }

    [Serializable]
    public class SecondLevelGenericClassImplementation : SecondLevelGenericClass<int>
    {
        public float secondLevelGenericClassImplementationField;
    }

#if UNITY_2019_3_OR_NEWER
    [Serializable]
    public class InnerSerializeReferenceGenericClass<T>
    {
        [SerializeReference]
        public T serializeReference;
    }
#endif

    [Serializable]
    public abstract class AbstractClass
    {
        public int abstractClassField;
    }

    [Serializable]
    public class AbstractClassImplementation1 : AbstractClass
    {
        public int abstractClassImplementation1Field;
    }

    [Serializable]
    public class AbstractClassImplementation2 : AbstractClass
    {
        public int abstractClassImplementation2Field;
    }

    public interface Interface
    {

    }

    [Serializable]
    public class ClassInterfaceImplementation : Interface
    {
        public int classInterfaceImplementationField;
    }

    [Serializable]
    public struct StructInterfaceImplementation : Interface
    {
        public int structInterfaceImplementationField;
    }

    public class SimpleMonoBehaviour : MonoBehaviour
    {
        public int simpleMonoBehaviourField;
    }

    public abstract class AbstractMonoBehaviour : MonoBehaviour
    {
        public int abstractMonoBehaviourField;
    }

    public class SimpleScriptableObject : ScriptableObject
    {
        public int simpleScriptableObjectField;
    }

    public abstract class AbstractScriptableObject : ScriptableObject
    {
        public int abstractScriptableObjectField;
    }

    public class GenericMonoBehaviour<T> : MonoBehaviour
    {
        public T genericMonoBehaviourField;
    }

    public class GenericMonoBehaviourImplementation : GenericMonoBehaviour<int>
    {
        public int genericMonoBehaviourImplementationField;
    }

    public class GenericScriptableObject<T> : ScriptableObject
    {
        public T genericMonoBehaviourField;
    }

    public class GenericScriptableObjectImplementation : GenericScriptableObject<int>
    {
        public int genericMonoBehaviourImplementationField;
    }

    [Serializable]
    public class SelfReference
    {
        public SelfReference selfReferenceField;
        public int selfReferenceIntField;
    }

    public class SelfReferenceMonoBehaviour : MonoBehaviour
    {
        public SelfReferenceMonoBehaviour selfReferenceMonoBehaviourField;
    }

    [Serializable]
    public class CyclicReferencePart1
    {
        public CyclicReferencePart2 cyclicReferencePart2Field;
        public int cyclicReferencePart1IntField;
    }
    
    [Serializable]
    public class CyclicReferencePart2
    {
        public CyclicReferencePart1 cyclicReferencePart1Field;
        public int cyclicReferencePart2IntField;
    }

    [Serializable]
    public class SelfReferenceArray
    {
        public SelfReferenceArray[] selfReferenceArrayField;
        public int selfReferenceIntField;
    }

    [Serializable]
    public class CyclicReferenceArrayPart1
    {
        public CyclicReferenceArrayPart2[] cyclicReferenceArrayPart2Field;
        public int cyclicReferencePart1IntField;
    }

    [Serializable]
    public class CyclicReferenceArrayPart2
    {
        public CyclicReferenceArrayPart1[] cyclicReferenceArrayPart1Field;
        public int cyclicReferencePart2IntField;
    }

    [Serializable]
    public class HighLevelDepth
    {
        public DepthLevel1 depthLevel1Field;
        public int highLevelDepthIntField;
    }

    [Serializable]
    public class DepthLevel1
    {
        public DepthLevel2 depthLevel2Field;
        public int depthLevel1IntField;
    }

    [Serializable]
    public class DepthLevel2
    {
        public DepthLevel3 depthLevel3Field;
        public int depthLevel2IntField;
    }

    [Serializable]
    public class DepthLevel3
    {
        public DepthLevel4 depthLevel4Field;
        public int depthLevel3IntField;
    }

    [Serializable]
    public class DepthLevel4
    {
        public DepthLevel5 depthLevel5Field;
        public int depthLevel4IntField;
    }

    [Serializable]
    public class DepthLevel5
    {
        public DepthLevel6 depthLevel6Field;
        public int depthLevel5IntField;
    }

    [Serializable]
    public class DepthLevel6
    {
        public DepthLevel7 depthLevel7Field;
        public int depthLevel6IntField;
    }

    [Serializable]
    public class DepthLevel7
    {
        public DepthLevel8 depthLevel8Field;
        public int depthLevel7IntField;
    }

    [Serializable]
    public class DepthLevel8
    {
        public DepthLevel9 depthLevel9Field;
        public int depthLevel8IntField;
    }

    [Serializable]
    public class DepthLevel9
    {
        public DepthLevel10 depthLevel10Field;
        public int depthLevel9IntField;
    }

    [Serializable]
    public class DepthLevel10
    {
        public DepthLevel11 depthLevel11Field;
        public int depthLevel10IntField;
    }

    [Serializable]
    public class DepthLevel11
    {
        public DepthLevel12 depthLevel12Field;
        public int depthLevel11IntField;
    }

    [Serializable]
    public class DepthLevel12
    {
        public DepthLevel13 depthLevel13Field;
        public int depthLevel12IntField;
    }

    [Serializable]
    public class DepthLevel13
    {
        public DepthLevel14 depthLevel14Field;
        public int depthLevel13IntField;
    }

    [Serializable]
    public class DepthLevel14
    {
        public DepthLevel15 depthLevel15Field;
        public int depthLevel14IntField;
    }

    [Serializable]
    public class DepthLevel15
    {
        public DepthLevel16 depthLevel16Field;
        public int depthLevel15IntField;
    }

    [Serializable]
    public class DepthLevel16
    {
        public DepthLevel17 depthLevel17Field;
        public int depthLevel16IntField;
    }

    [Serializable]
    public class DepthLevel17
    {
        public DepthLevel18 depthLevel18Field;
        public int depthLevel17IntField;
    }

    [Serializable]
    public class DepthLevel18
    {
        public DepthLevel19 depthLevel19Field;
        public int depthLevel18IntField;
    }

    [Serializable]
    public class DepthLevel19
    {
        public SerializedClass depthLevel19SerializedClassField;
        public SerializedClass[] depthLevel19SerializedClassArrayField;

        public SerializedStruct depthLevel19SerializedStructField;
        public SerializedStruct[] depthLevel19SerializedStructArrayField;

        public int depthLevel19IntField;
        public int[] depthLevel19IntArrayField;

        public UnityEngine.Object depthLevel19UnityObjectField;
        public UnityEngine.Object[] depthLevel19UnityObjectArrayField;

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
    }

    [Serializable]
    public struct HighLevelDepthStruct
    {
        public StructDepthLevel1 depthLevel1Field;
        public int highLevelDepthIntField;
    }

    [Serializable]
    public struct StructDepthLevel1
    {
        public StructDepthLevel2 depthLevel2Field;
        public int depthLevel1IntField;
    }

    [Serializable]
    public struct StructDepthLevel2
    {
        public StructDepthLevel3 depthLevel3Field;
        public int depthLevel2IntField;
    }

    [Serializable]
    public struct StructDepthLevel3
    {
        public StructDepthLevel4 depthLevel4Field;
        public int depthLevel3IntField;
    }

    [Serializable]
    public struct StructDepthLevel4
    {
        public StructDepthLevel5 depthLevel5Field;
        public int depthLevel4IntField;
    }

    [Serializable]
    public struct StructDepthLevel5
    {
        public StructDepthLevel6 depthLevel6Field;
        public int depthLevel5IntField;
    }

    [Serializable]
    public struct StructDepthLevel6
    {
        public StructDepthLevel7 depthLevel7Field;
        public int depthLevel6IntField;
    }

    [Serializable]
    public struct StructDepthLevel7
    {
        public StructDepthLevel8 depthLevel8Field;
        public int depthLevel7IntField;
    }

    [Serializable]
    public struct StructDepthLevel8
    {
        public StructDepthLevel9 depthLevel9Field;
        public int depthLevel8IntField;
    }

    [Serializable]
    public struct StructDepthLevel9
    {
        public StructDepthLevel10 depthLevel10Field;
        public int depthLevel9IntField;
    }

    [Serializable]
    public struct StructDepthLevel10
    {
        public StructDepthLevel11 depthLevel11Field;
        public int depthLevel10IntField;
    }

    [Serializable]
    public struct StructDepthLevel11
    {
        public StructDepthLevel12 depthLevel12Field;
        public int depthLevel11IntField;
    }

    [Serializable]
    public struct StructDepthLevel12
    {
        public StructDepthLevel13 depthLevel13Field;
        public int depthLevel12IntField;
    }

    [Serializable]
    public struct StructDepthLevel13
    {
        public StructDepthLevel14 depthLevel14Field;
        public int depthLevel13IntField;
    }

    [Serializable]
    public struct StructDepthLevel14
    {
        public StructDepthLevel15 depthLevel15Field;
        public int depthLevel14IntField;
    }

    [Serializable]
    public struct StructDepthLevel15
    {
        public StructDepthLevel16 depthLevel16Field;
        public int depthLevel15IntField;
    }

    [Serializable]
    public struct StructDepthLevel16
    {
        public StructDepthLevel17 depthLevel17Field;
        public int depthLevel16IntField;
    }

    [Serializable]
    public struct StructDepthLevel17
    {
        public StructDepthLevel18 depthLevel18Field;
        public int depthLevel17IntField;
    }

    [Serializable]
    public struct StructDepthLevel18
    {
        public StructDepthLevel19 depthLevel19Field;
        public int depthLevel18IntField;
    }

    [Serializable]
    public struct StructDepthLevel19
    {
        public SerializedClass depthLevel19SerializedClassField;
        public SerializedClass[] depthLevel19SerializedClassArrayField;

        public SerializedStruct depthLevel19SerializedStructField;
        public SerializedStruct[] depthLevel19SerializedStructArrayField;

        public int depthLevel19IntField;
        public int[] depthLevel19IntArrayField;

        public UnityEngine.Object depthLevel19UnityObjectField;
        public UnityEngine.Object[] depthLevel19UnityObjectArrayField;

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
    }

#if UNITY_2019_3_OR_NEWER
    [Serializable]
    public class InnerReferenceHighLevelDepth
    {
        public InnerReferenceDepthLevel1 depthLevel1Field;
        public int highLevelDepthIntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel1
    {
        public InnerReferenceDepthLevel2 depthLevel2Field;
        public int depthLevel1IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel2
    {
        public InnerReferenceDepthLevel3 depthLevel3Field;
        public int depthLevel2IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel3
    {
        public InnerReferenceDepthLevel4 depthLevel4Field;
        public int depthLevel3IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel4
    {
        public InnerReferenceDepthLevel5 depthLevel5Field;
        public int depthLevel4IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel5
    {
        public InnerReferenceDepthLevel6 depthLevel6Field;
        public int depthLevel5IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel6
    {
        public InnerReferenceDepthLevel7 depthLevel7Field;
        public int depthLevel6IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel7
    {
        public InnerReferenceDepthLevel8 depthLevel8Field;
        public int depthLevel7IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel8
    {
        public InnerReferenceDepthLevel9 depthLevel9Field;
        public int depthLevel8IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel9
    {
        public InnerReferenceDepthLevel10 depthLevel10Field;
        public int depthLevel9IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel10
    {
        public InnerReferenceDepthLevel11 depthLevel11Field;
        public int depthLevel10IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel11
    {
        public InnerReferenceDepthLevel12 depthLevel12Field;
        public int depthLevel11IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel12
    {
        public InnerReferenceDepthLevel13 depthLevel13Field;
        public int depthLevel12IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel13
    {
        public InnerReferenceDepthLevel14 depthLevel14Field;
        public int depthLevel13IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel14
    {
        public InnerReferenceDepthLevel15 depthLevel15Field;
        public int depthLevel14IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel15
    {
        public InnerReferenceDepthLevel16 depthLevel16Field;
        public int depthLevel15IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel16
    {
        public InnerReferenceDepthLevel17 depthLevel17Field;
        public int depthLevel16IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel17
    {
        public InnerReferenceDepthLevel18 depthLevel18Field;
        public int depthLevel17IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel18
    {
        public InnerReferenceDepthLevel19 depthLevel19Field;
        public int depthLevel18IntField;
    }

    [Serializable]
    public class InnerReferenceDepthLevel19
    {
        [SerializeReference]
        public object depthLevel19InnerReferenceField;
    }
#endif

    [Serializable]
    public class ArrayHighLevelDepth
    {
        public ArrayDepthLevel1[] depthLevel1Field;
        public int highLevelDepthIntField;
    }

    [Serializable]
    public class ArrayDepthLevel1
    {
        public ArrayDepthLevel2[] depthLevel2Field;
        public int depthLevel1IntField;
    }

    [Serializable]
    public class ArrayDepthLevel2
    {
        public ArrayDepthLevel3[] depthLevel3Field;
        public int depthLevel2IntField;
    }

    [Serializable]
    public class ArrayDepthLevel3
    {
        public ArrayDepthLevel4[] depthLevel4Field;
        public int depthLevel3IntField;
    }

    [Serializable]
    public class ArrayDepthLevel4
    {
        public ArrayDepthLevel5[] depthLevel5Field;
        public int depthLevel4IntField;
    }

    [Serializable]
    public class ArrayDepthLevel5
    {
        public ArrayDepthLevel6[] depthLevel6Field;
        public int depthLevel5IntField;
    }

    [Serializable]
    public class ArrayDepthLevel6
    {
        public ArrayDepthLevel7[] depthLevel7Field;
        public int depthLevel6IntField;
    }

    [Serializable]
    public class ArrayDepthLevel7
    {
        public ArrayDepthLevel8[] depthLevel8Field;
        public int depthLevel7IntField;
    }

    [Serializable]
    public class ArrayDepthLevel8
    {
        public ArrayDepthLevel9[] depthLevel9Field;
        public int depthLevel8IntField;
    }

    [Serializable]
    public class ArrayDepthLevel9
    {
        public ArrayDepthLevel10[] depthLevel10Field;
        public int depthLevel9IntField;
    }

    [Serializable]
    public class ArrayDepthLevel10
    {
        public ArrayDepthLevel11[] depthLevel11Field;
        public int depthLevel10IntField;
    }

    [Serializable]
    public class ArrayDepthLevel11
    {
        public ArrayDepthLevel12[] depthLevel12Field;
        public int depthLevel11IntField;
    }

    [Serializable]
    public class ArrayDepthLevel12
    {
        public ArrayDepthLevel13[] depthLevel13Field;
        public int depthLevel12IntField;
    }

    [Serializable]
    public class ArrayDepthLevel13
    {
        public ArrayDepthLevel14[] depthLevel14Field;
        public int depthLevel13IntField;
    }

    [Serializable]
    public class ArrayDepthLevel14
    {
        public ArrayDepthLevel15[] depthLevel15Field;
        public int depthLevel14IntField;
    }

    [Serializable]
    public class ArrayDepthLevel15
    {
        public ArrayDepthLevel16[] depthLevel16Field;
        public int depthLevel15IntField;
    }

    [Serializable]
    public class ArrayDepthLevel16
    {
        public ArrayDepthLevel17[] depthLevel17Field;
        public int depthLevel16IntField;
    }

    [Serializable]
    public class ArrayDepthLevel17
    {
        public ArrayDepthLevel18[] depthLevel18Field;
        public int depthLevel17IntField;
    }

    [Serializable]
    public class ArrayDepthLevel18
    {
        public ArrayDepthLevel19[] depthLevel19Field;
        public int depthLevel18IntField;
    }

    [Serializable]
    public class ArrayDepthLevel19
    {
        public int depthLevel19IntField;
    }

    [Serializable]
    public class HighLevelDepthInheritance : InheritanceDepthLevel1
    {
        public int highLevelDepthInheritanceIntField;
        public UnityEngine.Object highLevelDepthInheritanceUnityObjectField;
    }

    [Serializable]
    public class InheritanceDepthLevel1 : InheritanceDepthLevel2
    {
        public int inheritanceDepthLevel1IntField;
        public UnityEngine.Object inheritanceDepthLevel1UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel2 : InheritanceDepthLevel3
    {
        public int inheritanceDepthLevel2IntField;
        public UnityEngine.Object inheritanceDepthLevel2UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel3 : InheritanceDepthLevel4
    {
        public int inheritanceDepthLevel3IntField;
        public UnityEngine.Object inheritanceDepthLevel3UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel4 : InheritanceDepthLevel5
    {
        public int inheritanceDepthLevel4IntField;
        public UnityEngine.Object inheritanceDepthLevel4UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel5 : InheritanceDepthLevel6
    {
        public int inheritanceDepthLevel5IntField;
        public UnityEngine.Object inheritanceDepthLevel5UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel6 : InheritanceDepthLevel7
    {
        public int inheritanceDepthLevel6IntField;
        public UnityEngine.Object inheritanceDepthLevel6UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel7 : InheritanceDepthLevel8
    {
        public int inheritanceDepthLevel7IntField;
        public UnityEngine.Object inheritanceDepthLevel7UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel8 : InheritanceDepthLevel9
    {
        public int inheritanceDepthLevel8IntField;
        public UnityEngine.Object inheritanceDepthLevel8UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel9 : InheritanceDepthLevel10
    {
        public int inheritanceDepthLevel9IntField;
        public UnityEngine.Object inheritanceDepthLevel9UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel10 : InheritanceDepthLevel11
    {
        public int inheritanceDepthLevel10IntField;
        public UnityEngine.Object inheritanceDepthLevel10UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel11 : InheritanceDepthLevel12
    {
        public int inheritanceDepthLevel11IntField;
        public UnityEngine.Object inheritanceDepthLevel11UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel12 : InheritanceDepthLevel13
    {
        public int inheritanceDepthLevel12IntField;
        public UnityEngine.Object inheritanceDepthLevel12UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel13 : InheritanceDepthLevel14
    {
        public int inheritanceDepthLevel13IntField;
        public UnityEngine.Object inheritanceDepthLevel13UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel14 : InheritanceDepthLevel15
    {
        public int inheritanceDepthLevel14IntField;
        public UnityEngine.Object inheritanceDepthLevel14UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel15 : InheritanceDepthLevel16
    {
        public int inheritanceDepthLevel15IntField;
        public UnityEngine.Object inheritanceDepthLevel15UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel16 : InheritanceDepthLevel17
    {
        public int inheritanceDepthLevel16IntField;
        public UnityEngine.Object inheritanceDepthLevel16UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel17 : InheritanceDepthLevel18
    {
        public int inheritanceDepthLevel17IntField;
        public UnityEngine.Object inheritanceDepthLevel17UnityObjectField;
    }
    
    [Serializable]
    public class InheritanceDepthLevel18 : InheritanceDepthLevel19
    {
        public int inheritanceDepthLevel18IntField;
        public UnityEngine.Object inheritanceDepthLevel18UnityObjectField;
    }

    [Serializable]
    public class InheritanceDepthLevel19
    {
        public int inheritanceDepthLevel19IntField;
        public UnityEngine.Object inheritanceDepthLevel19UnityObjectField;
    }

    [Serializable]
    public class HighLevelNesting
    {
        public NestingLevel1 nestingLevel1Field;
        public int highLevelDepthIntField;

        [Serializable]
        public class NestingLevel1
        {
            public NestingLevel2 nestingLevel2Field;
            public int nestingLevel1IntField;

            [Serializable]
            public class NestingLevel2
            {
                public NestingLevel3 nestingLevel3Field;
                public int nestingLevel2IntField;

                [Serializable]
                public class NestingLevel3
                {
                    public NestingLevel4 nestingLevel4Field;
                    public int nestingLevel3IntField;

                    [Serializable]
                    public class NestingLevel4
                    {
                        public NestingLevel5 nestingLevel5Field;
                        public int nestingLevel4IntField;

                        [Serializable]
                        public class NestingLevel5
                        {
                            public NestingLevel6 nestingLevel6Field;
                            public int nestingLevel5IntField;

                            [Serializable]
                            public class NestingLevel6
                            {
                                public NestingLevel7 nestingLevel7Field;
                                public int nestingLevel6IntField;

                                [Serializable]
                                public class NestingLevel7
                                {
                                    public NestingLevel8 nestingLevel8Field;
                                    public int nestingLevel7IntField;

                                    [Serializable]
                                    public class NestingLevel8
                                    {
                                        public NestingLevel9 nestingLevel9Field;
                                        public int nestingLevel8IntField;

                                        [Serializable]
                                        public class NestingLevel9
                                        {
                                            public NestingLevel10 nestingLevel10Field;
                                            public int nestingLevel9IntField;

                                            [Serializable]
                                            public class NestingLevel10
                                            {
                                                public NestingLevel11 nestingLevel11Field;
                                                public int nestingLevel10IntField;

                                                [Serializable]
                                                public class NestingLevel11
                                                {
                                                    public NestingLevel12 nestingLevel12Field;
                                                    public int nestingLevel11IntField;

                                                    [Serializable]
                                                    public class NestingLevel12
                                                    {
                                                        public NestingLevel13 nestingLevel13Field;
                                                        public int nestingLevel12IntField;

                                                        [Serializable]
                                                        public class NestingLevel13
                                                        {
                                                            public NestingLevel14 nestingLevel14Field;
                                                            public int nestingLevel13IntField;

                                                            [Serializable]
                                                            public class NestingLevel14
                                                            {
                                                                public NestingLevel15 nestingLevel15Field;
                                                                public int nestingLevel14IntField;

                                                                [Serializable]
                                                                public class NestingLevel15
                                                                {
                                                                    public NestingLevel16 nestingLevel16Field;
                                                                    public int nestingLevel15IntField;

                                                                    [Serializable]
                                                                    public class NestingLevel16
                                                                    {
                                                                        public NestingLevel17 nestingLevel17Field;
                                                                        public int nestingLevel16IntField;

                                                                        [Serializable]
                                                                        public class NestingLevel17
                                                                        {
                                                                            public NestingLevel18 nestingLevel18Field;
                                                                            public int nestingLevel17IntField;

                                                                            [Serializable]
                                                                            public class NestingLevel18
                                                                            {
                                                                                public NestingLevel19 nestingLevel19Field;
                                                                                public int nestingLevel18IntField;

                                                                                [Serializable]
                                                                                public class NestingLevel19
                                                                                {
                                                                                    public int nestingLevel19IntField;
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
    }
}
