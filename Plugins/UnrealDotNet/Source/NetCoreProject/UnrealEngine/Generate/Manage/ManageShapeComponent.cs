using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ShapeComponent.h:24

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

		public static implicit operator ManageShapeComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageShapeComponent>(PtrDesc);
		}}}
