using System;
using System.Runtime.InteropServices;

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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UBrushComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
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

		public static implicit operator UBrushComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UBrushComponent ?? new UBrushComponent(Adress);
		}}}
