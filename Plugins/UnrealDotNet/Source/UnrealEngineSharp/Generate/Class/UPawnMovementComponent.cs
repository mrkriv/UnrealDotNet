// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

namespace UnrealEngine
{
	public  partial class UPawnMovementComponent : UNavMovementComponent
	{
		public UPawnMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPawnMovementComponent(UObject Parent = null, string Name = "PawnMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnMovementComponent_AddInputVector(IntPtr self, IntPtr worldVector, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_ConsumeInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_GetLastInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnMovementComponent_GetPawnOwner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_GetPendingInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnMovementComponent_IsMoveInputIgnored(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_K2_GetInputVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnMovementComponent_MarkForClientCameraUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnMovementComponent_NotifyBumpedPawn(IntPtr self, IntPtr bumpedPawn);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude.
		/// <para>They are accumulated during a frame then applied as acceleration during the movement update. </para>
		/// <see cref="APawn"/>
		/// </summary>
		/// <param name="worldDirection">Direction in world space to apply input</param>
		/// <param name="scaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value.</param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored().</param>
		public virtual void AddInputVector(FVector worldVector, bool bForce)
			=> E_UPawnMovementComponent_AddInputVector(this, worldVector, bForce);
		
		public virtual FVector ConsumeInputVector()
			=> E_UPawnMovementComponent_ConsumeInputVector(this);
		
		
		/// <summary>
		/// Return the last input vector in world space that was processed by ConsumeInputVector(), which is usually done by the Pawn or PawnMovementComponent.
		/// <para>Any user that needs to know about the input that last affected movement should use this function. </para>
		/// <see cref="AddInputVector"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetLastInputVector()
			=> E_UPawnMovementComponent_GetLastInputVector(this);
		
		
		/// <summary>
		/// Return the Pawn that owns UpdatedComponent.
		/// </summary>
		public APawn GetPawnOwner()
			=> E_UPawnMovementComponent_GetPawnOwner(this);
		
		
		/// <summary>
		/// Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it.
		/// <para>PawnMovementComponents implementing movement usually want to use either this or ConsumeInputVector() as these functions represent the most recent state of input. </para>
		/// <see cref="AddInputVector"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetPendingInputVector()
			=> E_UPawnMovementComponent_GetPendingInputVector(this);
		
		
		/// <summary>
		/// Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn's implementation of IsMoveInputIgnored().
		/// </summary>
		public virtual bool IsMoveInputIgnored()
			=> E_UPawnMovementComponent_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// (Deprecated) Return the input vector in world space.
		/// </summary>
		public FVector GetInputVector()
			=> E_UPawnMovementComponent_K2_GetInputVector(this);
		
		
		/// <summary>
		/// Attempts to mark the PlayerCameraManager as dirty.
		/// <para>This will have no effect if called from the server. </para>
		/// </summary>
		protected void MarkForClientCameraUpdate()
			=> E_UPawnMovementComponent_MarkForClientCameraUpdate(this);
		
		
		/// <summary>
		/// Notify of collision in case we want to react, such as waking up avoidance or pathing code.
		/// </summary>
		public virtual void NotifyBumpedPawn(APawn bumpedPawn)
			=> E_UPawnMovementComponent_NotifyBumpedPawn(this, bumpedPawn);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPawnMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnMovementComponent>(PtrDesc);
		}
}
}
