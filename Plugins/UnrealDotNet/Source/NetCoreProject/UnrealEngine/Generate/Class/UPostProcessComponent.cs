using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// PostProcessComponent. Enables Post process controls for blueprints.
	/// Will use a parent UShapeComponent to provide volume data if available.
	/// </summary>
	public partial class UPostProcessComponent : USceneComponent
	{
		public UPostProcessComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UPostProcessComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPostProcessComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UPostProcessComponent(Adress);
		}}}
