using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// DefaultPawn implements a simple Pawn with spherical collision and built-in flying movement.
	/// @see UFloatingPawnMovement
	/// </summary>
	public partial class ADefaultPawn : APawn
	{
		public ADefaultPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_ADefaultPawn_MovementComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ADefaultPawn_MovementComponentName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_ADefaultPawn_CollisionComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ADefaultPawn_CollisionComponentName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_ADefaultPawn_MeshComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_ADefaultPawn_MeshComponentName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_ADefaultPawn_GetCollisionComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_ADefaultPawn_GetMeshComponent(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Name of the MovementComponent.  Use this name if you want to use a different class (with ObjectInitializer.SetDefaultSubobjectClass).
		/// </summary>
		public string MovementComponentName
		{
			get => E_PROP_ADefaultPawn_MovementComponentName_GET(NativePointer);
			set => E_PROP_ADefaultPawn_MovementComponentName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Name of the CollisionComponent.
		/// </summary>
		public string CollisionComponentName
		{
			get => E_PROP_ADefaultPawn_CollisionComponentName_GET(NativePointer);
			set => E_PROP_ADefaultPawn_CollisionComponentName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Name of the MeshComponent. Use this name if you want to prevent creation of the component (with ObjectInitializer.DoNotCreateDefaultSubobject).
		/// </summary>
		public string MeshComponentName
		{
			get => E_PROP_ADefaultPawn_MeshComponentName_GET(NativePointer);
			set => E_PROP_ADefaultPawn_MeshComponentName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns CollisionComponent subobject
		/// </summary>
		public USphereComponent GetCollisionComponent()
			=> E_ADefaultPawn_GetCollisionComponent(NativePointer);
		
		
		/// <summary>
		/// Returns MeshComponent subobject
		/// </summary>
		public UStaticMeshComponent GetMeshComponent()
			=> E_ADefaultPawn_GetMeshComponent(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(ADefaultPawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ADefaultPawn(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new ADefaultPawn(Adress);
		}}}
