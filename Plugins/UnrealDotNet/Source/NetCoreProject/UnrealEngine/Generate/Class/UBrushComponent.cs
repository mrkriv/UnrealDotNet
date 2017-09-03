using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageBrushComponent
	/// <para>A brush component defines a shape that can be modified within the editor. They are used both as part of BSP building, and for volumes. </para>
	/// <para>@see https://docs.unrealengine.com/latest/INT/Engine/Actors/Volumes </para>
	/// <para>@see https://docs.unrealengine.com/latest/INT/Engine/Actors/Brushes </para>
	/// </summary>
	public  partial class UBrushComponent : UPrimitiveComponent
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
