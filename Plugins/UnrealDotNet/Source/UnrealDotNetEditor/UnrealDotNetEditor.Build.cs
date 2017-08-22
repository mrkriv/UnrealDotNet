using UnrealBuildTool;

public class UnrealDotNetEditor : ModuleRules
{
    public UnrealDotNetEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        PrivatePCHHeaderFile = "Private/UnrealDotNetEditorPCH.h";

        PublicIncludePaths.AddRange(
            new string[]
            {
                "UnrealDotNetEditor/Public"
            }
        );

        PrivateIncludePaths.AddRange(
            new string[]
            {
                "UnrealDotNetEditor/Private",
            }
        );

        PublicDependencyModuleNames.AddRange(
            new string[]
            {
                "Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "UnrealEd",
                "AssetTools",
                "ClassViewer",
                "KismetCompiler",
                "Kismet",
                "BlueprintGraph",
                "UMG",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
                "LevelEditor",
                "GameProjectGeneration",
                "MessageLog",
                "EditorStyle",
                "MainFrame",
                "SlateCore",
                "Slate"
            }
        );

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
            }
        );
    }
}
