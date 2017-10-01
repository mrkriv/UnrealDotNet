using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ADefaultPawn : APawn
	{
		public ADefaultPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		public ADefaultPawn(UObject Parent = null, string Name = "DefaultPawn")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ADefaultPawn(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ADefaultPawn(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_ADefaultPawn_CollisionComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ADefaultPawn_CollisionComponentName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_ADefaultPawn_MeshComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ADefaultPawn_MeshComponentName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern string E_PROP_ADefaultPawn_MovementComponentName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ADefaultPawn_MovementComponentName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ADefaultPawn_GetCollisionComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ADefaultPawn_GetMeshComponent(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of the CollisionComponent. </para>
		/// </summary>
		public string CollisionComponentName
		{
			get => E_PROP_ADefaultPawn_CollisionComponentName_GET(NativePointer);
			set => E_PROP_ADefaultPawn_CollisionComponentName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Name of the MeshComponent. Use this name if you want to prevent creation of the component (with ObjectInitializer.DoNotCreateDefaultSubobject). </para>
		/// </summary>
		public string MeshComponentName
		{
			get => E_PROP_ADefaultPawn_MeshComponentName_GET(NativePointer);
			set => E_PROP_ADefaultPawn_MeshComponentName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Name of the MovementComponent.  Use this name if you want to use a different class (with ObjectInitializer.SetDefaultSubobjectClass). </para>
		/// </summary>
		public string MovementComponentName
		{
			get => E_PROP_ADefaultPawn_MovementComponentName_GET(NativePointer);
			set => E_PROP_ADefaultPawn_MovementComponentName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns CollisionComponent subobject </para>
		/// </summary>
		public USphereComponent GetCollisionComponent()
			=> E_ADefaultPawn_GetCollisionComponent(this);
		
		
		/// <summary>
		/// <para>Returns MeshComponent subobject </para>
		/// </summary>
		public UStaticMeshComponent GetMeshComponent()
			=> E_ADefaultPawn_GetMeshComponent(this);
		
		#endregion
		
		public static implicit operator IntPtr(ADefaultPawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ADefaultPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ADefaultPawn>(PtrDesc);
		}}}
