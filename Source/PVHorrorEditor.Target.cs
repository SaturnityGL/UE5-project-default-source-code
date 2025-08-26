using UnrealBuildTool;
using System.Collections.Generic;

public class PVHorrorEditorTarget : TargetRules
{
    public PVHorrorEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
        ExtraModuleNames.AddRange(new string[] { "PVHorror" });
    }
}