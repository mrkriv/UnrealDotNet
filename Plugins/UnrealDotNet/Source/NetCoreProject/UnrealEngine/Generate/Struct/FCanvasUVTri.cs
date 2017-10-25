using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3760

namespace UnrealEngine
{
	public  partial class FCanvasUVTri : NativeStructWrapper
	{
		internal FCanvasUVTri(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCanvasUVTri() :
			base(E_CreateStruct_FCanvasUVTri(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCanvasUVTri();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCanvasUVTri_V0_Pos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasUVTri_V0_Pos_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCanvasUVTri_V0_UV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasUVTri_V0_UV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCanvasUVTri_V1_Pos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasUVTri_V1_Pos_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCanvasUVTri_V1_UV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasUVTri_V1_UV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCanvasUVTri_V2_Pos_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasUVTri_V2_Pos_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCanvasUVTri_V2_UV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasUVTri_V2_UV_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Position of first vertex </para>
		/// </summary>
		public FVector2D V0_Pos
		{
			get => E_PROP_FCanvasUVTri_V0_Pos_GET(NativePointer);
			set => E_PROP_FCanvasUVTri_V0_Pos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>UV of first vertex </para>
		/// </summary>
		public FVector2D V0_UV
		{
			get => E_PROP_FCanvasUVTri_V0_UV_GET(NativePointer);
			set => E_PROP_FCanvasUVTri_V0_UV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Position of second vertex </para>
		/// </summary>
		public FVector2D V1_Pos
		{
			get => E_PROP_FCanvasUVTri_V1_Pos_GET(NativePointer);
			set => E_PROP_FCanvasUVTri_V1_Pos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>UV of second vertex </para>
		/// </summary>
		public FVector2D V1_UV
		{
			get => E_PROP_FCanvasUVTri_V1_UV_GET(NativePointer);
			set => E_PROP_FCanvasUVTri_V1_UV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Position of third vertex </para>
		/// </summary>
		public FVector2D V2_Pos
		{
			get => E_PROP_FCanvasUVTri_V2_Pos_GET(NativePointer);
			set => E_PROP_FCanvasUVTri_V2_Pos_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>UV of third vertex </para>
		/// </summary>
		public FVector2D V2_UV
		{
			get => E_PROP_FCanvasUVTri_V2_UV_GET(NativePointer);
			set => E_PROP_FCanvasUVTri_V2_UV_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCanvasUVTri Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCanvasUVTri(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCanvasUVTri(Adress, false);
		}}}
