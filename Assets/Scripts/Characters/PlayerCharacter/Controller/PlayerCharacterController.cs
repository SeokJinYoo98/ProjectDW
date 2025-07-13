using UnityEngine;
using UnityEngine.InputSystem;

namespace Character.Player
{
    [RequireComponent( typeof(Rigidbody2D))]
    [RequireComponent( typeof(PlayerCharacterView))]
    public class PlayerCharacterController : MonoBehaviour
    {
        private   PlayerInput          _input;
        protected PlayerCharacterModel _model;
        protected PlayerCharacterView  _view;
        // Start is called once before the first execution of Update after the MonoBehaviour is created

        
        public void Init(PlayerCharacterModel model, PlayerCharacterView view)
        {
            _model = model;
            _view  = view;
        }
        void Start()
        {
            _view  = GetComponent<PlayerCharacterView>();
            _input = GetComponent<PlayerInput>();

            _input.actions["Num1"].performed += ctx => OnNumPressed( 1 );
            _input.actions["Num2"].performed += ctx => OnNumPressed( 2 );
            _input.actions["Num3"].performed += ctx => OnNumPressed( 3 );
            _input.actions["Num4"].performed += ctx => OnNumPressed( 4 );

        }
        private void OnDestroy()
        {
            _input.actions["Num1"].performed -= ctx => OnNumPressed( 1 );
            _input.actions["Num2"].performed -= ctx => OnNumPressed( 2 );
            _input.actions["Num3"].performed -= ctx => OnNumPressed( 3 );
            _input.actions["Num4"].performed -= ctx => OnNumPressed( 4 );
        }
        // Update is called once per frame
        void Update()
        {
        }

        private void OnNumPressed(int num)
        {
            Debug.Log( $"{num}" );
            _view.ChangeAnim( num );
        }
    }
}

