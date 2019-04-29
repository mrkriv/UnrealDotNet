// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:265

namespace UnrealEngine
{
	public  partial class FHierarchicalSimplification : NativeStructWrapper
	{
		internal FHierarchicalSimplification(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FHierarchicalSimplification() :
			base(E_CreateStruct_FHierarchicalSimplification(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHierarchicalSimplification_bAllowSpecificExclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_bAllowSpecificExclusion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHierarchicalSimplification_bOnlyGenerateClustersForVolumes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_bOnlyGenerateClustersForVolumes_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHierarchicalSimplification_bReusePreviousLevelClusters_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_bReusePreviousLevelClusters_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHierarchicalSimplification_bSimplifyMesh_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_bSimplifyMesh_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FHierarchicalSimplification_bUseOverrideDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_bUseOverrideDrawDistance_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHierarchicalSimplification_DesiredBoundRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_DesiredBoundRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHierarchicalSimplification_DesiredFillingPercentage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_DesiredFillingPercentage_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FHierarchicalSimplification_MinNumberOfActorsToBuild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_MinNumberOfActorsToBuild_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHierarchicalSimplification_OverrideDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_OverrideDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FHierarchicalSimplification_TransitionScreenSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FHierarchicalSimplification_TransitionScreenSize_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FHierarchicalSimplification();
		
		#endregion
		
		#region Property
		public byte bAllowSpecificExclusion
		{
			get => E_PROP_FHierarchicalSimplification_bAllowSpecificExclusion_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_bAllowSpecificExclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Min number of actors to build LODActor
		/// </summary>
		public byte bOnlyGenerateClustersForVolumes
		{
			get => E_PROP_FHierarchicalSimplification_bOnlyGenerateClustersForVolumes_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_bOnlyGenerateClustersForVolumes_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Will reuse the clusters generated for the previous (lower) HLOD level
		/// </summary>
		public byte bReusePreviousLevelClusters
		{
			get => E_PROP_FHierarchicalSimplification_bReusePreviousLevelClusters_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_bReusePreviousLevelClusters_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If this is true, it will simplify mesh but it is slower.
		/// <para>If false, it will just merge actors but not simplify using the lower LOD if exists. </para>
		/// For example if you build LOD 1, it will use LOD 1 of the mesh to merge actors if exists.
		/// <para>If you merge material, it will reduce drawcalls. </para>
		/// </summary>
		public byte bSimplifyMesh
		{
			get => E_PROP_FHierarchicalSimplification_bSimplifyMesh_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_bSimplifyMesh_SET(NativePointer, value);
		}

		public byte bUseOverrideDrawDistance
		{
			get => E_PROP_FHierarchicalSimplification_bUseOverrideDrawDistance_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_bUseOverrideDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Desired Bounding Radius for clustering - this is not guaranteed but used to calculate filling factor for auto clustering
		/// </summary>
		public float DesiredBoundRadius
		{
			get => E_PROP_FHierarchicalSimplification_DesiredBoundRadius_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_DesiredBoundRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Desired Filling Percentage for clustering - this is not guaranteed but used to calculate filling factor  for auto clustering
		/// </summary>
		public float DesiredFillingPercentage
		{
			get => E_PROP_FHierarchicalSimplification_DesiredFillingPercentage_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_DesiredFillingPercentage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Min number of actors to build LODActor
		/// </summary>
		public int MinNumberOfActorsToBuild
		{
			get => E_PROP_FHierarchicalSimplification_MinNumberOfActorsToBuild_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_MinNumberOfActorsToBuild_SET(NativePointer, value);
		}

		public float OverrideDrawDistance
		{
			get => E_PROP_FHierarchicalSimplification_OverrideDrawDistance_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_OverrideDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The screen radius an mesh object should reach before swapping to the LOD actor, once one of parent displays, it won't draw any of children.
		/// </summary>
		public float TransitionScreenSize
		{
			get => E_PROP_FHierarchicalSimplification_TransitionScreenSize_GET(NativePointer);
			set => E_PROP_FHierarchicalSimplification_TransitionScreenSize_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FHierarchicalSimplification self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FHierarchicalSimplification(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FHierarchicalSimplification(Adress, false);
		}}}
