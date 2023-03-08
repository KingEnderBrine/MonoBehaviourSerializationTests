#if UNITY_EDITOR
using System.IO;
using UnityEditor;
#if UNITY_2018_1_OR_NEWER
using UnityEditor.Build.Reporting;
#endif
using UnityEngine;

namespace MonoBehaviourTests
{
    public static class BuildBundles
    {
        private const string commonSOpath = "Assets/SO/CommonSerializationTestScriptableObject.asset";
#if UNITY_2019_3_OR_NEWER
        private const string serializeReferenceSOpath = "Assets/SO/SerializeReferenceTestScriptableObject.asset";
        private const string innerSerializeReferenceSOpath = "Assets/SO/InnerSerializeReferenceTestScriptableObject.asset";
        private const string innerSerializeReferenceDepthSOpath = "Assets/SO/InnerSerializeReferenceDepthTestScriptableObject.asset";
#endif

        [MenuItem("MonoBehaviourTests/BuildBundles")]
        public static void Build()
        {
            if (Directory.Exists("Build"))
            {
                Directory.Delete("Build", true);
            }
            Directory.CreateDirectory("Build");
            Directory.CreateDirectory(Path.Combine("Build", "Mono"));
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.Mono2x);
            var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
            {
                locationPathName = Path.Combine(Path.Combine("Build", "Mono"), Application.unityVersion + ".exe"),
                options = BuildOptions.None,
                target = BuildTarget.StandaloneWindows,
                targetGroup = BuildTargetGroup.Standalone,
                scenes = new[] { "Assets/Scenes/SampleScene.unity" },
            });

#if UNITY_2018_1_OR_NEWER
            if (report.summary.result != BuildResult.Succeeded)
#else
            if (!File.Exists(Path.Combine(Path.Combine("Build", "Mono"), Application.unityVersion + ".exe")))
#endif
            {
                Debug.LogError("Build Failed");
                return;
            }

            //There was a bug with il2cpp builds before 2018.2.21 and I can't be bothered to work around it
#if UNITY_2018_3_OR_NEWER
            PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.IL2CPP);
            Directory.CreateDirectory(Path.Combine("Build", "IL2CPP"));
            report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
            {
                locationPathName = Path.Combine(Path.Combine("Build", "IL2CPP"), Application.unityVersion + ".exe"),
                options = BuildOptions.None,
                target = BuildTarget.StandaloneWindows,
                targetGroup = BuildTargetGroup.Standalone,
                scenes = new[] { "Assets/Scenes/SampleScene.unity" },
            });
            
#if UNITY_2018_1_OR_NEWER
            if (report.summary.result != BuildResult.Succeeded)
#else
            if (!File.Exists(Path.Combine(Path.Combine("Build", "Mono"), Application.unityVersion + ".exe")))
#endif
            {
                Debug.LogError("Build Failed");
                return;
            }
#endif

            Directory.CreateDirectory(Path.Combine("Build", "AssetBundles"));
            Directory.CreateDirectory(Path.Combine("Assets", "SO"));

            var commonSO = ScriptableObject.CreateInstance<CommonSerializationTestScriptableObject>();
            commonSO.ResetValues();

#if UNITY_2019_3_OR_NEWER
            var serializeReferenceSO = ScriptableObject.CreateInstance<SerializeReferenceTestScriptableObject>();
            serializeReferenceSO.ResetValues();

            var innerSerializeReferenceSO = ScriptableObject.CreateInstance<InnerSerializeReferenceTestScriptableObject>();
            innerSerializeReferenceSO.ResetValues();

            var innerSerializeReferenceDepthSO = ScriptableObject.CreateInstance<InnerSerializeReferenceDepthTestScriptableObject>();
            innerSerializeReferenceDepthSO.ResetValues();
#endif
            AssetDatabase.CreateAsset(commonSO, commonSOpath);
#if UNITY_2019_3_OR_NEWER
            AssetDatabase.CreateAsset(serializeReferenceSO, serializeReferenceSOpath);
            AssetDatabase.CreateAsset(innerSerializeReferenceSO, innerSerializeReferenceSOpath);
            AssetDatabase.CreateAsset(innerSerializeReferenceDepthSO, innerSerializeReferenceDepthSOpath);
#endif

            try
            {
                var manifestWithoutTypes = BuildPipeline.BuildAssetBundles(
                    Path.Combine("Build", "AssetBundles"),
                    new[]
                    {
                        new AssetBundleBuild()
                        {
                            assetBundleName = Application.unityVersion + "_without_types",
                            assetNames = new[]
                            {
                                commonSOpath,
#if UNITY_2019_3_OR_NEWER
                                serializeReferenceSOpath,
                                innerSerializeReferenceSOpath,
                                innerSerializeReferenceDepthSOpath,
#endif
                            }
                        }
                    },
                    BuildAssetBundleOptions.DisableWriteTypeTree | BuildAssetBundleOptions.ForceRebuildAssetBundle | BuildAssetBundleOptions.UncompressedAssetBundle,
                    BuildTarget.StandaloneWindows);
                
                if (manifestWithoutTypes == null)
                {
                    Debug.LogError("Build Failed");
                    return;
                }

                var manifest = BuildPipeline.BuildAssetBundles(
                    Path.Combine("Build", "AssetBundles"),
                    new[]
                    {
                        new AssetBundleBuild()
                        {
                            assetBundleName = Application.unityVersion,
                            assetNames = new[]
                            {
                                commonSOpath,
#if UNITY_2019_3_OR_NEWER
                                serializeReferenceSOpath,
                                innerSerializeReferenceSOpath,
                                innerSerializeReferenceDepthSOpath,
#endif
                            }
                        }
                    },
                    BuildAssetBundleOptions.ForceRebuildAssetBundle | BuildAssetBundleOptions.UncompressedAssetBundle,
                    BuildTarget.StandaloneWindows);

                if (manifest == null)
                {
                    Debug.LogError("Build Failed");
                    return;
                }

                Debug.Log("Build Succeded");
            }
            finally
            {
                AssetDatabase.DeleteAsset(commonSOpath);
#if UNITY_2019_3_OR_NEWER
                AssetDatabase.DeleteAsset(serializeReferenceSOpath);
                AssetDatabase.DeleteAsset(innerSerializeReferenceSOpath);
                AssetDatabase.DeleteAsset(innerSerializeReferenceDepthSOpath);
#endif
            }
        }
    }
}
#endif