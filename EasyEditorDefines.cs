namespace EasyEditorDefines
{
    public static class EasyEditorDefines
    {
#if UNITY_EDITOR
        /// <summary>
        /// Are you on the Unity Editor?
        /// </summary>
        public static bool IsUnityEditor = true;
#else
        public static bool IsUnityEditor = false;
#endif

#if UNITY_EDITOR_WIN
        /// <summary>
        /// Is your Unity Editor platform Windows?
        /// </summary>
        public static bool IsUnityEditor_Win = true;
#else
        public static bool IsUnityEditor_Win = false;
#endif

#if UNITY_ANDROID
        /// <summary>
        /// Is your Build Platform set to Android?
        /// </summary>
        public static bool IsUnityGameAndroid = true;
#else
        public static bool IsUnityGameAndroid = false;
#endif

#if UNITY_BUILD_64
        public static bool IsUnityBuild64 = true;
#else
        /// <summary>
        /// Is your Unity Build x64?
        /// </summary>
        public static bool IsUnityBuild64 = false;
#endif

    }
}