//GENERATED: C++ Code
#pragma once

class UOnlineBlueprintCallProxyBase_
{
	static void Activate(UOnlineBlueprintCallProxyBase* _this)
	{
		_this->Activate();
		
	}
	static UClass* _StaticClassForProxy(){return UOnlineBlueprintCallProxyBase::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UOnlineBlueprintCallProxyBase::Activate",(const void*)Activate);
		mono_add_internal_call("UnrealEngine.UOnlineBlueprintCallProxyBase::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;