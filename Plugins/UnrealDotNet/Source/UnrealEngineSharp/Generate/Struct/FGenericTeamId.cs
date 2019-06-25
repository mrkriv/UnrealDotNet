// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\GenericTeamAgentInterface.h:23

namespace UnrealEngine
{
	public partial class FGenericTeamId : NativeStructWrapper
	{
		public FGenericTeamId(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FGenericTeamId(byte inTeamID) :
			base(E_CreateStruct_FGenericTeamId_uint8(inTeamID), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGenericTeamId_uint8(byte inTeamID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FGenericTeamId_GetId(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FGenericTeamId_GetTeamIdentifier(IntPtr self, IntPtr teamMember);
		
		#endregion
		
		#region ExternMethods
		public byte GetId()
			=> E_FGenericTeamId_GetId(this);
		
		public FGenericTeamId GetTeamIdentifier(AActor teamMember)
			=> E_FGenericTeamId_GetTeamIdentifier(this, teamMember);
		
		#endregion
		
		public static implicit operator IntPtr(FGenericTeamId self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FGenericTeamId(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FGenericTeamId(adress, false);
		}}}
