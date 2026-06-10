// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class UnrealRendering : ModuleRules
{
	public UnrealRendering(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"UnrealRendering",
			"UnrealRendering/Variant_Platforming",
			"UnrealRendering/Variant_Platforming/Animation",
			"UnrealRendering/Variant_Combat",
			"UnrealRendering/Variant_Combat/AI",
			"UnrealRendering/Variant_Combat/Animation",
			"UnrealRendering/Variant_Combat/Gameplay",
			"UnrealRendering/Variant_Combat/Interfaces",
			"UnrealRendering/Variant_Combat/UI",
			"UnrealRendering/Variant_SideScrolling",
			"UnrealRendering/Variant_SideScrolling/AI",
			"UnrealRendering/Variant_SideScrolling/Gameplay",
			"UnrealRendering/Variant_SideScrolling/Interfaces",
			"UnrealRendering/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
