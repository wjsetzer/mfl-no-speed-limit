using BepInEx;
using HarmonyLib;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using System.Diagnostics.Contracts;
using System;

namespace NoSpeedLimit;

[BepInPlugin("com.github.wjsetzer.NoSpeedLimit", "No Speed Limit", "0.1.0")]
public class Plugin : BasePlugin
{
    public static new ManualLogSource Log;

    public static Plugin? Instance { get; private set; }

    // public static float BaseGroundSpeedLimit;
    // public static float BaseAirSpeedLimit;

    public override void Load()
    {
        // Plugin startup logic
        Log = base.Log;
        // AddComponent<Component>();

        Instance = this;

        var harmony = new Harmony("com.github.wjsetzer.NoSpeedLimit");
        harmony.PatchAll();

        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

    }

    public override bool Unload()
    {
        // Conf.s.maxGroundSpeed = BaseGroundSpeedLimit;

        // Conf.s.maxAirSpeed = BaseAirSpeedLimit;
        Log.LogInfo($"Plugin No Speed Limit unloaded. Speed limits set to default values");

        Instance = null;
        return true;
    }
}
