using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UObjectBaseUtility : UObjectBase
	{
		public UObjectBaseUtility(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UObjectBaseUtility_GetLinkerIndex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UObjectBaseUtility_GetLinkerUE4Version(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObjectBaseUtility_IsDefaultSubobject(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns this object's LinkerIndex. </para>
		/// <return>the index into my linker's ExportMap for the FObjectExport </return>
		/// <para>corresponding to this object. </para>
		/// </summary>
		public int GetLinkerIndex()
			=> E_UObjectBaseUtility_GetLinkerIndex(this);
		
		
		/// <summary>
		/// <para>Returns the licensee version of the linker for this object. </para>
		/// <return>the licensee version of the engine's package file when this object </return>
		/// <para>was last saved, or GPackageFileLicenseeVersion (current version) if </para>
		/// <para>this object does not have a linker, which indicates that </para>
		/// <para>a) this object is a native only class, or </para>
		/// <para>b) this object's linker has been detached, in which case it is already fully loaded </para>
		/// </summary>
		public int GetLinkerLicenseeUE4Version()
			=> E_UObjectBaseUtility_GetLinkerLicenseeUE4Version(this);
		
		
		/// <summary>
		/// <para>Returns the UE4 version of the linker for this object. </para>
		/// <return>the UE4 version of the engine's package file when this object </return>
		/// <para>was last saved, or GPackageFileUE4Version (current version) if </para>
		/// <para>this object does not have a linker, which indicates that </para>
		/// <para>a) this object is a native only class, or </para>
		/// <para>b) this object's linker has been detached, in which case it is already fully loaded </para>
		/// </summary>
		public int GetLinkerUE4Version()
			=> E_UObjectBaseUtility_GetLinkerUE4Version(this);
		
		
		/// <summary>
		/// <para>Returns whether this component was instanced from a component/subobject template, or if it is a component/subobject template. </para>
		/// <para>This is based on a name comparison with the outer class instance lookup table </para>
		/// <return>true if this component was instanced from a template.  false if this component was created manually at runtime. </return>
		/// </summary>
		public bool IsDefaultSubobject()
			=> E_UObjectBaseUtility_IsDefaultSubobject(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObjectBaseUtility Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObjectBaseUtility(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UObjectBaseUtility ?? new UObjectBaseUtility(Adress);
		}}}
