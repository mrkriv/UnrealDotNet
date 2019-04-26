// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\UnitConversion.h:74

namespace UnrealEngine
{
	public  partial class FUnitSettings : NativeStructWrapper
	{
		internal FUnitSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FUnitSettings() :
			base(E_CreateStruct_FUnitSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FUnitSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FUnitSettings_SetDisplayUnits(IntPtr self, byte inType, byte units);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FUnitSettings_SetShouldDisplayUnits(IntPtr self, bool bInGlobalUnitDisplay);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FUnitSettings_ShouldDisplayUnits(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public void SetDisplayUnits(EUnitType inType, EUnit units)
			=> E_FUnitSettings_SetDisplayUnits(this, (byte)inType, (byte)units);
		
		public void SetShouldDisplayUnits(bool bInGlobalUnitDisplay)
			=> E_FUnitSettings_SetShouldDisplayUnits(this, bInGlobalUnitDisplay);
		
		
		/// <summary>
		/// <para>Check whether unit display is globally enabled or disabled </para>
		/// </summary>
		public bool ShouldDisplayUnits()
			=> E_FUnitSettings_ShouldDisplayUnits(this);
		
		#endregion
		
		public static implicit operator IntPtr(FUnitSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FUnitSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FUnitSettings(Adress, false);
		}}}
