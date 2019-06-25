// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_MakeNoise.h:15

namespace UnrealEngine
{
	public partial class UBTTask_MakeNoise : UBTTaskNode
	{
		public UBTTask_MakeNoise(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_MakeNoise(UObject Parent = null, string Name = "BTTask_MakeNoise")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_MakeNoise(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTTask_MakeNoise_Loudnes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_MakeNoise_Loudnes_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_MakeNoise(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Loudnes of generated noise
		/// </summary>
		public float Loudnes
		{
			get => E_PROP_UBTTask_MakeNoise_Loudnes_GET(NativePointer);
			set => E_PROP_UBTTask_MakeNoise_Loudnes_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTTask_MakeNoise self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_MakeNoise(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_MakeNoise>(PtrDesc);
		}}}
