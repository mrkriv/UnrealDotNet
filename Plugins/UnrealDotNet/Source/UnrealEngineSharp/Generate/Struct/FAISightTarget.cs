// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Sight.h:49

namespace UnrealEngine
{
	public partial class FAISightTarget : NativeStructWrapper
	{
		public FAISightTarget(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAISightTarget(AActor inTarget, FGenericTeamId inTeamId) :
			base(E_CreateStruct_FAISightTarget_AActor_FGenericTeamId(inTarget, inTeamId), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAISightTarget_TeamId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightTarget_TeamId_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAISightTarget_AActor_FGenericTeamId(IntPtr inTarget, IntPtr inTeamId);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAISightTarget_GetLocationSimple(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FAISightTarget_GetTargetActor(IntPtr self);
		
		#endregion
		
		#region Property
		public FGenericTeamId TeamId
		{
			get => E_PROP_FAISightTarget_TeamId_GET(NativePointer);
			set => E_PROP_FAISightTarget_TeamId_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public FVector GetLocationSimple()
			=> E_FAISightTarget_GetLocationSimple(this);
		
		public AActor GetTargetActor()
			=> E_FAISightTarget_GetTargetActor(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAISightTarget self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAISightTarget(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAISightTarget(adress, false);
		}}}
