//GENERATED: C++ Code
#pragma once

class UGameInstance_
{
	static void DebugRemovePlayer(UGameInstance* _this,int32 ControllerId)
	{
		_this->DebugRemovePlayer(ControllerId);
		
	}
	static void DebugCreatePlayer(UGameInstance* _this,int32 ControllerId)
	{
		_this->DebugCreatePlayer(ControllerId);
		
	}
	static UClass* _StaticClassForProxy(){return UGameInstance::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UGameInstance::DebugRemovePlayer",(const void*)DebugRemovePlayer);
		mono_add_internal_call("UnrealEngine.UGameInstance::DebugCreatePlayer",(const void*)DebugCreatePlayer);
		mono_add_internal_call("UnrealEngine.UGameInstance::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;