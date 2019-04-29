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
	public  partial class ADefaultPawn : APawn
	{
		public ADefaultPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		public ADefaultPawn(UObject Parent = null, string Name = "DefaultPawn")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ADefaultPawn(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ADefaultPawn_BaseLookUpRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ADefaultPawn_BaseLookUpRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ADefaultPawn_BaseTurnRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ADefaultPawn_BaseTurnRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ADefaultPawn_CollisionComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ADefaultPawn_MeshComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ADefaultPawn_MovementComponentName_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ADefaultPawn(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ADefaultPawn_GetCollisionComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ADefaultPawn_GetMeshComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ADefaultPawn_LookUpAtRate(IntPtr self, float rate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ADefaultPawn_MoveForward(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ADefaultPawn_MoveRight(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ADefaultPawn_MoveUp_World(IntPtr self, float val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ADefaultPawn_TurnAtRate(IntPtr self, float rate);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Base lookup rate, in deg/sec. Other scaling may affect final lookup rate.
		/// </summary>
		public float BaseLookUpRate
		{
			get => E_PROP_ADefaultPawn_BaseLookUpRate_GET(NativePointer);
			set => E_PROP_ADefaultPawn_BaseLookUpRate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Base turn rate, in deg/sec. Other scaling may affect final turn rate.
		/// </summary>
		public float BaseTurnRate
		{
			get => E_PROP_ADefaultPawn_BaseTurnRate_GET(NativePointer);
			set => E_PROP_ADefaultPawn_BaseTurnRate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Name of the CollisionComponent.
		/// </summary>
		public static string CollisionComponentName
		{
			get => E_PROP_ADefaultPawn_CollisionComponentName_GET();
		}

		
		/// <summary>
		/// Name of the MeshComponent. Use this name if you want to prevent creation of the component (with ObjectInitializer.DoNotCreateDefaultSubobject).
		/// </summary>
		public static string MeshComponentName
		{
			get => E_PROP_ADefaultPawn_MeshComponentName_GET();
		}

		
		/// <summary>
		/// Name of the MovementComponent.  Use this name if you want to use a different class (with ObjectInitializer.SetDefaultSubobjectClass).
		/// </summary>
		public static string MovementComponentName
		{
			get => E_PROP_ADefaultPawn_MovementComponentName_GET();
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns CollisionComponent subobject
		/// </summary>
		public USphereComponent GetCollisionComponent()
			=> E_ADefaultPawn_GetCollisionComponent(this);
		
		
		/// <summary>
		/// Returns MeshComponent subobject
		/// </summary>
		public UStaticMeshComponent GetMeshComponent()
			=> E_ADefaultPawn_GetMeshComponent(this);
		
		
		/// <summary>
		/// Called via input to look up at a given rate (or down if Rate is negative).
		/// </summary>
		/// <param name="rate">This is a normalized rate, i.e. 1.0 means 100% of desired turn rate</param>
		public virtual void LookUpAtRate(float rate)
			=> E_ADefaultPawn_LookUpAtRate(this, rate);
		
		
		/// <summary>
		/// Input callback to move forward in local space (or backward if Val is negative).
		/// <see cref="APawn"/>
		/// </summary>
		/// <param name="val">Amount of movement in the forward direction (or backward if negative).</param>
		public virtual void MoveForward(float val)
			=> E_ADefaultPawn_MoveForward(this, val);
		
		
		/// <summary>
		/// Input callback to strafe right in local space (or left if Val is negative).
		/// <see cref="APawn"/>
		/// </summary>
		/// <param name="val">Amount of movement in the right direction (or left if negative).</param>
		public virtual void MoveRight(float val)
			=> E_ADefaultPawn_MoveRight(this, val);
		
		
		/// <summary>
		/// Input callback to move up in world space (or down if Val is negative).
		/// <see cref="APawn"/>
		/// </summary>
		/// <param name="val">Amount of movement in the world up direction (or down if negative).</param>
		public virtual void MoveUp_World(float val)
			=> E_ADefaultPawn_MoveUp_World(this, val);
		
		
		/// <summary>
		/// Called via input to turn at a given rate.
		/// </summary>
		/// <param name="rate">This is a normalized rate, i.e. 1.0 means 100% of desired turn rate</param>
		public virtual void TurnAtRate(float rate)
			=> E_ADefaultPawn_TurnAtRate(this, rate);
		
		#endregion
		
		public static implicit operator IntPtr(ADefaultPawn self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ADefaultPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ADefaultPawn>(PtrDesc);
		}}}
