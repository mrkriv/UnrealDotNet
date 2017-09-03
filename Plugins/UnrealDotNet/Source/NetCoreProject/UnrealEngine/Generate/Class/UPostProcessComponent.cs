using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManagePostProcessComponent
	/// <para>PostProcessComponent. Enables Post process controls for blueprints. </para>
	/// <para>Will use a parent UShapeComponent to provide volume data if available. </para>
	/// </summary>
	public  partial class UPostProcessComponent : USceneComponent
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
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPostProcessComponent ?? new UPostProcessComponent(Adress);
		}}}
