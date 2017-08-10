using UnrealBuildTool;

public class UnrealDotNetRuntime : ModuleRules
{
    public UnrealDotNetRuntime(ReadOnlyTargetRules Target) : base(Target)
    {
        bEnforceIWYU = false;

        PublicIncludePaths.AddRange(
            new string[]
            {
                "Runtime/UMG/Public",
                "UnrealDotNetRuntime/Public"
            }
        );


        PrivateIncludePaths.AddRange(
            new string[]
            {
                "UnrealDotNetRuntime/Private",
            }
        );


        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
            }
        );


        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "SlateCore",
                "NetworkReplayStreaming",
                "AIModule",
                "PacketHandler",
                "MovieSceneTracks",
                "MovieScene",
                "Slate",
                "UMG",
                "GeometryCache",
                "Niagara",
                "MediaAssets",
                "Projects"
            }
        );
        
        if (UEBuildConfiguration.bBuildEditor == true)
        {

            PublicDependencyModuleNames.AddRange(
                new string[]
                {
                    "UnrealEd",
                }
            );

        }

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
            }
        );
    }
}
