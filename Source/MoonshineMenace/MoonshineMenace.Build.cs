// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MoonshineMenace : ModuleRules
{
    public MoonshineMenace(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicIncludePaths.AddRange(new string[]
        {
            "MoonshineMenace"
        });

        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core",
            "CoreUObject",
            "Engine",
            "InputCore",
            "HeadMountedDisplay",
            "NavigationSystem",
            "AIModule",
            "Niagara",
            "GameplayAbilities",
            "GameplayTags",
            "GameplayTasks",
            "Paper2D"
        });
    }
}
