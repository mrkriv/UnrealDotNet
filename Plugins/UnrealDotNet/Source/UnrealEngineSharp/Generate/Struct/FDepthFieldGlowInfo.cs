using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3744

namespace UnrealEngine
{
	public  partial class FDepthFieldGlowInfo : NativeStructWrapper
	{
		internal FDepthFieldGlowInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDepthFieldGlowInfo() :
			base(E_CreateStruct_FDepthFieldGlowInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDepthFieldGlowInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDepthFieldGlowInfo_GlowInnerRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDepthFieldGlowInfo_GlowInnerRadius_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FDepthFieldGlowInfo_GlowOuterRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FDepthFieldGlowInfo_GlowOuterRadius_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>if bEnableGlow, outline glow inner radius (0 to 1, 0.5 is edge of character silhouette) </para>
		/// <para>glow influence will be 1 at GlowInnerRadius.X and 0 at GlowInnerRadius.Y </para>
		/// </summary>
		public FVector2D GlowInnerRadius
		{
			get => E_PROP_FDepthFieldGlowInfo_GlowInnerRadius_GET(NativePointer);
			set => E_PROP_FDepthFieldGlowInfo_GlowInnerRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>if bEnableGlow, outline glow outer radius (0 to 1, 0.5 is edge of character silhouette) </para>
		/// <para>glow influence will be 0 at GlowOuterRadius.X and 1 at GlowOuterRadius.Y </para>
		/// </summary>
		public FVector2D GlowOuterRadius
		{
			get => E_PROP_FDepthFieldGlowInfo_GlowOuterRadius_GET(NativePointer);
			set => E_PROP_FDepthFieldGlowInfo_GlowOuterRadius_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDepthFieldGlowInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDepthFieldGlowInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDepthFieldGlowInfo(Adress, false);
		}}}
