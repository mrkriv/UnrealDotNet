// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Public\CollisionQueryParams.h:40

namespace UnrealEngine
{
	public  partial class FCollisionQueryParams : NativeStructWrapper
	{
		internal FCollisionQueryParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// DEPRECATED!
		/// <para>Please instead provide a FName parameter when constructing a FCollisionQueryParams object which will use the other constructor. </para>
		/// Providing a single string literal argument, such as TEXT("foo"), instead of an explicit FNAME
		/// <para>can cause this constructor to be invoked instead the the other which was likely the programmers intention. </para>
		/// This constructor will eventually be deprecated to avoid this potentially ambiguous case.
		/// </summary>
		public FCollisionQueryParams(bool bInTraceComplex) :
			base(E_CreateStruct_FCollisionQueryParams_bool(bInTraceComplex), false)
		{
		}

		public FCollisionQueryParams() :
			base(E_CreateStruct_FCollisionQueryParams(), false)
		{
		}

		public FCollisionQueryParams(string inTraceTag, bool bInTraceComplex, AActor inIgnoreActor) :
			base(E_CreateStruct_FCollisionQueryParams_FName_bool_AActor(inTraceTag, bInTraceComplex, inIgnoreActor), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCollisionQueryParams_bFindInitialOverlaps_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_bFindInitialOverlaps_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCollisionQueryParams_bIgnoreBlocks_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_bIgnoreBlocks_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCollisionQueryParams_bIgnoreTouches_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_bIgnoreTouches_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCollisionQueryParams_bReturnFaceIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_bReturnFaceIndex_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCollisionQueryParams_bReturnPhysicalMaterial_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_bReturnPhysicalMaterial_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FCollisionQueryParams_bTraceComplex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_bTraceComplex_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCollisionQueryParams_DefaultQueryParam_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FCollisionQueryParams_MobilityType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_MobilityType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FCollisionQueryParams_OwnerTag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_OwnerTag_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FCollisionQueryParams_TraceTag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionQueryParams_TraceTag_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionQueryParams_bool(bool bInTraceComplex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionQueryParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionQueryParams_FName_bool_AActor(string inTraceTag, bool bInTraceComplex, IntPtr inIgnoreActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionQueryParams_AddIgnoredActor(IntPtr self, IntPtr inIgnoreActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionQueryParams_AddIgnoredComponent(IntPtr self, IntPtr inIgnoreComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionQueryParams_AddIgnoredComponent_LikelyDuplicatedRoot(IntPtr self, IntPtr inIgnoreComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionQueryParams_ClearIgnoredComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionQueryParams_SetNumIgnoredComponents(IntPtr self, int newNum);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FCollisionQueryParams_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether we want to find out initial overlap or not. If true, it will return if this was initial overlap.
		/// </summary>
		public bool bFindInitialOverlaps
		{
			get => E_PROP_FCollisionQueryParams_bFindInitialOverlaps_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_bFindInitialOverlaps_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to ignore blocking results.
		/// </summary>
		public bool bIgnoreBlocks
		{
			get => E_PROP_FCollisionQueryParams_bIgnoreBlocks_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_bIgnoreBlocks_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to ignore touch/overlap results.
		/// </summary>
		public bool bIgnoreTouches
		{
			get => E_PROP_FCollisionQueryParams_bIgnoreTouches_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_bIgnoreTouches_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we want to return the triangle face index for complex static mesh traces
		/// </summary>
		public bool bReturnFaceIndex
		{
			get => E_PROP_FCollisionQueryParams_bReturnFaceIndex_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_bReturnFaceIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we want to include the physical material in the results.
		/// </summary>
		public bool bReturnPhysicalMaterial
		{
			get => E_PROP_FCollisionQueryParams_bReturnPhysicalMaterial_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_bReturnPhysicalMaterial_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we should trace against complex collision
		/// </summary>
		public bool bTraceComplex
		{
			get => E_PROP_FCollisionQueryParams_bTraceComplex_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_bTraceComplex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// static variable for default data to be used without reconstructing everytime
		/// </summary>
		public static FCollisionQueryParams DefaultQueryParam
		{
			get => E_PROP_FCollisionQueryParams_DefaultQueryParam_GET();
		}

		
		/// <summary>
		/// Filters query by mobility types (static vs stationary/movable)
		/// </summary>
		public EQueryMobilityType MobilityType
		{
			get => (EQueryMobilityType)E_PROP_FCollisionQueryParams_MobilityType_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_MobilityType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Tag used to indicate an owner for this trace
		/// </summary>
		public string OwnerTag
		{
			get => E_PROP_FCollisionQueryParams_OwnerTag_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_OwnerTag_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Tag used to provide extra information or filtering for debugging of the trace (e.g. Collision Analyzer)
		/// </summary>
		public string TraceTag
		{
			get => E_PROP_FCollisionQueryParams_TraceTag_GET(NativePointer);
			set => E_PROP_FCollisionQueryParams_TraceTag_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add an actor for this trace to ignore
		/// </summary>
		public void AddIgnoredActor(AActor inIgnoreActor)
			=> E_FCollisionQueryParams_AddIgnoredActor(this, inIgnoreActor);
		
		
		/// <summary>
		/// Add a component for this trace to ignore
		/// </summary>
		public void AddIgnoredComponent(UPrimitiveComponent inIgnoreComponent)
			=> E_FCollisionQueryParams_AddIgnoredComponent(this, inIgnoreComponent);
		
		
		/// <summary>
		/// Special variant that hints that we are likely adding a duplicate of the root component or first ignored component.
		/// <para>Helps avoid invalidating the potential uniquess of the IgnoreComponents array. </para>
		/// </summary>
		public void AddIgnoredComponent_LikelyDuplicatedRoot(UPrimitiveComponent inIgnoreComponent)
			=> E_FCollisionQueryParams_AddIgnoredComponent_LikelyDuplicatedRoot(this, inIgnoreComponent);
		
		
		/// <summary>
		/// Clears the set of components to ignore during the trace.
		/// </summary>
		public void ClearIgnoredComponents()
			=> E_FCollisionQueryParams_ClearIgnoredComponents(this);
		
		
		/// <summary>
		/// Set the number of ignored components in the list. Uniqueness is not changed, it operates on the current state (unique or not).
		/// <para>Useful for temporarily adding some, then restoring to a previous size. NewNum must be <= number of current components for there to be any effect. </para>
		/// </summary>
		public void SetNumIgnoredComponents(int newNum)
			=> E_FCollisionQueryParams_SetNumIgnoredComponents(this, newNum);
		
		public override string ToString()
			=> E_FCollisionQueryParams_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FCollisionQueryParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCollisionQueryParams(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCollisionQueryParams(Adress, false);
		}}}
