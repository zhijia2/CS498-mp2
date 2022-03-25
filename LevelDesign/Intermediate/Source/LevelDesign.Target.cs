using UnrealBuildTool;

public class LevelDesignTarget : TargetRules
{
	public LevelDesignTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("LevelDesign");
	}
}
