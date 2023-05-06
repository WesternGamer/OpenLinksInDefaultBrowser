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
    internal static class OpenOverlayUser_Patch
    {
        private static MethodInfo TargetMethod()
        {
            return AccessTools.Method("VRage.Steam.MySteamService:OpenOverlayUser");
        }

        private static bool Prefix(ulong id)
        {
            MyGuiSandbox.OpenUrl($"https://steamcommunity.com/profiles/{id}", UrlOpenMode.ExternalBrowser);
            return false;
        }
    }
}
