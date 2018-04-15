using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

namespace UnrealEngine
{
	public partial class ManageSpringArmComponent : USpringArmComponent
	{
		public ManageSpringArmComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Updates the desired arm location, calling BlendLocations to do the actual blending if a trace is done </para>
		/// </summary>
		protected override void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime) { }
		
		public static implicit operator IntPtr(ManageSpringArmComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSpringArmComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpringArmComponent>(PtrDesc);
		}}}
