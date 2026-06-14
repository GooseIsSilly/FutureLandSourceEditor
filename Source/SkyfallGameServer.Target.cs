// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class SkyfallGameServerTarget : TargetRules
{
	public SkyfallGameServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange(new string[] { "SkyfallGame" });
        bOverrideBuildEnvironment = true;
        AdditionalCompilerArguments = "/wd4668";
    }
}
