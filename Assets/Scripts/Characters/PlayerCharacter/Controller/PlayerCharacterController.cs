using UnityEngine;
using UnityEngine.InputSystem;

namespace Character.Player
{
    
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

        public void Move(Vector2 moveDir)
            => _view.Move( moveDir, moveDir.magnitude );
    }
}

