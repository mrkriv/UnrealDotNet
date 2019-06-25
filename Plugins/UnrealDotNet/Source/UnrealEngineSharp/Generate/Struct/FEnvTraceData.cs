// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:313

namespace UnrealEngine
{
	public partial class FEnvTraceData : NativeStructWrapper
	{
		public FEnvTraceData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvTraceData() :
			base(E_CreateStruct_FEnvTraceData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvTraceData_ExtentX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_ExtentX_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvTraceData_ExtentY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_ExtentY_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvTraceData_ExtentZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_ExtentZ_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvTraceData_PostProjectionVerticalOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_PostProjectionVerticalOffset_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvTraceData_ProjectDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_ProjectDown_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvTraceData_ProjectUp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_ProjectUp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvTraceData_VersionNum_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvTraceData_VersionNum_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvTraceData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvTraceData_OnPostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvTraceData_SetGeometryOnly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvTraceData_SetNavmeshOnly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FEnvTraceData_ToText(IntPtr self, byte descMode);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// shape parameter for trace
		/// </summary>
		public float ExtentX
		{
			get => E_PROP_FEnvTraceData_ExtentX_GET(NativePointer);
			set => E_PROP_FEnvTraceData_ExtentX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// shape parameter for trace
		/// </summary>
		public float ExtentY
		{
			get => E_PROP_FEnvTraceData_ExtentY_GET(NativePointer);
			set => E_PROP_FEnvTraceData_ExtentY_SET(NativePointer, value);
		}

		
		/// <summary>
		/// shape parameter for trace
		/// </summary>
		public float ExtentZ
		{
			get => E_PROP_FEnvTraceData_ExtentZ_GET(NativePointer);
			set => E_PROP_FEnvTraceData_ExtentZ_SET(NativePointer, value);
		}

		
		/// <summary>
		/// this value will be added to resulting location's Z axis. Can be useful when
		/// <para>projecting points to navigation since navmesh is just an approximation of level </para>
		/// geometry and items may end up being under collide-able geometry which would
		/// <para>for example falsify visibility tests. </para>
		/// </summary>
		public float PostProjectionVerticalOffset
		{
			get => E_PROP_FEnvTraceData_PostProjectionVerticalOffset_GET(NativePointer);
			set => E_PROP_FEnvTraceData_PostProjectionVerticalOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// search height: below point
		/// </summary>
		public float ProjectDown
		{
			get => E_PROP_FEnvTraceData_ProjectDown_GET(NativePointer);
			set => E_PROP_FEnvTraceData_ProjectDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// search height: above point
		/// </summary>
		public float ProjectUp
		{
			get => E_PROP_FEnvTraceData_ProjectUp_GET(NativePointer);
			set => E_PROP_FEnvTraceData_ProjectUp_SET(NativePointer, value);
		}

		public int VersionNum
		{
			get => E_PROP_FEnvTraceData_VersionNum_GET(NativePointer);
			set => E_PROP_FEnvTraceData_VersionNum_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void OnPostLoad()
			=> E_FEnvTraceData_OnPostLoad(this);
		
		public void SetGeometryOnly()
			=> E_FEnvTraceData_SetGeometryOnly(this);
		
		public void SetNavmeshOnly()
			=> E_FEnvTraceData_SetNavmeshOnly(this);
		
		public string ToText(EDescriptionMode descMode)
			=> E_FEnvTraceData_ToText(this, (byte)descMode);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvTraceData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvTraceData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvTraceData(adress, false);
		}}}
