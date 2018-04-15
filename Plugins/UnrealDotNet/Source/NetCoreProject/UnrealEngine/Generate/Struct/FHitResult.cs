using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1842

namespace UnrealEngine
{
	public  partial class FHitResult : NativeStructWrapper
	{
		internal FHitResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FHitResult() :
			base(E_CreateStruct_FHitResult(), false)
		{
		}

		public FHitResult(float InTime) :
			base(E_CreateStruct_FHitResult_float(InTime), false)
		{
		}

		public FHitResult(FVector Start, FVector End) :
			base(E_CreateStruct_FHitResult_FVector_FVector(Start, End), false)
		{
		}

		
		/// <summary>
		/// <para>Ctor for easily creating "fake" hits from limited data. </para>
		/// </summary>
		public FHitResult(AActor InActor, UPrimitiveComponent InComponent, FVector HitLoc, FVector HitNorm) :
			base(E_CreateStruct_FHitResult_AActor_UPrimitiveComponent_FVector_FVector(InActor, InComponent, HitLoc, HitNorm), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult_float(float InTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult_FVector_FVector(IntPtr Start, IntPtr End);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHitResult_AActor_UPrimitiveComponent_FVector_FVector(IntPtr InActor, IntPtr InComponent, IntPtr HitLoc, IntPtr HitNorm);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHitResult_bBlockingHit_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_bBlockingHit_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FHitResult_BoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_BoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHitResult_bStartPenetrating_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_bStartPenetrating_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHitResult_Distance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_Distance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FHitResult_FaceIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_FaceIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FHitResult_Item_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_Item_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FHitResult_MyBoneName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_MyBoneName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHitResult_PenetrationDepth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_PenetrationDepth_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHitResult_Time_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHitResult_Time_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FHitResult_GetActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FHitResult_GetComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FHitResult_GetReversedHit(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FHitResult_IsValidBlockingHit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FHitResult_Reset(IntPtr Self, float InTime, bool bPreserveTraceData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FHitResult_ToString(IntPtr Self);
		
		#endregion
		
		#region Property
		public byte bBlockingHit
		{
			get => E_PROP_FHitResult_bBlockingHit_GET(NativePointer);
			set => E_PROP_FHitResult_bBlockingHit_SET(NativePointer, value);
		}

		public string BoneName
		{
			get => E_PROP_FHitResult_BoneName_GET(NativePointer);
			set => E_PROP_FHitResult_BoneName_SET(NativePointer, value);
		}

		public byte bStartPenetrating
		{
			get => E_PROP_FHitResult_bStartPenetrating_GET(NativePointer);
			set => E_PROP_FHitResult_bStartPenetrating_SET(NativePointer, value);
		}

		public float Distance
		{
			get => E_PROP_FHitResult_Distance_GET(NativePointer);
			set => E_PROP_FHitResult_Distance_SET(NativePointer, value);
		}

		public int FaceIndex
		{
			get => E_PROP_FHitResult_FaceIndex_GET(NativePointer);
			set => E_PROP_FHitResult_FaceIndex_SET(NativePointer, value);
		}

		public int Item
		{
			get => E_PROP_FHitResult_Item_GET(NativePointer);
			set => E_PROP_FHitResult_Item_SET(NativePointer, value);
		}

		public string MyBoneName
		{
			get => E_PROP_FHitResult_MyBoneName_GET(NativePointer);
			set => E_PROP_FHitResult_MyBoneName_SET(NativePointer, value);
		}

		public float PenetrationDepth
		{
			get => E_PROP_FHitResult_PenetrationDepth_GET(NativePointer);
			set => E_PROP_FHitResult_PenetrationDepth_SET(NativePointer, value);
		}

		public float Time
		{
			get => E_PROP_FHitResult_Time_GET(NativePointer);
			set => E_PROP_FHitResult_Time_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Utility to return the Actor that owns the Component that was hit. </para>
		/// </summary>
		public AActor GetActor()
			=> E_FHitResult_GetActor(this);
		
		
		/// <summary>
		/// <para>Utility to return the Component that was hit. </para>
		/// </summary>
		public UPrimitiveComponent GetComponent()
			=> E_FHitResult_GetComponent(this);
		
		
		/// <summary>
		/// <para>Get a copy of the HitResult with relevant information reversed. </para>
		/// <para>For example when receiving a hit from another object, we reverse the normals. </para>
		/// </summary>
		public FHitResult GetReversedHit(FHitResult Hit)
			=> E_FHitResult_GetReversedHit(this, Hit);
		
		
		/// <summary>
		/// <para>Return true if there was a blocking hit that was not caused by starting in penetration. </para>
		/// </summary>
		public bool IsValidBlockingHit()
			=> E_FHitResult_IsValidBlockingHit(this);
		
		
		/// <summary>
		/// <para>Reset hit result while optionally saving TraceStart and TraceEnd. </para>
		/// </summary>
		public void Reset(float InTime, bool bPreserveTraceData = true)
			=> E_FHitResult_Reset(this, InTime, bPreserveTraceData);
		
		public override string ToString()
			=> E_FHitResult_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FHitResult Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FHitResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FHitResult(Adress, false);
		}}}
