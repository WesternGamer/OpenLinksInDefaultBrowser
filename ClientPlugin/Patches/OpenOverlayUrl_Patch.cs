using HarmonyLib;
using Sandbox.Graphics.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClientPlugin.Patches
{
    [HarmonyPatch]
    internal static class OpenOverlayUrl_Patch
    {
        private static MethodInfo TargetMethod()
        {
            return AccessTools.Method("VRage.Steam.MySteamService:OpenOverlayUrl");
        }

        private static bool Prefix(string url)
        {
            MyGuiSandbox.OpenUrl(url, UrlOpenMode.ExternalBrowser);
            return false;
        }
    }
}
