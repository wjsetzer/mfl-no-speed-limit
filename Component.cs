using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx.Unity.IL2CPP;
using UnityEngine;

namespace NoSpeedLimit;

public class Component: MonoBehaviour
{
    void Start()
    {
        // Plugin.BaseGroundSpeedLimit = Conf.s.maxGroundSpeed;
        // Plugin.BaseAirSpeedLimit = Conf.s.maxAirSpeed;

        // Conf.s.maxGroundSpeed = float.MaxValue;
        // Conf.s.maxAirSpeed = float.MaxValue;
    }
}