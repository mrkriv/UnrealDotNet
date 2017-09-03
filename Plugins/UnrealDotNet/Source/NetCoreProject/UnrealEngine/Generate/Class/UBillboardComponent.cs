using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageBillboardComponent
	/// <para>A 2d texture that will be rendered always facing the camera. </para>
	/// </summary>
	public  partial class UBillboardComponent : UPrimitiveComponent
	{
		public UBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBillboardComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UBillboardComponent ?? new UBillboardComponent(Adress);
		}}}
