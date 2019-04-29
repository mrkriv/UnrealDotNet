using System;
using Newtonsoft.Json;
using UnrealEngine;

namespace GameLogic
{
    public class PlayerController : ManagePlayerController
    {
        public PlayerController(IntPtr Adress) : base(Adress)
        {
        }

        protected override void BeginPlayingState()
        {
            base.BeginPlayingState();
            
            InputComponent.BindAction("Fire", EInputEvent.IE_Pressed, OnFire);

            InputComponent.BindAction("Jump", EInputEvent.IE_Pressed, () => GetCharacter()?.Jump());
            InputComponent.BindAction("Jump", EInputEvent.IE_Released, () => GetCharacter()?.StopJumping());

            InputComponent.BindAxis("Turn", v => GetCharacter()?.AddControllerYawInput(v));
            InputComponent.BindAxis("LookUp", v => GetCharacter()?.AddControllerPitchInput(v));
            InputComponent.BindAxis("MoveForward", OnMoveForward);
            InputComponent.BindAxis("MoveRight", MoveRight);
        }

        private void OnFire()
        {
            var character = GetCharacter();
            var result = new FHitResult();

            GetWorld().DebugDrawTraceTag = "test";

            GetWorld().LineTraceSingleByChannel(
                result,
                character.GetCapsuleComponent().GetWorldLocation(),
                character.GetCapsuleComponent().GetWorldLocation() + GetControlRotation().Vector() * 800,
                ECollisionChannel.ECC_Visibility,
                new FCollisionQueryParams("test", true, null),
                new FCollisionResponseParams(ECollisionResponse.ECR_Block)
            );


            Ue.ScreenDebugMessage(result.GetActor()?.GetName(), 20);
            Ue.ScreenDebugMessage(character.GetCapsuleComponent().GetWorldLocation().ToString(), 5, System.Drawing.Color.Red);
        }

        public override void Tick(float deltaSeconds)
        {
            Ue.ScreenDebugMessage(GetCharacter().GetActorLocation().ToString(), 0);
        }

        private void OnMoveForward(float value)
        {
            var forvard = new FRotator(0, GetControlRotation().Yaw, 0).Vector();
            GetCharacter()?.AddMovementInput(forvard, value, false);
        }

        private void MoveRight(float value)
        {
            var right = new FRotator(0, GetControlRotation().Yaw + 90, 0).Vector();
            GetCharacter()?.AddMovementInput(right, value, false);
        }
    }
}