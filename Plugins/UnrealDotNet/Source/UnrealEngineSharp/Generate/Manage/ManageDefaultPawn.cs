// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\DefaultPawn.h:25

namespace UnrealEngine
{
	[ManageType("ManageDefaultPawn")]
	public partial class ManageDefaultPawn : ADefaultPawn
	{
		public ManageDefaultPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Called via input to look up at a given rate (or down if Rate is negative). </para>
		/// <param name="Rate">This is a normalized rate, i.e. 1.0 means 100% of desired turn rate </param>
		/// </summary>
		public override void LookUpAtRate(float rate) { }
		
		
		/// <summary>
		/// <para>Input callback to move forward in local space (or backward if Val is negative). </para>
		/// <param name="Val">Amount of movement in the forward direction (or backward if negative). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public override void MoveForward(float val) { }
		
		
		/// <summary>
		/// <para>Input callback to strafe right in local space (or left if Val is negative). </para>
		/// <param name="Val">Amount of movement in the right direction (or left if negative). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public override void MoveRight(float val) { }
		
		
		/// <summary>
		/// <para>Input callback to move up in world space (or down if Val is negative). </para>
		/// <param name="Val">Amount of movement in the world up direction (or down if negative). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public override void MoveUp_World(float val) { }
		
		
		/// <summary>
		/// <para>Called via input to turn at a given rate. </para>
		/// <param name="Rate">This is a normalized rate, i.e. 1.0 means 100% of desired turn rate </param>
		/// </summary>
		public override void TurnAtRate(float rate) { }
		
		public static implicit operator IntPtr(ManageDefaultPawn self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageDefaultPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDefaultPawn>(PtrDesc);
		}}}
