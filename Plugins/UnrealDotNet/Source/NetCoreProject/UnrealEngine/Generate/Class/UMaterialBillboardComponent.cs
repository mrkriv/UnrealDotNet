using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A 2d material that will be rendered always facing the camera.
	/// </summary>
	public partial class UMaterialBillboardComponent : UPrimitiveComponent
	{
		public UMaterialBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UMaterialBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMaterialBillboardComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UMaterialBillboardComponent(Adress);
		}}}
