using UnrealBuildTool;

public class MyProject12Target : TargetRules
{
	public MyProject12Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyProject12");
	}
}
