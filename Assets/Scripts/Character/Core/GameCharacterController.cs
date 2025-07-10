using UnityEngine;
using GameCharacter.Model;
using GameCharacter.View;

namespace GameCharacter.Core
{
    public class GameCharacterController : MonoBehaviour
    {
        protected GameCharacterModel _model;
        protected GameCharacterView  _view;
        // Start is called once before the first execution of Update after the MonoBehaviour is created

        public void Init(GameCharacterModel model, GameCharacterView view)
        {
            _model = model;
            _view  = view;
        }


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

