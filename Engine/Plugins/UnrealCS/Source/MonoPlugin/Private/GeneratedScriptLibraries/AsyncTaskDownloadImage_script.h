//GENERATED: C++ Code
#pragma once

class UAsyncTaskDownloadImage_
{
	static UAsyncTaskDownloadImage* DownloadImage(UAsyncTaskDownloadImage* _this,MonoString* URL)
	{
		FString URL_temp=MonoStringToFString(URL);
		UAsyncTaskDownloadImage* ___ret = _this->DownloadImage(URL_temp);
		return ___ret;
		
	}
	static UClass* _StaticClassForProxy(){return UAsyncTaskDownloadImage::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.UAsyncTaskDownloadImage::DownloadImage",(const void*)DownloadImage);
		mono_add_internal_call("UnrealEngine.UAsyncTaskDownloadImage::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;