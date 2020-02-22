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

    public class ExtendedRaceProperties : DefModExtension
    {

        public BodyClock bodyClock;

        public static ExtendedRaceProperties Get(Def def)
        {
            return def.GetModExtension<ExtendedRaceProperties>();
        }

    }

}
