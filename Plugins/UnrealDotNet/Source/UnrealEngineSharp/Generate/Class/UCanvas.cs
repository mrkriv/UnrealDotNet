// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Canvas.h:154

namespace UnrealEngine
{
	public  partial class UCanvas : UObject
	{
		public UCanvas(IntPtr Adress)
			: base(Adress)
		{
		}

		public UCanvas(UObject Parent = null, string Name = "Canvas")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCanvas(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_CachedDisplayHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_CachedDisplayHeight_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_CachedDisplayWidth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_CachedDisplayWidth_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCanvas_ClipX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_ClipX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCanvas_ClipY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_ClipY_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCanvas_ColorModulate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_ColorModulate_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCanvas_HmdOrientation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_HmdOrientation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCanvas_OrgX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_OrgX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCanvas_OrgY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_OrgY_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_SafeZonePadEX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_SafeZonePadEX_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_SafeZonePadEY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_SafeZonePadEY_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_SafeZonePadX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_SafeZonePadX_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_SafeZonePadY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_SafeZonePadY_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_SizeX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_SizeX_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_SizeY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_SizeY_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_UnsafeSizeX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_UnsafeSizeX_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCanvas_UnsafeSizeY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_UnsafeSizeY_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCanvas_ViewProjectionMatrix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCanvas_ViewProjectionMatrix_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCanvas(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCanvas_ApplySafeZoneTransform(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCanvas_PopSafeZoneTransform(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCanvas_Update(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCanvas_UpdateAllCanvasSafeZoneData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCanvas_UpdateSafeZoneData(IntPtr self);
		
		#endregion
		
		#region Property
		public int CachedDisplayHeight
		{
			get => E_PROP_UCanvas_CachedDisplayHeight_GET(NativePointer);
			set => E_PROP_UCanvas_CachedDisplayHeight_SET(NativePointer, value);
		}

		public int CachedDisplayWidth
		{
			get => E_PROP_UCanvas_CachedDisplayWidth_GET(NativePointer);
			set => E_PROP_UCanvas_CachedDisplayWidth_SET(NativePointer, value);
		}

		public float ClipX
		{
			get => E_PROP_UCanvas_ClipX_GET(NativePointer);
			set => E_PROP_UCanvas_ClipX_SET(NativePointer, value);
		}

		public float ClipY
		{
			get => E_PROP_UCanvas_ClipY_GET(NativePointer);
			set => E_PROP_UCanvas_ClipY_SET(NativePointer, value);
		}

		public FPlane ColorModulate
		{
			get => E_PROP_UCanvas_ColorModulate_GET(NativePointer);
			set => E_PROP_UCanvas_ColorModulate_SET(NativePointer, value);
		}

		public FQuat HmdOrientation
		{
			get => E_PROP_UCanvas_HmdOrientation_GET(NativePointer);
			set => E_PROP_UCanvas_HmdOrientation_SET(NativePointer, value);
		}

		public float OrgX
		{
			get => E_PROP_UCanvas_OrgX_GET(NativePointer);
			set => E_PROP_UCanvas_OrgX_SET(NativePointer, value);
		}

		public float OrgY
		{
			get => E_PROP_UCanvas_OrgY_GET(NativePointer);
			set => E_PROP_UCanvas_OrgY_SET(NativePointer, value);
		}

		public int SafeZonePadEX
		{
			get => E_PROP_UCanvas_SafeZonePadEX_GET(NativePointer);
			set => E_PROP_UCanvas_SafeZonePadEX_SET(NativePointer, value);
		}

		public int SafeZonePadEY
		{
			get => E_PROP_UCanvas_SafeZonePadEY_GET(NativePointer);
			set => E_PROP_UCanvas_SafeZonePadEY_SET(NativePointer, value);
		}

		public int SafeZonePadX
		{
			get => E_PROP_UCanvas_SafeZonePadX_GET(NativePointer);
			set => E_PROP_UCanvas_SafeZonePadX_SET(NativePointer, value);
		}

		public int SafeZonePadY
		{
			get => E_PROP_UCanvas_SafeZonePadY_GET(NativePointer);
			set => E_PROP_UCanvas_SafeZonePadY_SET(NativePointer, value);
		}

		public int SizeX
		{
			get => E_PROP_UCanvas_SizeX_GET(NativePointer);
			set => E_PROP_UCanvas_SizeX_SET(NativePointer, value);
		}

		public int SizeY
		{
			get => E_PROP_UCanvas_SizeY_GET(NativePointer);
			set => E_PROP_UCanvas_SizeY_SET(NativePointer, value);
		}

		public int UnsafeSizeX
		{
			get => E_PROP_UCanvas_UnsafeSizeX_GET(NativePointer);
			set => E_PROP_UCanvas_UnsafeSizeX_SET(NativePointer, value);
		}

		public int UnsafeSizeY
		{
			get => E_PROP_UCanvas_UnsafeSizeY_GET(NativePointer);
			set => E_PROP_UCanvas_UnsafeSizeY_SET(NativePointer, value);
		}

		public FMatrix ViewProjectionMatrix
		{
			get => E_PROP_UCanvas_ViewProjectionMatrix_GET(NativePointer);
			set => E_PROP_UCanvas_ViewProjectionMatrix_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ApplySafeZoneTransform()
			=> E_UCanvas_ApplySafeZoneTransform(this);
		
		public void PopSafeZoneTransform()
			=> E_UCanvas_PopSafeZoneTransform(this);
		
		
		/// <summary>
		/// Updates the canvas.
		/// </summary>
		public void Update()
			=> E_UCanvas_Update(this);
		
		public void UpdateAllCanvasSafeZoneData()
			=> E_UCanvas_UpdateAllCanvasSafeZoneData(this);
		
		public void UpdateSafeZoneData()
			=> E_UCanvas_UpdateSafeZoneData(this);
		
		#endregion
		
		public static implicit operator IntPtr(UCanvas self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCanvas(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCanvas>(PtrDesc);
		}}}
