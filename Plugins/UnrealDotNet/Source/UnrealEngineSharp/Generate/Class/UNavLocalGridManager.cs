// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\NavLocalGridManager.h:27

namespace UnrealEngine
{
	public partial class UNavLocalGridManager : UObject
	{
		public UNavLocalGridManager(IntPtr adress)
			: base(adress)
		{
		}

		public UNavLocalGridManager(UObject Parent = null, string Name = "NavLocalGridManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UNavLocalGridManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UNavLocalGridManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UNavLocalGridManager_GetCellSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UNavLocalGridManager_GetCurrent(IntPtr self, IntPtr world);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UNavLocalGridManager_GetCurrent_o1(IntPtr self, IntPtr worldContextObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UNavLocalGridManager_GetGridIndex(IntPtr self, IntPtr worldLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UNavLocalGridManager_GetGridValueAt(IntPtr self, IntPtr worldLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UNavLocalGridManager_GetMaxActiveSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UNavLocalGridManager_GetNumGrids(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UNavLocalGridManager_GetNumSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UNavLocalGridManager_GetVersion(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavLocalGridManager_HasSourceGridLimit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavLocalGridManager_RebuildGrids(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavLocalGridManager_RemoveGridData(IntPtr self, int gridId, bool bUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavLocalGridManager_RemoveLocalNavigationGrid(IntPtr self, IntPtr worldContextObject, int gridId, bool bRebuildGrids);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavLocalGridManager_SetCellSize(IntPtr self, float cellSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavLocalGridManager_SetLocalNavigationGridDensity(IntPtr self, IntPtr worldContextObject, float cellSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavLocalGridManager_SetMaxActiveSources(IntPtr self, int numActiveSources);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UNavLocalGridManager_UpdateAccessTime(IntPtr self, int combinedGridIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UNavLocalGridManager_UpdateSourceGrids(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// get shared size of grid cell, static but there's only one active manager
		/// </summary>
		public float GetCellSize()
			=> E_UNavLocalGridManager_GetCellSize(this);
		
		public UNavLocalGridManager GetCurrent(UWorld world)
			=> E_UNavLocalGridManager_GetCurrent(this, world);
		
		public UNavLocalGridManager GetCurrent(UObject worldContextObject)
			=> E_UNavLocalGridManager_GetCurrent_o1(this, worldContextObject);
		
		
		/// <summary>
		/// find combined grid at location
		/// </summary>
		public int GetGridIndex(FVector worldLocation)
			=> E_UNavLocalGridManager_GetGridIndex(this, worldLocation);
		
		
		/// <summary>
		/// find combined grid value at world location
		/// </summary>
		public byte GetGridValueAt(FVector worldLocation)
			=> E_UNavLocalGridManager_GetGridValueAt(this, worldLocation);
		
		
		/// <summary>
		/// get limit of source grids
		/// </summary>
		public int GetMaxActiveSources()
			=> E_UNavLocalGridManager_GetMaxActiveSources(this);
		
		
		/// <summary>
		/// get number of combined, non overlapping grids
		/// </summary>
		public int GetNumGrids()
			=> E_UNavLocalGridManager_GetNumGrids(this);
		
		
		/// <summary>
		/// get number of known source grids
		/// </summary>
		public int GetNumSources()
			=> E_UNavLocalGridManager_GetNumSources(this);
		
		
		/// <summary>
		/// get version of grid data, incremented with each rebuild
		/// </summary>
		public int GetVersion()
			=> E_UNavLocalGridManager_GetVersion(this);
		
		
		/// <summary>
		/// check if source grid limit is set
		/// </summary>
		public bool HasSourceGridLimit()
			=> E_UNavLocalGridManager_HasSourceGridLimit(this);
		
		
		/// <summary>
		/// rebuild overlapping grids if needed
		/// </summary>
		public void RebuildGrids()
			=> E_UNavLocalGridManager_RebuildGrids(this);
		
		
		/// <summary>
		/// removes grid
		/// </summary>
		public void RemoveGridData(int gridId, bool bUpdate = true)
			=> E_UNavLocalGridManager_RemoveGridData(this, gridId, bUpdate);
		
		public void RemoveLocalNavigationGrid(UObject worldContextObject, int gridId, bool bRebuildGrids = true)
			=> E_UNavLocalGridManager_RemoveLocalNavigationGrid(this, worldContextObject, gridId, bRebuildGrids);
		
		
		/// <summary>
		/// set shared size of grid cell, allowed only when there's no grid added
		/// </summary>
		public bool SetCellSize(float cellSize)
			=> E_UNavLocalGridManager_SetCellSize(this, cellSize);
		
		public bool SetLocalNavigationGridDensity(UObject worldContextObject, float cellSize)
			=> E_UNavLocalGridManager_SetLocalNavigationGridDensity(this, worldContextObject, cellSize);
		
		
		/// <summary>
		/// set limit of source grids, 0 or negative means unlimited
		/// </summary>
		public void SetMaxActiveSources(int numActiveSources)
			=> E_UNavLocalGridManager_SetMaxActiveSources(this, numActiveSources);
		
		
		/// <summary>
		/// updates LastAccessTime in all source grids
		/// </summary>
		public void UpdateAccessTime(int combinedGridIdx)
			=> E_UNavLocalGridManager_UpdateAccessTime(this, combinedGridIdx);
		
		
		/// <summary>
		/// ensures limit of source grids, removing oldest entries (LastAccessTime)
		/// </summary>
		protected bool UpdateSourceGrids()
			=> E_UNavLocalGridManager_UpdateSourceGrids(this);
		
		#endregion
		
		public static implicit operator IntPtr(UNavLocalGridManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UNavLocalGridManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UNavLocalGridManager>(PtrDesc);
		}}}
