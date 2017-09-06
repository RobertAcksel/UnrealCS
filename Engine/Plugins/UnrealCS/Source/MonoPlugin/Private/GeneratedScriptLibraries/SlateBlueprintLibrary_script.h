//GENERATED: C++ Code
#pragma once

class USlateBlueprintLibrary_
{
	static void ScreenToViewport(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FVector2D* ScreenPosition,FVector2D* ViewportPosition)
	{
		_this->ScreenToViewport(WorldContextObject,*ScreenPosition,*ViewportPosition);
		
	}
	static void ScreenToWidgetAbsolute(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FVector2D* ScreenPosition,FVector2D* AbsoluteCoordinate)
	{
		_this->ScreenToWidgetAbsolute(WorldContextObject,*ScreenPosition,*AbsoluteCoordinate);
		
	}
	static void ScreenToWidgetLocal(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FGeometry* Geometry,FVector2D* ScreenPosition,FVector2D* LocalCoordinate)
	{
		_this->ScreenToWidgetLocal(WorldContextObject,*Geometry,*ScreenPosition,*LocalCoordinate);
		
	}
	static void AbsoluteToViewport(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FVector2D* AbsoluteDesktopCoordinate,FVector2D* PixelPosition,FVector2D* ViewportPosition)
	{
		_this->AbsoluteToViewport(WorldContextObject,*AbsoluteDesktopCoordinate,*PixelPosition,*ViewportPosition);
		
	}
	static void LocalToViewport(USlateBlueprintLibrary* _this,UObject* WorldContextObject,FGeometry* Geometry,FVector2D* LocalCoordinate,FVector2D* PixelPosition,FVector2D* ViewportPosition)
	{
		_this->LocalToViewport(WorldContextObject,*Geometry,*LocalCoordinate,*PixelPosition,*ViewportPosition);
		
	}
	static int32 EqualEqual_SlateBrush(USlateBlueprintLibrary* _this,FSlateBrush* A,FSlateBrush* B)
	{
		bool ___ret = _this->EqualEqual_SlateBrush(*A,*B);
		return ___ret?1:0;
		
	}
	static FVector2D GetLocalSize(USlateBlueprintLibrary* _this,FGeometry* Geometry)
	{
		FVector2D ___ret = _this->GetLocalSize(*Geometry);
		return ___ret;
		
	}
	static FVector2D LocalToAbsolute(USlateBlueprintLibrary* _this,FGeometry* Geometry,FVector2D* LocalCoordinate)
	{
		FVector2D ___ret = _this->LocalToAbsolute(*Geometry,*LocalCoordinate);
		return ___ret;
		
	}
	static FVector2D AbsoluteToLocal(USlateBlueprintLibrary* _this,FGeometry* Geometry,FVector2D* AbsoluteCoordinate)
	{
		FVector2D ___ret = _this->AbsoluteToLocal(*Geometry,*AbsoluteCoordinate);
		return ___ret;
		
	}
	static int32 IsUnderLocation(USlateBlueprintLibrary* _this,FGeometry* Geometry,FVector2D* AbsoluteCoordinate)
	{
		bool ___ret = _this->IsUnderLocation(*Geometry,*AbsoluteCoordinate);
		return ___ret?1:0;
		
	}
	static UClass* _StaticClassForProxy(){return USlateBlueprintLibrary::StaticClass();}
	public:
	static void BindFunctions()
	{
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::ScreenToViewport",(const void*)ScreenToViewport);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::ScreenToWidgetAbsolute",(const void*)ScreenToWidgetAbsolute);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::ScreenToWidgetLocal",(const void*)ScreenToWidgetLocal);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::AbsoluteToViewport",(const void*)AbsoluteToViewport);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::LocalToViewport",(const void*)LocalToViewport);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::EqualEqual_SlateBrush",(const void*)EqualEqual_SlateBrush);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::GetLocalSize",(const void*)GetLocalSize);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::LocalToAbsolute",(const void*)LocalToAbsolute);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::AbsoluteToLocal",(const void*)AbsoluteToLocal);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::IsUnderLocation",(const void*)IsUnderLocation);
		mono_add_internal_call("UnrealEngine.USlateBlueprintLibrary::StaticClass",(const void*)_StaticClassForProxy);
		
	}
	
}
;