using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using VRageMath;
using VRage.Game;
using Sandbox.ModAPI.Interfaces;
using Sandbox.ModAPI.Ingame;
using Sandbox.Game.EntityComponents;
using VRage.Game.Components;
using VRage.Collections;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game.ModAPI.Ingame;
using SpaceEngineers.Game.ModAPI.Ingame;
public sealed class Program : MyGridProgram
{
    IMyTextPanel LCD;
    IMyTerminalBlock Turret;
    int i = 0;
    public Program()
    {
        LCD = GridTerminalSystem.GetBlockWithName("LCD") as IMyTextPanel;
        Turret = GridTerminalSystem.GetBlockWithName("Turret") as IMyTerminalBlock;
        Runtime.UpdateFrequency = UpdateFrequency.Update1;
    }

    public void Main(string args)
    {
        Turret.ApplyAction("ShootOnce");

        LCD = GridTerminalSystem.GetBlockWithName("LCD") as IMyTextPanel;
        if (LCD != null)
        {
            i++;
            Echo(i.ToString());
        }
    }

    public void Save()
    { }

}