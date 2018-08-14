using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

namespace UnrealEngine
{
	[ManageType("ManagePawnMovementComponent")]
	public partial class ManagePawnMovementComponent : UPawnMovementComponent
	{
		public ManagePawnMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude. </para>
		/// <para>They are accumulated during a frame then applied as acceleration during the movement update. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public override void AddInputVector(FVector WorldVector, bool bForce) { }
		
		
		/// <summary>
		/// <para>Notify of collision in case we want to react, such as waking up avoidance or pathing code. </para>
		/// </summary>
		public override void NotifyBumpedPawn(APawn BumpedPawn) { }
		
		public static implicit operator IntPtr(ManagePawnMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePawnMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawnMovementComponent>(PtrDesc);
		}}}
