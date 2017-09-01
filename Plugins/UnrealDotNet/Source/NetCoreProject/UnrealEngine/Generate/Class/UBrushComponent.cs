using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A brush component defines a shape that can be modified within the editor. They are used both as part of BSP building, and for volumes.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/Volumes
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/Brushes
	/// </summary>
	public partial class UBrushComponent : UPrimitiveComponent
	{
		public UBrushComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UBrushComponent_BuildSimpleBrushCollision(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Create the AggGeom collection-of-convex-primitives from the Brush UModel data.
		/// </summary>
		public void BuildSimpleBrushCollision()
			=> E_UBrushComponent_BuildSimpleBrushCollision(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(UBrushComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBrushComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UBrushComponent(Adress);
		}}}
