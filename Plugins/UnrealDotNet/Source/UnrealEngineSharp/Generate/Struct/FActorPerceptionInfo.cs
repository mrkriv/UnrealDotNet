// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionComponent.h:24

namespace UnrealEngine
{
	public partial class FActorPerceptionInfo : NativeStructWrapper
	{
		public FActorPerceptionInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FActorPerceptionInfo(AActor inTarget) :
			base(E_CreateStruct_FActorPerceptionInfo_AActor(inTarget), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorPerceptionInfo_AActor(IntPtr inTarget);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FActorPerceptionInfo_HasAnyCurrentStimulus(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FActorPerceptionInfo_HasAnyKnownStimulus(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FActorPerceptionInfo_Merge(IntPtr self, IntPtr other);
		
		#endregion
		
		#region ExternMethods
		public bool HasAnyCurrentStimulus()
			=> E_FActorPerceptionInfo_HasAnyCurrentStimulus(this);
		
		
		/// <summary>
		/// it includes both currently live (visible) stimulus, as well as "remembered" ones
		/// </summary>
		public bool HasAnyKnownStimulus()
			=> E_FActorPerceptionInfo_HasAnyKnownStimulus(this);
		
		
		/// <summary>
		/// takes all "newer" info from Other and absorbs it
		/// </summary>
		public void Merge(FActorPerceptionInfo other)
			=> E_FActorPerceptionInfo_Merge(this, other);
		
		#endregion
		
		public static implicit operator IntPtr(FActorPerceptionInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FActorPerceptionInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FActorPerceptionInfo(adress, false);
		}}}
