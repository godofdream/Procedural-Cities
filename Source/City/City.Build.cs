// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class City : ModuleRules
{
	public City(ReadOnlyTargetRules Target) : base (Target)
	{
        PrivatePCHHeaderFile = "City.h";
        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "ProceduralMeshComponent", "RenderCore", "RHI"});
    }
}
