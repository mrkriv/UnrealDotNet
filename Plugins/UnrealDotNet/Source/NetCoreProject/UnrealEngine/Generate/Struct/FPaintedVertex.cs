using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManagePaintedVertex
	/// <para>Cached vertex information at the time the mesh was painted. </para>
	/// </summary>
	public  partial class FPaintedVertex : NativeStructWrapper
	{
		public FPaintedVertex() : base(E_CreateStruct_FPaintedVertex(), false)
		{
		}

		internal FPaintedVertex(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPaintedVertex();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FPaintedVertex_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPaintedVertex_Position_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public FVector Position
		{
			get => E_PROP_FPaintedVertex_Position_GET(NativePointer);
			set => E_PROP_FPaintedVertex_Position_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPaintedVertex Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPaintedVertex(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPaintedVertex(Adress, false);
		}}}
