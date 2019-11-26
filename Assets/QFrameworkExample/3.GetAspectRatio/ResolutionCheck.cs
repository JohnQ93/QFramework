using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

namespace QFramework
{
    public class ResolutionCheck : MonoBehaviour
    {
#if UNITY_EDITOR
        [MenuItem("Learning/4. GetAspectRatio")]
#endif
        private static void MenuClicked()
        {
            Debug.Log(IsPadResolution() ? "是Pad" : "不是Pad");
            Debug.Log(IsPhoneResolution() ? "是Phone" : "不是Phone");
            Debug.Log(IsiPhone4sResolution() ? "是iPhone4s" : "不是iPhone4s");
            Debug.Log(IsiPhoneXResolution() ? "是iPhoneX" : "不是iPhoneX");
        }

        public static float GetAspectRatio()
        {
            //UnityEditor模式下屏幕宽高可能会读取错误
            var isLandscape = Screen.width > Screen.height;
            return isLandscape ? (float)Screen.width / Screen.height : (float)Screen.height / Screen.width;
        }

        public static bool InAspectRange(float dstAspectRatio)
        {
            var aspect = GetAspectRatio();
            return aspect > (dstAspectRatio - 0.05) && aspect < (dstAspectRatio + 0.05);
        }

        public static bool IsPadResolution()
        {
            return InAspectRange(4.0f / 3);
        }

        public static bool IsPhoneResolution()
        {
            return InAspectRange(16.0f / 9);
        }

        public static bool IsiPhone4sResolution()
        {
            return InAspectRange(3.0f / 2);
        }

        public static bool IsiPhoneXResolution()
        {
            return InAspectRange(2436.0f / 1125);
        }
    }
}