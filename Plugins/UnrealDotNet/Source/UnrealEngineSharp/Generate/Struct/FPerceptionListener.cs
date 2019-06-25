// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionTypes.h:238

namespace UnrealEngine
{
	public partial class FPerceptionListener : NativeStructWrapper
	{
		public FPerceptionListener(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPerceptionListener(UAIPerceptionComponent inListener) :
			base(E_CreateStruct_FPerceptionListener_UAIPerceptionComponent(inListener), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPerceptionListener_CachedDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPerceptionListener_CachedDirection_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPerceptionListener_CachedLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPerceptionListener_CachedLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPerceptionListener_Filter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPerceptionListener_Filter_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPerceptionListener_TeamIdentifier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPerceptionListener_TeamIdentifier_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPerceptionListener_UAIPerceptionComponent(IntPtr inListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPerceptionListener_CacheLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FPerceptionListener_GetBodyActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FPerceptionListener_GetBodyActorName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPerceptionListener_HasAnyNewStimuli(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPerceptionListener_ProcessStimuli(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPerceptionListener_UpdateListenerProperties(IntPtr self, IntPtr listener);
		
		#endregion
		
		#region Property
		public FVector CachedDirection
		{
			get => E_PROP_FPerceptionListener_CachedDirection_GET(NativePointer);
			set => E_PROP_FPerceptionListener_CachedDirection_SET(NativePointer, value);
		}

		public FVector CachedLocation
		{
			get => E_PROP_FPerceptionListener_CachedLocation_GET(NativePointer);
			set => E_PROP_FPerceptionListener_CachedLocation_SET(NativePointer, value);
		}

		public FPerceptionChannelWhitelist Filter
		{
			get => E_PROP_FPerceptionListener_Filter_GET(NativePointer);
			set => E_PROP_FPerceptionListener_Filter_SET(NativePointer, value);
		}

		public FGenericTeamId TeamIdentifier
		{
			get => E_PROP_FPerceptionListener_TeamIdentifier_GET(NativePointer);
			set => E_PROP_FPerceptionListener_TeamIdentifier_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void CacheLocation()
			=> E_FPerceptionListener_CacheLocation(this);
		
		
		/// <summary>
		/// Returns pointer to the actor representing this listener's physical body
		/// </summary>
		public AActor GetBodyActor()
			=> E_FPerceptionListener_GetBodyActor(this);
		
		public string GetBodyActorName()
			=> E_FPerceptionListener_GetBodyActorName(this);
		
		public bool HasAnyNewStimuli()
			=> E_FPerceptionListener_HasAnyNewStimuli(this);
		
		public void ProcessStimuli()
			=> E_FPerceptionListener_ProcessStimuli(this);
		
		public void UpdateListenerProperties(UAIPerceptionComponent listener)
			=> E_FPerceptionListener_UpdateListenerProperties(this, listener);
		
		#endregion
		
		public static implicit operator IntPtr(FPerceptionListener self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPerceptionListener(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPerceptionListener(adress, false);
		}}}
