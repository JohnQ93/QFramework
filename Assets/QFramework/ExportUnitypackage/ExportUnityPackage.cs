using System;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace QFramework
{
    public class ExportUnityPackage
    {
#if UNITY_EDITOR
        [MenuItem("QFramework/1. ExportPackage")]
        private static void MenuClicked()
        {
            //将导出的文件路径直接复制到剪切板
            string copyFileName = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH");
            GUIUtility.systemCopyBuffer = copyFileName;

            //直接一键做完整个导出流程
            string assetPathNmae = "Assets/QFramework";
            string fileName = "QFramework_" + DateTime.Now.ToString("yyyyMMdd_HH") + ".unitypackage";
            AssetDatabase.ExportPackage(assetPathNmae, fileName, ExportPackageOptions.Recurse);
        }
#endif
    }
}
