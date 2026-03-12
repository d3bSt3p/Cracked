// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Cracked : ModuleRules
{
	public Cracked(ReadOnlyTargetRules Target) : base(Target)
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
			"Cracked",
			"Cracked/Variant_Platforming",
			"Cracked/Variant_Platforming/Animation",
			"Cracked/Variant_Combat",
			"Cracked/Variant_Combat/AI",
			"Cracked/Variant_Combat/Animation",
			"Cracked/Variant_Combat/Gameplay",
			"Cracked/Variant_Combat/Interfaces",
			"Cracked/Variant_Combat/UI",
			"Cracked/Variant_SideScrolling",
			"Cracked/Variant_SideScrolling/AI",
			"Cracked/Variant_SideScrolling/Gameplay",
			"Cracked/Variant_SideScrolling/Interfaces",
			"Cracked/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
