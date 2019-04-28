using System;
using UnrealEngine;

namespace GameLogic
{
    public class PlayerController : ManagePlayerController
    {
        public float MoveForwardValue = 0;

        public PlayerController(IntPtr Adress) : base(Adress)
        {
        }

        protected override void BeginPlayingState()
        {
            base.BeginPlayingState();
            InputComponent.BindAction("Fire", EInputEvent.IE_Pressed, () => Ue.ScreenDebugMessage(GetWorld().GetMapName()));

            InputComponent.BindAction("Jump", EInputEvent.IE_Pressed, () => GetCharacter()?.Jump());
            InputComponent.BindAction("Jump", EInputEvent.IE_Released, () => GetCharacter()?.StopJumping());

            InputComponent.BindAxis("Turn", v => GetCharacter()?.AddControllerYawInput(v));
            InputComponent.BindAxis("LookUp", v => GetCharacter()?.AddControllerPitchInput(v));
            InputComponent.BindAxis("MoveForward", OnMoveForward);
            InputComponent.BindAxis("MoveRight", MoveRight);
        }

        private void OnMoveForward(float value)
        {
            var forvard = new FRotator(0, GetControlRotation().Yaw, 0).Vector();
            GetCharacter()?.AddMovementInput(forvard, value, false);

            Ue.ScreenDebugMessage(value.ToString("0.00"), 0);
            MoveForwardValue = value;
        }

        private void MoveRight(float value)
        {
            var right = new FRotator(0, GetControlRotation().Yaw + 90, 0).Vector();
            GetCharacter()?.AddMovementInput(right, value, false);
        }
    }
}