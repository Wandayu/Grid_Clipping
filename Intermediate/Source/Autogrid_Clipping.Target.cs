using UnrealBuildTool;

public class Autogrid_ClippingTarget : TargetRules
{
	public Autogrid_ClippingTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Autogrid_Clipping");
	}
}
