using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A Component referencing a vector field.
	/// </summary>
	public partial class UVectorFieldComponent : UPrimitiveComponent
	{
		public UVectorFieldComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UVectorFieldComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UVectorFieldComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UVectorFieldComponent(Adress);
		}}}
