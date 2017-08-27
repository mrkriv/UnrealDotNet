using System.IO;
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
                "Engine",
                "CoreUObject",
                "Engine",
                "InputCore",
                "SlateCore",
                "UMG",
            }
        );

        if (UEBuildConfiguration.bBuildEditor == true)
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