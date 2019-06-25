// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\NavLinkProxy.h:24

namespace UnrealEngine
{
	public partial class ANavLinkProxy : AActor
	{
		public ANavLinkProxy(IntPtr adress)
			: base(adress)
		{
		}

		public ANavLinkProxy(UObject Parent = null, string Name = "NavLinkProxy")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ANavLinkProxy(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_ANavLinkProxy_bSmartLinkIsRelevant_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ANavLinkProxy_bSmartLinkIsRelevant_SET(IntPtr Ptr, bool Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ANavLinkProxy(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ANavLinkProxy_HasMovingAgents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ANavLinkProxy_IsSmartLinkEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ANavLinkProxy_ReceiveSmartLinkReached(IntPtr self, IntPtr agent, IntPtr destination);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ANavLinkProxy_ResumePathFollowing(IntPtr self, IntPtr agent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ANavLinkProxy_SetSmartLinkEnabled(IntPtr self, bool bEnabled);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Smart link: toggle relevancy
		/// </summary>
		public bool bSmartLinkIsRelevant
		{
			get => E_PROP_ANavLinkProxy_bSmartLinkIsRelevant_GET(NativePointer);
			set => E_PROP_ANavLinkProxy_bSmartLinkIsRelevant_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// check if any agent is moving through smart link right now
		/// </summary>
		public bool HasMovingAgents()
			=> E_ANavLinkProxy_HasMovingAgents(this);
		
		
		/// <summary>
		/// check if smart link is enabled
		/// </summary>
		public bool IsSmartLinkEnabled()
			=> E_ANavLinkProxy_IsSmartLinkEnabled(this);
		
		public void ReceiveSmartLinkReached(AActor agent, FVector destination)
			=> E_ANavLinkProxy_ReceiveSmartLinkReached(this, agent, destination);
		
		
		/// <summary>
		/// resume normal path following
		/// </summary>
		public void ResumePathFollowing(AActor agent)
			=> E_ANavLinkProxy_ResumePathFollowing(this, agent);
		
		
		/// <summary>
		/// change state of smart link
		/// </summary>
		public void SetSmartLinkEnabled(bool bEnabled)
			=> E_ANavLinkProxy_SetSmartLinkEnabled(this, bEnabled);
		
		#endregion
		
		public static implicit operator IntPtr(ANavLinkProxy self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ANavLinkProxy(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ANavLinkProxy>(PtrDesc);
		}}}
