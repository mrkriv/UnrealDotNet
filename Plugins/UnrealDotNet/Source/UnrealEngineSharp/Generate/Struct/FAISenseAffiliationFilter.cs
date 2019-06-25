// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionTypes.h:205

namespace UnrealEngine
{
	public partial class FAISenseAffiliationFilter : NativeStructWrapper
	{
		public FAISenseAffiliationFilter(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAISenseAffiliationFilter() :
			base(E_CreateStruct_FAISenseAffiliationFilter(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAISenseAffiliationFilter();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FAISenseAffiliationFilter_DetectAllFlags(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FAISenseAffiliationFilter_GetAsFlags(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAISenseAffiliationFilter_ShouldDetectAll(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAISenseAffiliationFilter_ShouldSenseTeam(IntPtr self, IntPtr teamA, IntPtr teamB, byte affiliationFlags);
		
		#endregion
		
		#region ExternMethods
		public byte DetectAllFlags()
			=> E_FAISenseAffiliationFilter_DetectAllFlags(this);
		
		public byte GetAsFlags()
			=> E_FAISenseAffiliationFilter_GetAsFlags(this);
		
		public bool ShouldDetectAll()
			=> E_FAISenseAffiliationFilter_ShouldDetectAll(this);
		
		public bool ShouldSenseTeam(FGenericTeamId teamA, FGenericTeamId teamB, byte affiliationFlags)
			=> E_FAISenseAffiliationFilter_ShouldSenseTeam(this, teamA, teamB, affiliationFlags);
		
		#endregion
		
		public static implicit operator IntPtr(FAISenseAffiliationFilter self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAISenseAffiliationFilter(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAISenseAffiliationFilter(adress, false);
		}}}
