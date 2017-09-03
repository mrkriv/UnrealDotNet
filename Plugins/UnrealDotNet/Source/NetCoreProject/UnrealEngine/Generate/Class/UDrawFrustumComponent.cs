using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageDrawFrustumComponent
	/// <para>Utility component for drawing a view frustum. Origin is at the component location, frustum points down position X axis. </para>
	/// </summary>
	public  partial class UDrawFrustumComponent : UPrimitiveComponent
	{
		public UDrawFrustumComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UDrawFrustumComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawFrustumComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDrawFrustumComponent ?? new UDrawFrustumComponent(Adress);
		}}}
