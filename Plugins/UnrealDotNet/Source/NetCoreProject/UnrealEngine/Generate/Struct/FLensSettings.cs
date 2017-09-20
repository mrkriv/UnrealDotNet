using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLensSettings_Bloom_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensSettings_Bloom_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLensSettings_ChromaticAberration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensSettings_ChromaticAberration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLensSettings_Imperfections_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensSettings_Imperfections_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
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
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FLensSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensSettings(Adress, false);
		}}}
