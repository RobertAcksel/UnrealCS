// Copyright xg_55,All Rights Reserved.Support E-mail: xg_55@126.com
// For details, see LICENSE.txt

#pragma once

namespace UnrealEngine
{
	class _UClass_Ext
	{
		static  MonoString* GetClassNameCpp(UClass* Class)
		{
			return FStringToMonoString(FString::Printf(TEXT("%s%s"), Class->GetPrefixCPP(), *Class->GetName()));
		}
	public:
		static  void BindFunctions()
		{
			mono_add_internal_call("UnrealEngine.UClass::GetClassNameCpp", (const void*)GetClassNameCpp);
		}
	};
}
