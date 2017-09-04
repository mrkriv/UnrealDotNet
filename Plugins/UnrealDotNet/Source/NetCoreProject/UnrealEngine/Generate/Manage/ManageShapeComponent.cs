using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManageShapeComponent : UShapeComponent
	{
		public ManageShapeComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Update the body setup parameters based on shape information </para>
		/// </summary>
		public override void UpdateBodySetup() { }
		
		public static implicit operator IntPtr(ManageShapeComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageShapeComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManageShapeComponent ?? new ManageShapeComponent(Adress);
		}}}
