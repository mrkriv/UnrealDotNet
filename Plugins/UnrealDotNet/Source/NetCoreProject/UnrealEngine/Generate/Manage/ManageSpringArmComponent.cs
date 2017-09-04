using System;
using System.Runtime.InteropServices;

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

		public static implicit operator ManageSpringArmComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ManageSpringArmComponent ?? new ManageSpringArmComponent(Adress);
		}}}
