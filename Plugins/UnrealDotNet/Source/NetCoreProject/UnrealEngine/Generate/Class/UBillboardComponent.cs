using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A 2d texture that will be rendered always facing the camera.
	/// </summary>
	public partial class UBillboardComponent : UPrimitiveComponent
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
			return Adress == IntPtr.Zero ? null : new UBillboardComponent(Adress);
		}}}
