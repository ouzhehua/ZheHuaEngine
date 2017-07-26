using UnityEngine;
using System.Collections;
using UnityEditor;

namespace UnityGameFramework.Editor.AssetBundleTools
{
    internal sealed class AssetBundleBuildHandler : IBuildEventHandler
    {
        public void PreProcessBuildAll(string productName, string companyName, string gameIdentifier,
            string applicableGameVersion, int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip,
            string outputDirectory, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportPath)
        {
        
        }

        public void PostProcessBuildAll(string productName, string companyName, string gameIdentifier,
            string applicableGameVersion, int internalResourceVersion, string unityVersion, BuildAssetBundleOptions buildOptions, bool zip,
            string outputDirectory, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath, string buildReportPath)
        { }

        public void PreProcessBuild(BuildTarget buildTarget, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath)
        { }

        public void PostProcessBuild(BuildTarget buildTarget, string workingPath, string outputPackagePath, string outputFullPath, string outputPackedPath)
        { }
    }
}