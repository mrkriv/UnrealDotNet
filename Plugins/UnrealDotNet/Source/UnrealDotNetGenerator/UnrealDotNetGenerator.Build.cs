using System;
using System.IO;
using UnrealBuildTool;

public class UnrealDotNetGenerator : ModuleRules
{
    public UnrealDotNetGenerator(ReadOnlyTargetRules Target) : base(Target)
    {
        bEnforceIWYU = false;

        PublicIncludePaths.AddRange(
            new string[] {
                "Programs/UnrealHeaderTool/Public",
            }
        );

        PrivateIncludePaths.AddRange(
            new string[] {
              //  "Developer/ScriptGeneratorPlugin/Private",
            }
        );

        PublicDependencyModuleNames.AddRange(
            new string[] {
                "Core",
                "CoreUObject",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[] {
                "Projects",
            }
        );

        Definitions.Add("HACK_HEADER_GENERATOR=1");
    }
}
