using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UStaticMeshComponent : UMeshComponent
	{
		public UStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UStaticMeshComponent(UObject Parent = null, string Name = "StaticMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UStaticMeshComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UStaticMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_AddSpeedTreeWind(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_CachePaintedDataIfNecessary(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(IntPtr Self, IntPtr SourceComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(IntPtr Self, bool bRebuildingStaticMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_GetEstimatedLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(IntPtr Self, int InWidth, int InHeight, int OutLightMapMemoryUsage, int OutShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_ReleaseResources(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(IntPtr Self, int LODToRemoveColorsFrom);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_RemoveSpeedTreeWind(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_SetMaterialPreview(IntPtr Self, int InMaterialIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_SetSectionPreview(IntPtr Self, int InSectionIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Register this component's render data with the scene for SpeedTree wind </para>
		/// </summary>
		public void AddSpeedTreeWind()
			=> E_UStaticMeshComponent_AddSpeedTreeWind(this);
		
		
		/// <summary>
		/// <para>Save off the data painted on to this mesh per LOD if necessary </para>
		/// </summary>
		public void CachePaintedDataIfNecessary()
			=> E_UStaticMeshComponent_CachePaintedDataIfNecessary(this);
		
		
		/// <summary>
		/// <para>Copies instance vertex colors from the SourceComponent into this component </para>
		/// <param name="SourceComponent">The component to copy vertex colors from </param>
		/// </summary>
		public void CopyInstanceVertexColorsIfCompatible(UStaticMeshComponent SourceComponent)
			=> E_UStaticMeshComponent_CopyInstanceVertexColorsIfCompatible(this, SourceComponent);
		
		
		/// <summary>
		/// <para>Update the vertex override colors if necessary (i.e. vertices from source mesh have changed from override colors) </para>
		/// <param name="bRebuildingStaticMesh">true if we are rebuilding the static mesh used by this component </param>
		/// <para>@returns true if any fixup was performed. </para>
		/// </summary>
		public bool FixupOverrideColorsIfNecessary(bool bRebuildingStaticMesh = false)
			=> E_UStaticMeshComponent_FixupOverrideColorsIfNecessary(this, bRebuildingStaticMesh);
		
		
		/// <summary>
		/// <para>Get this components index in its parents blueprint created components array (used for matching instance data) </para>
		/// </summary>
		public int GetBlueprintCreatedComponentIndex()
			=> E_UStaticMeshComponent_GetBlueprintCreatedComponentIndex(this);
		
		
		/// <summary>
		/// <para>Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps. </para>
		/// <para>This will return the value assuming the primitive will be automatically switched to use texture mapping. </para>
		/// <param name="Width">[out]	Width of light/shadow map </param>
		/// <param name="Height">[out]	Height of light/shadow map </param>
		/// </summary>
		public virtual void GetEstimatedLightMapResolution(int Width, int Height)
			=> E_UStaticMeshComponent_GetEstimatedLightMapResolution(this, Width, Height);
		
		
		/// <summary>
		/// <para>Get the memory used for texture-based light and shadow maps of the given width and height </para>
		/// <param name="InWidth">The desired width of the light/shadow map </param>
		/// <param name="InHeight">The desired height of the light/shadow map </param>
		/// <param name="OutLightMapMemoryUsage">The resulting lightmap memory used </param>
		/// <param name="OutShadowMapMemoryUsage">The resulting shadowmap memory used </param>
		/// </summary>
		public virtual void GetTextureLightAndShadowMapMemoryUsage(int InWidth, int InHeight, int OutLightMapMemoryUsage, int OutShadowMapMemoryUsage)
			=> E_UStaticMeshComponent_GetTextureLightAndShadowMapMemoryUsage(this, InWidth, InHeight, OutLightMapMemoryUsage, OutShadowMapMemoryUsage);
		
		public void ReleaseResources()
			=> E_UStaticMeshComponent_ReleaseResources(this);
		
		
		/// <summary>
		/// <para>Removes instance vertex colors from all LODs </para>
		/// </summary>
		public void RemoveInstanceVertexColors()
			=> E_UStaticMeshComponent_RemoveInstanceVertexColors(this);
		
		
		/// <summary>
		/// <para>Removes instance vertex colors from the specified LOD </para>
		/// <param name="LODToRemoveColorsFrom">Index of the LOD to remove instance colors from </param>
		/// </summary>
		public void RemoveInstanceVertexColorsFromLOD(int LODToRemoveColorsFrom)
			=> E_UStaticMeshComponent_RemoveInstanceVertexColorsFromLOD(this, LODToRemoveColorsFrom);
		
		
		/// <summary>
		/// <para>Unregister this component's render data with the scene for SpeedTree wind </para>
		/// </summary>
		public void RemoveSpeedTreeWind()
			=> E_UStaticMeshComponent_RemoveSpeedTreeWind(this);
		
		
		/// <summary>
		/// <para>Determines whether any of the component's LODs require override vertex color fixups </para>
		/// <return>true if any LODs require override vertex color fixups </return>
		/// </summary>
		public bool RequiresOverrideVertexColorsFixup()
			=> E_UStaticMeshComponent_RequiresOverrideVertexColorsFixup(this);
		
		
		/// <summary>
		/// <para>Sets the value of the MaterialIndexPreview flag and reattaches the component as necessary. </para>
		/// <param name="InMaterialIndexPreview">New value of MaterialIndexPreview. </param>
		/// </summary>
		public void SetMaterialPreview(int InMaterialIndexPreview)
			=> E_UStaticMeshComponent_SetMaterialPreview(this, InMaterialIndexPreview);
		
		
		/// <summary>
		/// <para>Sets the value of the SectionIndexPreview flag and reattaches the component as necessary. </para>
		/// <param name="InSectionIndexPreview">New value of SectionIndexPreview. </param>
		/// </summary>
		public void SetSectionPreview(int InSectionIndexPreview)
			=> E_UStaticMeshComponent_SetSectionPreview(this, InSectionIndexPreview);
		
		
		/// <summary>
		/// <para>Sets the BodyInstance to use the mesh's body setup for external collision information </para>
		/// </summary>
		public void UpdateCollisionFromStaticMesh()
			=> E_UStaticMeshComponent_UpdateCollisionFromStaticMesh(this);
		
		#endregion
		
		public static implicit operator IntPtr(UStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UStaticMeshComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UStaticMeshComponent ?? new UStaticMeshComponent(Adress);
		}}}
