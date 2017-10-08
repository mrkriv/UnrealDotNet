using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FURL : NativeStructWrapper
	{
		internal FURL(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_FilterURLString(IntPtr Self, string Str);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FURL_IsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FURL_IsLocalInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_StaticExit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FURL_StaticInit(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Static: Removes any special URL characters from the specified string </para>
		/// <param name="Str">String to be filtered </param>
		/// </summary>
		public void FilterURLString(string Str)
			=> E_FURL_FilterURLString(this, Str);
		
		
		/// <summary>
		/// <para>Returns whether this URL corresponds to an internal object, i.e. an Unreal </para>
		/// <para>level which this app can try to connect to locally or on the net. If this </para>
		/// <para>is false, the URL refers to an object that a remote application like Internet </para>
		/// <para>Explorer can execute. </para>
		/// </summary>
		public bool IsInternal()
			=> E_FURL_IsInternal(this);
		
		
		/// <summary>
		/// <para>Returns whether this URL corresponds to an internal object on this local </para>
		/// <para>process. In this case, no Internet use is necessary. </para>
		/// </summary>
		public bool IsLocalInternal()
			=> E_FURL_IsLocalInternal(this);
		
		public void StaticExit()
			=> E_FURL_StaticExit(this);
		
		public void StaticInit()
			=> E_FURL_StaticInit(this);
		
		#endregion
		
		public static implicit operator IntPtr(FURL Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FURL(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FURL(Adress, false);
		}}}
