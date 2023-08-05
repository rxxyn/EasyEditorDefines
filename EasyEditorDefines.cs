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
        /// <summary>
        /// Are you on the Unity Editor? 
        /// </summary>
        public static bool IsUnityEditor = false;
#endif

#if UNITY_EDITOR_WIN
        /// <summary>
        /// Is your Unity Editor platform Windows?
        /// </summary>
        public static bool IsUnityEditor_Win = true;
#else
        /// <summary>
        /// Is your Unity Editor platform Windows?
        /// </summary>
        public static bool IsUnityEditor_Win = false;
#endif

#if UNITY_EDITOR_OSX
        /// <summary>
        /// Is your Unity Editor platform OSX (Mac)?
        /// </summary>
        public static bool IsUnityEditor_Mac = true;
#else
        /// <summary>
        /// Is your Unity Editor platform OSX (Mac)?
        /// </summary>
        public static bool IsUnityEditor_Mac = false;
#endif

#if UNITY_EDITOR_LINUX
        /// <summary>
        /// Is your Unity Editor platform Linux?
        /// </summary>
        public static bool IsUnityEditor_Linux = true;
#else
        /// <summary>
        /// Is your Unity Editor platform Linux?
        /// </summary>
        public static bool IsUnityEditor_Linux = false;
#endif

#if UNITY_ANDROID
        /// <summary>
        /// Is your Build Platform set to Android?
        /// </summary>
        public static bool IsUnityGameAndroid = true;
#else
        /// <summary>
        /// Is your Build Platform set to Android?
        /// </summary>
        public static bool IsUnityGameAndroid = false;
#endif

#if UNITY_BUILD_64
        /// <summary>
        /// Is your Unity Build x64?
        /// </summary>
        public static bool IsUnityBuild64 = true;
#else
        /// <summary>
        /// Is your Unity Build x64?
        /// </summary>
        public static bool IsUnityBuild64 = false;
#endif

#if UNITY_SERVER
        /// <summary>
        /// Is the Unity Project in Server mode? (Normally used for Mirror)
        /// </summary>
        public static bool IsUnityServer = true;
#else
        /// <summary>
        /// Is the Unity Project in Server mode? (Normally used for Mirror)
        /// </summary>
        public static bool IsUnityServer = false;
#endif

#if UNITY_IOS
         /// <summary>
         /// Are you playing this Unity game on the IOS platform?
         /// </summary>
         public static bool IsUnityGameIOS = true;
#else
        /// <summary>
        /// Are you playing this Unity game on the IOS platform?
        /// </summary>
        public static bool IsUnityGameIOS = false;
#endif

#if UNITY_STANDALONE_OSX
        /// <summary>
        /// Are you playing this Unity game on the OSX platform?
        /// </summary>
         public static bool IsUnityGameOSX = true;
#else
        /// <summary>
        /// Are you playing this Unity game on the OSX platform?
        /// </summary>
        public static bool IsUnityGameOSX = false;
#endif

#if UNITY_STANDALONE_WIN
        /// <summary>
        /// Are you playing this Unity game on the Windows platform?
        /// </summary>
         public static bool IsUnityGameWin = true;
#else
        /// <summary>
        /// Are you playing this Unity game on the Windows platform?
        /// </summary>
        public static bool IsUnityGameWin = false;
#endif

#if UNITY_TVOS
        /// <summary>
        /// Are you playing this Unity game on the Apple TVOS platform?
        /// </summary>
         public static bool IsUnityGameTVOS = true;
#else
        /// <summary>
        /// Are you playing this Unity game on the Apple TVOS platform?
        /// </summary>
        public static bool IsUnityGameTVOS = false;
#endif

#if UNITY_STANDALONE
        /// <summary>
        /// Are you playing this Unity game? (Any Platform)
        /// </summary>
         public static bool IsUnityGame = true;
#else
        /// <summary>
        /// Are you playing this Unity game? (Any Platform)
        /// </summary>
        public static bool IsUnityGame = false;
#endif
    }
}
