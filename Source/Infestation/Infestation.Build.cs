// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Infestation : ModuleRules
{
	public Infestation(ReadOnlyTargetRules Target) : base(Target)
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
			"Infestation",
			"Infestation/Variant_Platforming",
			"Infestation/Variant_Platforming/Animation",
			"Infestation/Variant_Combat",
			"Infestation/Variant_Combat/AI",
			"Infestation/Variant_Combat/Animation",
			"Infestation/Variant_Combat/Gameplay",
			"Infestation/Variant_Combat/Interfaces",
			"Infestation/Variant_Combat/UI",
			"Infestation/Variant_SideScrolling",
			"Infestation/Variant_SideScrolling/AI",
			"Infestation/Variant_SideScrolling/Gameplay",
			"Infestation/Variant_SideScrolling/Interfaces",
			"Infestation/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
