using UnrealBuildTool;
using System.Collections.Generic;

public class PVHorrorTarget : TargetRules
{
    public PVHorrorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
        // Optional if you were using it before:
        // bOverrideBuildEnvironment = true;
        ExtraModuleNames.AddRange(new string[] { "PVHorror" });
    }
}