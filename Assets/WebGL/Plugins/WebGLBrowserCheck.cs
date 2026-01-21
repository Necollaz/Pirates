using System;
using System.Runtime.InteropServices;
using UnityEngine;

public static class WebGLBrowserCheck
{
#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")]
    static extern bool IsMobilePlatform();
#endif
    
    public static bool IsMobileBrowser()
    {
// #if UNITY_EDITOR 
//         return false; // value to return in Play Mode (in the editor)
#if UNITY_WEBGL && !UNITY_EDITOR
        return IsMobilePlatform(); // value based on the current browser
#else
        return false;
#endif
    }
}