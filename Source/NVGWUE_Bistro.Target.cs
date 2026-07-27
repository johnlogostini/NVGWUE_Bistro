// Copyright JohnLogostini. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class NVGWUE_BistroTarget : TargetRules
{
	public NVGWUE_BistroTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "NVGWUE_Bistro" } );
	}
}