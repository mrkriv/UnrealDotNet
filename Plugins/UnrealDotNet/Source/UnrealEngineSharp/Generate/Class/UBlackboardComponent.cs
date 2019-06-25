// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BlackboardComponent.h:41

namespace UnrealEngine
{
	public partial class UBlackboardComponent : UActorComponent
	{
		public UBlackboardComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UBlackboardComponent(UObject Parent = null, string Name = "BlackboardComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBlackboardComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBlackboardComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_CacheBrainComponent(IntPtr self, IntPtr brainComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_ClearValue(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBlackboardComponent_GetBrainComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBlackboardComponent_GetLocationFromEntry(IntPtr self, string keyName, IntPtr resultLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBlackboardComponent_GetNumKeys(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBlackboardComponent_GetRotationFromEntry(IntPtr self, string keyName, IntPtr resultRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBlackboardComponent_GetValueAsBool(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UBlackboardComponent_GetValueAsEnum(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UBlackboardComponent_GetValueAsFloat(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBlackboardComponent_GetValueAsInt(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBlackboardComponent_GetValueAsName(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBlackboardComponent_GetValueAsObject(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBlackboardComponent_GetValueAsRotator(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBlackboardComponent_GetValueAsString(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBlackboardComponent_GetValueAsVector(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBlackboardComponent_HasValidAsset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBlackboardComponent_IsVectorValueSet(IntPtr self, string keyName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_PauseObserverNotifications(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_PauseUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_ResumeObserverNotifications(IntPtr self, bool bSendQueuedObserverNotifications);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_ResumeUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsBool(IntPtr self, string keyName, bool boolValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsEnum(IntPtr self, string keyName, byte enumValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsFloat(IntPtr self, string keyName, float floatValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsInt(IntPtr self, string keyName, int intValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsName(IntPtr self, string keyName, string nameValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsObject(IntPtr self, string keyName, IntPtr objectValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsRotator(IntPtr self, string keyName, IntPtr vectorValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsString(IntPtr self, string keyName, string stringValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_SetValueAsVector(IntPtr self, string keyName, IntPtr vectorValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBlackboardComponent_UnregisterObserversFrom(IntPtr self, IntPtr notifyOwner);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// caches UBrainComponent pointer to be used in communication
		/// </summary>
		public void CacheBrainComponent(UBrainComponent brainComponent)
			=> E_UBlackboardComponent_CacheBrainComponent(this, brainComponent);
		
		public void ClearValue(string keyName)
			=> E_UBlackboardComponent_ClearValue(this, keyName);
		
		
		/// <summary>
		/// </summary>
		/// <return>associated</return>
		public UBrainComponent GetBrainComponent()
			=> E_UBlackboardComponent_GetBrainComponent(this);
		
		
		/// <summary>
		/// return false if call failed (most probably no such entry in BB)
		/// </summary>
		public bool GetLocationFromEntry(string keyName, FVector resultLocation)
			=> E_UBlackboardComponent_GetLocationFromEntry(this, keyName, resultLocation);
		
		
		/// <summary>
		/// </summary>
		/// <return>number</return>
		public int GetNumKeys()
			=> E_UBlackboardComponent_GetNumKeys(this);
		
		
		/// <summary>
		/// return false if call failed (most probably no such entry in BB)
		/// </summary>
		public bool GetRotationFromEntry(string keyName, FRotator resultRotation)
			=> E_UBlackboardComponent_GetRotationFromEntry(this, keyName, resultRotation);
		
		public bool GetValueAsBool(string keyName)
			=> E_UBlackboardComponent_GetValueAsBool(this, keyName);
		
		public byte GetValueAsEnum(string keyName)
			=> E_UBlackboardComponent_GetValueAsEnum(this, keyName);
		
		public float GetValueAsFloat(string keyName)
			=> E_UBlackboardComponent_GetValueAsFloat(this, keyName);
		
		public int GetValueAsInt(string keyName)
			=> E_UBlackboardComponent_GetValueAsInt(this, keyName);
		
		public string GetValueAsName(string keyName)
			=> E_UBlackboardComponent_GetValueAsName(this, keyName);
		
		public UObject GetValueAsObject(string keyName)
			=> E_UBlackboardComponent_GetValueAsObject(this, keyName);
		
		public FRotator GetValueAsRotator(string keyName)
			=> E_UBlackboardComponent_GetValueAsRotator(this, keyName);
		
		public string GetValueAsString(string keyName)
			=> E_UBlackboardComponent_GetValueAsString(this, keyName);
		
		public FVector GetValueAsVector(string keyName)
			=> E_UBlackboardComponent_GetValueAsVector(this, keyName);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool HasValidAsset()
			=> E_UBlackboardComponent_HasValidAsset(this);
		
		public bool IsVectorValueSet(string keyName)
			=> E_UBlackboardComponent_IsVectorValueSet(this, keyName);
		
		
		/// <summary>
		/// pause observer change notifications, any new ones will be added to a queue
		/// </summary>
		public void PauseObserverNotifications()
			=> E_UBlackboardComponent_PauseObserverNotifications(this);
		
		
		/// <summary>
		/// pause change notifies and add them to queue
		/// </summary>
		public void PauseUpdates()
			=> E_UBlackboardComponent_PauseUpdates(this);
		
		
		/// <summary>
		/// resume observer change notifications and, optionally, process the queued observation list
		/// </summary>
		public void ResumeObserverNotifications(bool bSendQueuedObserverNotifications)
			=> E_UBlackboardComponent_ResumeObserverNotifications(this, bSendQueuedObserverNotifications);
		
		
		/// <summary>
		/// resume change notifies and process queued list
		/// </summary>
		public void ResumeUpdates()
			=> E_UBlackboardComponent_ResumeUpdates(this);
		
		public void SetValueAsBool(string keyName, bool boolValue)
			=> E_UBlackboardComponent_SetValueAsBool(this, keyName, boolValue);
		
		public void SetValueAsEnum(string keyName, byte enumValue)
			=> E_UBlackboardComponent_SetValueAsEnum(this, keyName, enumValue);
		
		public void SetValueAsFloat(string keyName, float floatValue)
			=> E_UBlackboardComponent_SetValueAsFloat(this, keyName, floatValue);
		
		public void SetValueAsInt(string keyName, int intValue)
			=> E_UBlackboardComponent_SetValueAsInt(this, keyName, intValue);
		
		public void SetValueAsName(string keyName, string nameValue)
			=> E_UBlackboardComponent_SetValueAsName(this, keyName, nameValue);
		
		public void SetValueAsObject(string keyName, UObject objectValue)
			=> E_UBlackboardComponent_SetValueAsObject(this, keyName, objectValue);
		
		public void SetValueAsRotator(string keyName, FRotator vectorValue)
			=> E_UBlackboardComponent_SetValueAsRotator(this, keyName, vectorValue);
		
		public void SetValueAsString(string keyName, string stringValue)
			=> E_UBlackboardComponent_SetValueAsString(this, keyName, stringValue);
		
		public void SetValueAsVector(string keyName, FVector vectorValue)
			=> E_UBlackboardComponent_SetValueAsVector(this, keyName, vectorValue);
		
		
		/// <summary>
		/// unregister all observers associated with given owner
		/// </summary>
		public void UnregisterObserversFrom(UObject notifyOwner)
			=> E_UBlackboardComponent_UnregisterObserversFrom(this, notifyOwner);
		
		#endregion
		
		public static implicit operator IntPtr(UBlackboardComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBlackboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBlackboardComponent>(PtrDesc);
		}}}
