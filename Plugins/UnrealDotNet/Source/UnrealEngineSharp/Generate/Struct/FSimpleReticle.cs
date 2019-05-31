// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SimpleReticle.h:12

namespace UnrealEngine
{
	public  partial class FSimpleReticle : NativeStructWrapper
	{
		internal FSimpleReticle(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSimpleReticle() :
			base(E_CreateStruct_FSimpleReticle(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSimpleReticle();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSimpleReticle_Draw(IntPtr self, IntPtr inCanvas, IntPtr inColor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSimpleReticle_SetupReticle(IntPtr self, float length, float innerSize);
		
		#endregion
		
		#region ExternMethods
		public void Draw(UCanvas inCanvas, FLinearColor inColor)
			=> E_FSimpleReticle_Draw(this, inCanvas, inColor);
		
		public void SetupReticle(float length, float innerSize)
			=> E_FSimpleReticle_SetupReticle(this, length, innerSize);
		
		#endregion
		
		public static implicit operator IntPtr(FSimpleReticle self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSimpleReticle(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSimpleReticle(adress, false);
		}}}
