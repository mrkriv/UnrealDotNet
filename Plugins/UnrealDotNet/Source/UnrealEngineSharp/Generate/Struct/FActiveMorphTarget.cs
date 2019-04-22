// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:103

namespace UnrealEngine
{
	public  partial class FActiveMorphTarget : NativeStructWrapper
	{
		internal FActiveMorphTarget(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActiveMorphTarget() :
			base(E_CreateStruct_FActiveMorphTarget(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FActiveMorphTarget_WeightIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActiveMorphTarget_WeightIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActiveMorphTarget();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Index into the array of weights for the Morph target, between 0.0 and 1.0. </para>
		/// </summary>
		public int WeightIndex
		{
			get => E_PROP_FActiveMorphTarget_WeightIndex_GET(NativePointer);
			set => E_PROP_FActiveMorphTarget_WeightIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActiveMorphTarget self)
		{
			return self.NativePointer;
		}

		public static implicit operator FActiveMorphTarget(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActiveMorphTarget(Adress, false);
		}}}
