using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageTextRenderComponent
	/// <para>Renders text in the world with given font. Contains usual font related attributes such as Scale, Alignment, Color etc. </para>
	/// </summary>
	public  partial class UTextRenderComponent : UPrimitiveComponent
	{
		public UTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UTextRenderComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UTextRenderComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UTextRenderComponent ?? new UTextRenderComponent(Adress);
		}}}
