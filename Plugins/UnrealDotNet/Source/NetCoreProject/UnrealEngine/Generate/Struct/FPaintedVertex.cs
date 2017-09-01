using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Cached vertex information at the time the mesh was painted.
	/// </summary>
	public partial class FPaintedVertex
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FPaintedVertex()
		{
			NativePointer = E_CreateStruct_FPaintedVertex();
			IsRef = false;
		}

		internal FPaintedVertex(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPaintedVertex();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FPaintedVertex_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPaintedVertex_Position_SET(IntPtr Ptr, FVector Value);
		
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
