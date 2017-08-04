//GENERATED: 
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
namespace UnrealEngine{
public partial class UBlueprintPlatformLibrary:UBlueprintFunctionLibrary 
{
[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void GetLaunchNotification(IntPtr _this,out int NotificationLaunchedApp,out string ActivationEvent,out int FireDate);
	public static void GetLaunchNotification(out bool NotificationLaunchedApp,out string ActivationEvent,out int FireDate)
	{
		int NotificationLaunchedApp_temp;
		GetLaunchNotification(IntPtr.Zero,out NotificationLaunchedApp_temp,out ActivationEvent,out FireDate);
		NotificationLaunchedApp=NotificationLaunchedApp_temp!=0;
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void CancelLocalNotification(IntPtr _this,string ActivationEvent);
	public static void CancelLocalNotification(string ActivationEvent)
	{
		CancelLocalNotification(IntPtr.Zero,ActivationEvent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ScheduleLocalNotificationFromNow(IntPtr _this,int inSecondsFromNow,string Title,string Body,string Action,string ActivationEvent);
	public static void ScheduleLocalNotificationFromNow(int inSecondsFromNow,string Title,string Body,string Action,string ActivationEvent)
	{
		ScheduleLocalNotificationFromNow(IntPtr.Zero,inSecondsFromNow,Title,Body,Action,ActivationEvent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ScheduleLocalNotificationAtTime(IntPtr _this,ref FDateTime FireDateTime,int LocalTime,string Title,string Body,string Action,string ActivationEvent);
	public static void ScheduleLocalNotificationAtTime(FDateTime FireDateTime,bool LocalTime,string Title,string Body,string Action,string ActivationEvent)
	{
		ScheduleLocalNotificationAtTime(IntPtr.Zero,ref FireDateTime,LocalTime?1:0,Title,Body,Action,ActivationEvent);
		
	}
	
	[MethodImplAttribute(MethodImplOptions.InternalCall)]
	static extern void ClearAllLocalNotifications(IntPtr _this);
	public static void ClearAllLocalNotifications()
	{
		ClearAllLocalNotifications(IntPtr.Zero);
		
	}
	
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
	public static extern new IntPtr StaticClass();
}
}
