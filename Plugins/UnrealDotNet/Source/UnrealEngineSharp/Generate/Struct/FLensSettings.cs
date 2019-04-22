// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:427

namespace UnrealEngine
{
	public  partial class FLensSettings : NativeStructWrapper
	{
		internal FLensSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLensSettings() :
			base(E_CreateStruct_FLensSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLensSettings_Bloom_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensSettings_Bloom_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLensSettings_ChromaticAberration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensSettings_ChromaticAberration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLensSettings_Imperfections_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensSettings_Imperfections_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensSettings_ExportToPostProcessSettings(IntPtr self, IntPtr outPostProcessSettings);
		
		#endregion
		
		#region Property
		public FLensBloomSettings Bloom
		{
			get => E_PROP_FLensSettings_Bloom_GET(NativePointer);
			set => E_PROP_FLensSettings_Bloom_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>in percent, Scene chromatic aberration / color fringe (camera imperfection) to simulate an artifact that happens in real-world lens, mostly visible in the image corners. </para>
		/// </summary>
		public float ChromaticAberration
		{
			get => E_PROP_FLensSettings_ChromaticAberration_GET(NativePointer);
			set => E_PROP_FLensSettings_ChromaticAberration_SET(NativePointer, value);
		}

		public FLensImperfectionSettings Imperfections
		{
			get => E_PROP_FLensSettings_Imperfections_GET(NativePointer);
			set => E_PROP_FLensSettings_Imperfections_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings outPostProcessSettings)
			=> E_FLensSettings_ExportToPostProcessSettings(this, outPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLensSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensSettings(Adress, false);
		}}}
