using UnityEngine;
using UnityEngine.InputSystem;

namespace Character.Player
{
    [RequireComponent( typeof(Rigidbody2D))]
    [RequireComponent( typeof(PlayerCharacterView))]
    public class PlayerCharacterController : MonoBehaviour
    {
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
        }
        private void OnDestroy()
        {
        }
        // Update is called once per frame
        void Update()
        {
        }

        private void OnNumPressed(int num)
        {
            _view.ChangeAnim( num );
        }
    }
}

