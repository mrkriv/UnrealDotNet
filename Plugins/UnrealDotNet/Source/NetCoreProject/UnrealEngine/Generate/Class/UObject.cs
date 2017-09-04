using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UObject : UObjectBaseUtility
	{
		public UObject(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_CanCreateInCurrentContext(IntPtr Self, IntPtr Template);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_CanModify(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObject_GetWorldChecked(IntPtr Self, bool bSupported);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_ImplementsGetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObject_IsSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObject_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UArrowComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UAudioComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UBillboardComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UBoxComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UCapsuleComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UChildActorComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UDecalComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UDirectionalLightComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UExponentialHeightFogComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UMaterialBillboardComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UPawnNoiseEmitterComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UPlanarReflectionComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UPointLightComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UPostProcessComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USceneCaptureComponent2D(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USceneCaptureComponentCube(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USceneComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UShapeComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USkyLightComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USphereComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USpotLightComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_USpringArmComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UStaticMeshComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UTextRenderComponent(IntPtr Self, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateOptionalDefaultSubobject_UVectorFieldComponent(IntPtr Self, string Name);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public virtual void BeginDestroy()
			=> E_UObject_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Determines if you can create an object from the supplied template in the current context (editor, client only, dedicated server, game/listen) </para>
		/// <para>This calls NeedsLoadForClient & NeedsLoadForServer </para>
		/// </summary>
		public bool CanCreateInCurrentContext(UObject Template)
			=> E_UObject_CanCreateInCurrentContext(this, Template);
		
		
		/// <summary>
		/// <para>Utility to allow overrides of Modify to avoid doing work if the base class is not going modify anyways. </para>
		/// </summary>
		public bool CanModify()
			=> E_UObject_CanModify(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public virtual void FinishDestroy()
			=> E_UObject_FinishDestroy(this);
		
		public UWorld GetWorldChecked(bool bSupported)
			=> E_UObject_GetWorldChecked(this, bSupported);
		
		public bool ImplementsGetWorld()
			=> E_UObject_ImplementsGetWorld(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public bool IsSelected()
			=> E_UObject_IsSelected(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public virtual void PostCDOContruct()
			=> E_UObject_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public virtual void PostEditImport()
			=> E_UObject_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor and after the properties have been initialized, including those loaded from config. </para>
		/// <para>mainly this is to emulate some behavior of when the constructor was called after the properties were initialized. </para>
		/// </summary>
		public virtual void PostInitProperties()
			=> E_UObject_PostInitProperties(this);
		
		
		/// <summary>
		/// <para>Do any object-specific cleanup required immediately after loading an object, </para>
		/// <para>and immediately after any undo/redo. </para>
		/// </summary>
		public virtual void PostLoad()
			=> E_UObject_PostLoad(this);
		
		
		/// <summary>
		/// <para>Called right after receiving a bunch </para>
		/// </summary>
		public virtual void PostNetReceive()
			=> E_UObject_PostNetReceive(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public virtual void PostRename(UObject OldOuter, string OldName)
			=> E_UObject_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public virtual void PostRepNotifies()
			=> E_UObject_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public virtual void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UObject_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public virtual void PreDestroyFromReplication()
			=> E_UObject_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// <para>Called right before receiving a bunch </para>
		/// </summary>
		public virtual void PreNetReceive()
			=> E_UObject_PreNetReceive(this);
		
		public virtual void ShutdownAfterError()
			=> E_UObject_ShutdownAfterError(this);
		
		public UArrowComponent CreateOptionalDefaultSubobject_UArrowComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UArrowComponent(NativePointer, Name);
		
		public UAudioComponent CreateOptionalDefaultSubobject_UAudioComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UAudioComponent(NativePointer, Name);
		
		public UBillboardComponent CreateOptionalDefaultSubobject_UBillboardComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UBillboardComponent(NativePointer, Name);
		
		public UBoxComponent CreateOptionalDefaultSubobject_UBoxComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UBoxComponent(NativePointer, Name);
		
		public UCapsuleComponent CreateOptionalDefaultSubobject_UCapsuleComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UCapsuleComponent(NativePointer, Name);
		
		public UChildActorComponent CreateOptionalDefaultSubobject_UChildActorComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UChildActorComponent(NativePointer, Name);
		
		public UDecalComponent CreateOptionalDefaultSubobject_UDecalComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UDecalComponent(NativePointer, Name);
		
		public UDirectionalLightComponent CreateOptionalDefaultSubobject_UDirectionalLightComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UDirectionalLightComponent(NativePointer, Name);
		
		public UExponentialHeightFogComponent CreateOptionalDefaultSubobject_UExponentialHeightFogComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UExponentialHeightFogComponent(NativePointer, Name);
		
		public UInstancedStaticMeshComponent CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UInstancedStaticMeshComponent(NativePointer, Name);
		
		public UMaterialBillboardComponent CreateOptionalDefaultSubobject_UMaterialBillboardComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UMaterialBillboardComponent(NativePointer, Name);
		
		public UPawnNoiseEmitterComponent CreateOptionalDefaultSubobject_UPawnNoiseEmitterComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UPawnNoiseEmitterComponent(NativePointer, Name);
		
		public UPlanarReflectionComponent CreateOptionalDefaultSubobject_UPlanarReflectionComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UPlanarReflectionComponent(NativePointer, Name);
		
		public UPointLightComponent CreateOptionalDefaultSubobject_UPointLightComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UPointLightComponent(NativePointer, Name);
		
		public UPostProcessComponent CreateOptionalDefaultSubobject_UPostProcessComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UPostProcessComponent(NativePointer, Name);
		
		public USceneCaptureComponent2D CreateOptionalDefaultSubobject_USceneCaptureComponent2D(string Name) 
			=> E_CreateOptionalDefaultSubobject_USceneCaptureComponent2D(NativePointer, Name);
		
		public USceneCaptureComponentCube CreateOptionalDefaultSubobject_USceneCaptureComponentCube(string Name) 
			=> E_CreateOptionalDefaultSubobject_USceneCaptureComponentCube(NativePointer, Name);
		
		public USceneComponent CreateOptionalDefaultSubobject_USceneComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USceneComponent(NativePointer, Name);
		
		public UShapeComponent CreateOptionalDefaultSubobject_UShapeComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UShapeComponent(NativePointer, Name);
		
		public USkyLightComponent CreateOptionalDefaultSubobject_USkyLightComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USkyLightComponent(NativePointer, Name);
		
		public USphereComponent CreateOptionalDefaultSubobject_USphereComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USphereComponent(NativePointer, Name);
		
		public USpotLightComponent CreateOptionalDefaultSubobject_USpotLightComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USpotLightComponent(NativePointer, Name);
		
		public USpringArmComponent CreateOptionalDefaultSubobject_USpringArmComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_USpringArmComponent(NativePointer, Name);
		
		public UStaticMeshComponent CreateOptionalDefaultSubobject_UStaticMeshComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UStaticMeshComponent(NativePointer, Name);
		
		public UTextRenderComponent CreateOptionalDefaultSubobject_UTextRenderComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UTextRenderComponent(NativePointer, Name);
		
		public UVectorFieldComponent CreateOptionalDefaultSubobject_UVectorFieldComponent(string Name) 
			=> E_CreateOptionalDefaultSubobject_UVectorFieldComponent(NativePointer, Name);
		
		#endregion
		
		public static implicit operator IntPtr(UObject Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObject(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UObject ?? new UObject(Adress);
		}}}
