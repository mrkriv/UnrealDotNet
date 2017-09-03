using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Этот класс может быть наследованн
	/// <para>This component tries to maintain its children at a fixed distance from the parent, </para>
	/// <para>but will retract the children if there is a collision, and spring back when there is no collision. </para>
	/// <para>Example: Use as a 'camera boom' to keep the follow camera for a player from colliding into the world. </para>
	/// </summary>
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
