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
		private static extern ObjectPointerDescription E_ADefaultPawn_GetCollisionComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ADefaultPawn_GetMeshComponent(IntPtr Self);
		
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
