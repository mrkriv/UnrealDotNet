

using UnrealBuildTool;
using System.Collections.Generic;

public class DotUnrealExampleEditorTarget : TargetRules
{
	public DotUnrealExampleEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "DotUnrealExample" } );
	}
}
