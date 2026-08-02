using HarmonyLib;
using Iced.Intel;
using UnityEngine;

namespace NoSpeedLimit;

[HarmonyPatch(typeof(Vehicle), nameof(Vehicle.ComputeVelocityAndCapSpeed))]
class Patch
{

    public static TextMesh textMesh = null;

    static void Prefix(Vehicle __instance)
    {
        Plugin.Log.LogInfo("Speed: " + __instance.vehicleSpeed + ", MaxSpeed: " + __instance.maxSpeed);
        __instance.maxSpeed = 10000.0F;


        if (textMesh == null)
        {
            var ui = GameObject.Find("UI");
            var text = new GameObject("TextTest");
            text.transform.SetParent(ui.transform);
            text.layer = ui.layer;
            textMesh = text.AddComponent<TextMesh>();

            textMesh.fontSize = 20;
            textMesh.characterSize = 0.1f;
            textMesh.anchor = TextAnchor.UpperLeft;
            textMesh.alignment = TextAlignment.Left;

            textMesh.transform.localPosition = new Vector3(-8f, 4.5f, 0);
        }
        // textMesh.text = "THIS IS A GREAKING TEST";
        textMesh.text = "Speed: " + System.Math.Round(__instance.vehicleSpeed, 2);
    }
}
