using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ShapeComponent.h:24

namespace UnrealEngine
{
	public  partial class UShapeComponent : UPrimitiveComponent
	{
		public UShapeComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UShapeComponent(UObject Parent = null, string Name = "ShapeComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UShapeComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UShapeComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UShapeComponent_AddShapeToGeomArray(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UShapeComponent_CreateShapeBodySetupIfNeeded(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UShapeComponent_PrepareSharedBodySetup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UShapeComponent_UpdateBodySetup(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		protected void AddShapeToGeomArray()
			=> E_UShapeComponent_AddShapeToGeomArray(this);
		
		protected void CreateShapeBodySetupIfNeeded()
			=> E_UShapeComponent_CreateShapeBodySetupIfNeeded(this);
		
		
		/// <summary>
		/// <para>Checks if a shared body setup is available (and if we're eligible for it). If successful you must still check for staleness </para>
		/// </summary>
		protected bool PrepareSharedBodySetup()
			=> E_UShapeComponent_PrepareSharedBodySetup(this);
		
		
		/// <summary>
		/// <para>Update the body setup parameters based on shape information </para>
		/// </summary>
		public virtual void UpdateBodySetup()
			=> E_UShapeComponent_UpdateBodySetup(this);
		
		#endregion
		
		public static implicit operator IntPtr(UShapeComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UShapeComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UShapeComponent>(PtrDesc);
		}}}
