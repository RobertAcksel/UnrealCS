//GENERATED: C++ Code
#pragma once

class UGameViewportClient_
{
	static void SetConsoleTarget(UGameViewportClient* _this,int32 PlayerIndex)
	{
		_this->SetConsoleTarget(PlayerIndex);
		
	}
	static void ShowTitleSafeArea(UGameViewportClient* _this)
	{
		_this->ShowTitleSafeArea();
		
	}
	static void SSSwapControllers(UGameViewportClient* _this)
	{
		_this->SSSwapControllers();
		
	}
	static UClass* _StaticClassForProxy(){return UGameViewportClient::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UGameViewportClient::SetConsoleTarget",(const void*)SetConsoleTarget);
		mono_add_internal_call("UnrealEngine.UGameViewportClient::ShowTitleSafeArea",(const void*)ShowTitleSafeArea);
		mono_add_internal_call("UnrealEngine.UGameViewportClient::SSSwapControllers",(const void*)SSSwapControllers);
		mono_add_internal_call("UnrealEngine.UGameViewportClient::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;