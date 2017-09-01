using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FClosestPointOnPhysicsAsset
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FClosestPointOnPhysicsAsset()
		{
			NativePointer = E_CreateStruct_FClosestPointOnPhysicsAsset();
			IsRef = false;
		}

		internal FClosestPointOnPhysicsAsset(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FClosestPointOnPhysicsAsset();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FClosestPointOnPhysicsAsset_BoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_BoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The closest point in world space
		/// </summary>
		public FVector ClosestWorldPosition
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_ClosestWorldPosition_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The normal associated with the surface of the closest body
		/// </summary>
		public FVector Normal
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_Normal_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_Normal_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The name of the bone associated with the closest body
		/// </summary>
		public string BoneName
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_BoneName_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_BoneName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The distance of the closest point and the original world position. 0 Indicates world position is inside the closest body.
		/// </summary>
		public float Distance
		{
			get => E_PROP_FClosestPointOnPhysicsAsset_Distance_GET(NativePointer);
			set => E_PROP_FClosestPointOnPhysicsAsset_Distance_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FClosestPointOnPhysicsAsset Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FClosestPointOnPhysicsAsset(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FClosestPointOnPhysicsAsset(Adress, false);
		}}}
