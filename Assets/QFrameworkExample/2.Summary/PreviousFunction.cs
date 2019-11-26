using System;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace QFramework
{
    public class PreviousFunction
    {
        public static string GeneratePackageName()
        {
            return "QC_Learning_" + DateTime.Now.ToString("yyyyMMdd_HH");
        }

        public static void CopyText(string text)
        {
            GUIUtility.systemCopyBuffer = text;
        }

        public static void OpenInFolder(string folderPath)
        {
            Application.OpenURL("file:///" + folderPath);
        }
#if UNITY_EDITOR
        public static void ExportPackage(string assetPathName, string packageNmae)
        {
            string fileNmae = packageNmae + ".unitypackage";
            AssetDatabase.ExportPackage(assetPathName, fileNmae, ExportPackageOptions.Recurse);
        }

        public static void CallMenuItem(string menuName)
        {
            EditorApplication.ExecuteMenuItem(menuName);
        }

        [MenuItem("Learning/3. QuickSummary/1. 生成UnityPackage名字")]
        private static void MenuClicked()
        {
            Debug.Log(GeneratePackageName());
        }

        [MenuItem("Learning/3. QuickSummary/2. 复制名字到剪切板")]
        private static void MenuClicked2()
        {
            CopyText(GeneratePackageName());
        }

        [MenuItem("Learning/3. QuickSummary/3. 导出UnityPackage并命名")]
        private static void MenuClicked3()
        {
            ExportPackage("Assets/Learning", GeneratePackageName());
        }

        [MenuItem("Learning/3. QuickSummary/4. 打开所在文件夹")]
        private static void MenuClicked4()
        {
            OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }

        [MenuItem("Learning/3. QuickSummary/5. 导出UnityPackage并打开所在文件夹")]
        private static void MenuClicked5()
        {
            CallMenuItem("Learning/3. QuickSummary/3. 导出UnityPackage并命名");
            OpenInFolder(Path.Combine(Application.dataPath, "../"));
        }
#endif

    }
}