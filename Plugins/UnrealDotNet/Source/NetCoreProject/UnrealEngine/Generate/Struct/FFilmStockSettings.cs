using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\Scene.h:131

namespace UnrealEngine
{
	public  partial class FFilmStockSettings : NativeStructWrapper
	{
		internal FFilmStockSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFilmStockSettings() :
			base(E_CreateStruct_FFilmStockSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFilmStockSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_BlackClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_BlackClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_Shoulder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_Shoulder_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_Slope_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_Slope_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_Toe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_Toe_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_WhiteClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_WhiteClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFilmStockSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region Property
		public float Blackclip
		{
			get => E_PROP_FFilmStockSettings_BlackClip_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_BlackClip_SET(NativePointer, value);
		}

		public float Shoulder
		{
			get => E_PROP_FFilmStockSettings_Shoulder_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Shoulder_SET(NativePointer, value);
		}

		public float Slope
		{
			get => E_PROP_FFilmStockSettings_Slope_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Slope_SET(NativePointer, value);
		}

		public float Toe
		{
			get => E_PROP_FFilmStockSettings_Toe_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Toe_SET(NativePointer, value);
		}

		public float Whiteclip
		{
			get => E_PROP_FFilmStockSettings_WhiteClip_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_WhiteClip_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FFilmStockSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FFilmStockSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFilmStockSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFilmStockSettings(Adress, false);
		}}}
