using System.IO;
using UnrealBuildTool;

public class UnrealDotNetRuntime : ModuleRules
{
    public UnrealDotNetRuntime(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        bEnforceIWYU = false;

        PublicIncludePaths.AddRange(
            new string[]
            {
                "Runtime/UMG/Public"
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
                "Engine",
                "Core",
                "CoreUObject",
                "SlateCore",
                "Slate",
                "InputCore",
                "Messaging",
                "RenderCore",
                "RHI",
                "UtilityShaders",
                "AssetRegistry",
                "EngineMessages",
                "EngineSettings",
                "SynthBenchmark",
                "GameplayTags",
                "AIModule",
                "DatabaseSupport",
                "PacketHandler",
                "HardwareSurvey",
                "Json",
                "JsonUtilities",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "AppFramework",
                "UMG",
                "Projects",
                "Analytics",
                "AnalyticsET"
            }
        );

        //if (UEBuildConfiguration.bBuildEditor == true)
        if (Target.Type == TargetRules.TargetType.Editor)
        {
            PrivateDependencyModuleNames.AddRange(
                new string[]
                {
                    "DirectoryWatcher"
                }
            );

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

        if (Target.Type != TargetRules.TargetType.Editor)
        {
            string BaseDirectory = Path.GetFullPath(Path.Combine(ModuleDirectory, "..", ".."));
            string GameLogicDLLDirectory = Path.Combine(BaseDirectory, "Dotnet", "GameLogic");
            string DotnetDLLDirectory = Path.Combine(BaseDirectory, "Dotnet", "2.0.0");

            foreach (string Plugin in Directory.EnumerateFiles(GameLogicDLLDirectory, "*.dll", SearchOption.AllDirectories))
            {
                RuntimeDependencies.Add(new RuntimeDependency(Path.Combine(GameLogicDLLDirectory, Plugin)));
            }

            foreach (string Plugin in Directory.EnumerateFiles(DotnetDLLDirectory, "*.dll", SearchOption.AllDirectories))
            {
                RuntimeDependencies.Add(new RuntimeDependency(Path.Combine(DotnetDLLDirectory, Plugin)));
            }
        }
    }
}