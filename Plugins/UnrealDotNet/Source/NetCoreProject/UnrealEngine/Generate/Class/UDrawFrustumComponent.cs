using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Utility component for drawing a view frustum. Origin is at the component location, frustum points down position X axis.
	/// </summary>
	public partial class UDrawFrustumComponent : UPrimitiveComponent
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
			return Adress == IntPtr.Zero ? null : new UDrawFrustumComponent(Adress);
		}}}
