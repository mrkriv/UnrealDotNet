namespace UnrealEngine
{
	public delegate void FCharacterMovementUpdatedSignature(float DeltaSeconds, FVector OldLocation, FVector OldVelocity);
	public delegate void FCharacterReachedApexSignature();
	public delegate void FConstraintBrokenSignature(int ConstraintIndex);
	public delegate void FOnAnimInitialized();
	public delegate void FOnAudioFinished();
}
