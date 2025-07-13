using UnityEngine;
using Character.Player;
namespace Player
{
    using Player.Handler;

    using UnityEngine.InputSystem;

    [RequireComponent(typeof(PlayerInput))]
    public class PlayerPresenter : MonoBehaviour
    {
        private PlayerCharacterController _character;
        private IInputHandler             _inputHandler;
        public void Init(PlayerCharacterController character) => _character = character; 
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _character    = GetComponentInChildren<PlayerCharacterController>( );
            _inputHandler = new PlayerInputHandler( GetComponent<PlayerInput>( ) );
        }

        // Update is called once per frame
        void Update()
        {
            _character.Move( _inputHandler.Move );
        }
    }
}

