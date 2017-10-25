using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\BrushComponent.h:21

namespace UnrealEngine
{
	public  partial class UBrushComponent : UPrimitiveComponent
	{
		public UBrushComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBrushComponent(UObject Parent = null, string Name = "BrushComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBrushComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBrushComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBrushComponent_BuildSimpleBrushCollision(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Create the AggGeom collection-of-convex-primitives from the Brush UModel data. </para>
		/// </summary>
		public void BuildSimpleBrushCollision()
			=> E_UBrushComponent_BuildSimpleBrushCollision(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBrushComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBrushComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBrushComponent>(PtrDesc);
		}}}
