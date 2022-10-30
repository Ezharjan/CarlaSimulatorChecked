// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class CarlaUE4EditorTarget : TargetRules
{
	public CarlaUE4EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		//DefaultBuildSettings = BuildSettingsVersion.V2;//Alexander wants to add this line but commented
		ExtraModuleNames.Add("CarlaUE4");
	}
}
