// This file was created automatically, do not modify the contents of this file.

namespace UnrealEngine
{
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:46
	
	public delegate void FActorBeginCursorOverSignature(AActor touchedActor);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:42
	
	public delegate void FActorBeginOverlapSignature(AActor overlappedActor, AActor otherActor);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:76
	
	public delegate void FActorComponentActivatedSignature(UActorComponent component, bool bReset);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:77
	
	public delegate void FActorComponentDeactivateSignature(UActorComponent component);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:55
	
	public delegate void FActorDestroyedSignature(AActor destroyedActor);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:47
	
	public delegate void FActorEndCursorOverSignature(AActor touchedActor);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:43
	
	public delegate void FActorEndOverlapSignature(AActor overlappedActor, AActor otherActor);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Actor.h:44
	
	public delegate void FActorHitSignature(AActor selfActor, AActor otherActor, FVector normalImpulse, FHitResult hit);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:31
	
	public delegate void FCharacterMovementUpdatedSignature(float deltaSeconds, FVector oldLocation, FVector oldVelocity);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:32
	
	public delegate void FCharacterReachedApexSignature();
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:155
	
	public delegate void FComponentBeginCursorOverSignature(UPrimitiveComponent touchedComponent);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:145
	
	public delegate void FComponentBeginOverlapSignature(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, FHitResult sweepResult);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:153
	
	public delegate void FComponentCollisionSettingsChangedSignature(UPrimitiveComponent changedComponent);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:156
	
	public delegate void FComponentEndCursorOverSignature(UPrimitiveComponent touchedComponent);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:147
	
	public delegate void FComponentEndOverlapSignature(UPrimitiveComponent overlappedComponent, AActor otherActor, UPrimitiveComponent otherComp, int otherBodyIndex);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:143
	
	public delegate void FComponentHitSignature(UPrimitiveComponent hitComponent, AActor otherActor, UPrimitiveComponent otherComp, FVector normalImpulse, FHitResult hit);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:151
	
	public delegate void FComponentSleepSignature(UPrimitiveComponent sleepingComponent, string boneName);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:149
	
	public delegate void FComponentWakeSignature(UPrimitiveComponent wakingComponent, string boneName);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3533
	
	public delegate void FConstraintBrokenSignature(int constraintIndex);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:33
	
	public delegate void FLandedSignature(FHitResult hit);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:30
	
	public delegate void FMovementModeChangedSignature(ACharacter character, EMovementMode prevMovementMode, byte previousCustomMode);
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:46
	
	public delegate void FOnAnimInitialized();
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:19
	
	public delegate void FOnAudioFinished();
	// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:49
	
	public delegate void FOnAudioMultiEnvelopeValue(float averageEnvelopeValue, float maxEnvelope, int numWaveInstances);
}
