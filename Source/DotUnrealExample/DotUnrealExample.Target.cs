

using UnrealBuildTool;
using System.Collections.Generic;

public class DotUnrealExampleTarget : TargetRules
{
	public DotUnrealExampleTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "DotUnrealExample" } );
	}
}
