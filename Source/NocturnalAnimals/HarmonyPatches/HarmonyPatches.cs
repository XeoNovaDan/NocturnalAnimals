using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using Verse;
using RimWorld;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;

namespace NocturnalAnimals
{

    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        
        static HarmonyPatches()
        {
            //Harmony.DEBUG = true;
            NocturnalAnimals.HarmonyInstance.PatchAll();
        }

    }

}
