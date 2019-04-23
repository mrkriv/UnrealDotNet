// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\FloatingPawnMovement.h:22

namespace UnrealEngine
{
	[ManageType("ManageFloatingPawnMovement")]
	public partial class ManageFloatingPawnMovement : UFloatingPawnMovement
	{
		public ManageFloatingPawnMovement(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Update Velocity based on input. Also applies gravity. </para>
		/// </summary>
		protected override void ApplyControlInputToVelocity(float deltaTime) { }
		
		public static implicit operator IntPtr(ManageFloatingPawnMovement self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageFloatingPawnMovement(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageFloatingPawnMovement>(PtrDesc);
		}}}
