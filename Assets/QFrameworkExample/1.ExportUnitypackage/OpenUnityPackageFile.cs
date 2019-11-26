using System.Collections;
using System.Collections.Generic;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace QFramework
{
    public class OpenUnityPackageFile
    {
#if UNITY_EDITOR
        [MenuItem("Learning/2. OpenInFolder %e")]
        private static void MenuClicked()
        {
            EditorApplication.ExecuteMenuItem("QFramework/1. ExportPackage");
            Application.OpenURL("file:///" + Path.Combine(Application.dataPath , "../"));
        }
#endif
    }
}
