using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player.Handler
{
    public interface IInputHandler
    {
        Vector2 Move { get; }
    }
    public class PlayerInputHandler : IInputHandler
    {
        protected PlayerInput _input;
        public PlayerInputHandler(PlayerInput input)
        {
            _input = input;
        }
        public Vector2 Move => _input.actions["Move"].ReadValue<Vector2>( );
    }
}