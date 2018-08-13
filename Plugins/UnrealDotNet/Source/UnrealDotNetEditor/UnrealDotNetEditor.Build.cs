using UnrealBuildTool;

public class UnrealDotNetEditor : ModuleRules
{
    public UnrealDotNetEditor(ReadOnlyTargetRules Target) : base(Target)
    {
        //bEnforceIWYU = false;
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
                "LevelEditor",
                "GameProjectGeneration",
                "MessageLog",
                "EditorStyle",
                "MainFrame",
                "SlateCore",
                "Slate",
                "PropertyEditor",
                "PlacementMode",
                "UnrealDotNetRuntime",
                "Json",
                "JsonUtilities",
            }
        );

        PrivateDependencyModuleNames.AddRange(
            new string[]
            {
            }
        );

        DynamicallyLoadedModuleNames.AddRange(
            new string[]
            {
            }
        );
    }
}