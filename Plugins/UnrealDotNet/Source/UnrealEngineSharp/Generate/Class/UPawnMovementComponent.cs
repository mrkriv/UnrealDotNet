using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\PawnMovementComponent.h:22

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
		private static extern void E_UPawnMovementComponent_AddInputVector(IntPtr Self, IntPtr WorldVector, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_ConsumeInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_GetLastInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnMovementComponent_GetPawnOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_GetPendingInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnMovementComponent_IsMoveInputIgnored(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPawnMovementComponent_K2_GetInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnMovementComponent_NotifyBumpedPawn(IntPtr Self, IntPtr BumpedPawn);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude. </para>
		/// <para>They are accumulated during a frame then applied as acceleration during the movement update. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public virtual void AddInputVector(FVector WorldVector, bool bForce)
			=> E_UPawnMovementComponent_AddInputVector(this, WorldVector, bForce);
		
		public virtual FVector ConsumeInputVector()
			=> E_UPawnMovementComponent_ConsumeInputVector(this);
		
		
		/// <summary>
		/// <para>Return the last input vector in world space that was processed by ConsumeInputVector(), which is usually done by the Pawn or PawnMovementComponent. </para>
		/// <para>Any user that needs to know about the input that last affected movement should use this function. </para>
		/// <return>The last input vector in world space that was processed by ConsumeInputVector(). </return>
		/// <para>@see AddInputVector(), ConsumeInputVector(), GetPendingInputVector() </para>
		/// </summary>
		public FVector GetLastInputVector()
			=> E_UPawnMovementComponent_GetLastInputVector(this);
		
		
		/// <summary>
		/// <para>Return the Pawn that owns UpdatedComponent. </para>
		/// </summary>
		public APawn GetPawnOwner()
			=> E_UPawnMovementComponent_GetPawnOwner(this);
		
		
		/// <summary>
		/// <para>Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it. </para>
		/// <para>PawnMovementComponents implementing movement usually want to use either this or ConsumeInputVector() as these functions represent the most recent state of input. </para>
		/// <return>The pending input vector in world space. </return>
		/// <para>@see AddInputVector(), ConsumeInputVector(), GetLastInputVector() </para>
		/// </summary>
		public FVector GetPendingInputVector()
			=> E_UPawnMovementComponent_GetPendingInputVector(this);
		
		
		/// <summary>
		/// <para>Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn's implementation of IsMoveInputIgnored(). </para>
		/// </summary>
		public virtual bool IsMoveInputIgnored()
			=> E_UPawnMovementComponent_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// <para>(Deprecated) Return the input vector in world space. </para>
		/// </summary>
		public FVector GetInputVector()
			=> E_UPawnMovementComponent_K2_GetInputVector(this);
		
		
		/// <summary>
		/// <para>Notify of collision in case we want to react, such as waking up avoidance or pathing code. </para>
		/// </summary>
		public virtual void NotifyBumpedPawn(APawn BumpedPawn)
			=> E_UPawnMovementComponent_NotifyBumpedPawn(this, BumpedPawn);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPawnMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnMovementComponent>(PtrDesc);
		}}}
