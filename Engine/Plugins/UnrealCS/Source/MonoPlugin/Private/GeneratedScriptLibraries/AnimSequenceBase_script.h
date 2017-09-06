//GENERATED: C++ Code
#pragma once

class UAnimSequenceBase_
{
	static float GetPlayLength(UAnimSequenceBase* _this)
	{
		float ___ret = _this->GetPlayLength();
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UAnimSequenceBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UAnimSequenceBase::GetPlayLength",(const void*)GetPlayLength);
		mono_add_internal_call("UnrealEngine.UAnimSequenceBase::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;