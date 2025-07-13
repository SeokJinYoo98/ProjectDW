using UnityEditor.Animations;

using UnityEngine;

namespace Character.Player
{
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Animator))]
    [RequireComponent(typeof(AnimatorController))]
    public class PlayerCharacterView : MonoBehaviour
    {
        [SerializeField] private PlayerCharacterViewData _viewData;
        private Animator        _animator;
        private SpriteRenderer  _sr;
        public void SetViewData(PlayerCharacterViewData viewData)
        {
            _viewData = viewData;
            ApplyViewData( );
        }
        private void ApplyViewData()
        {
            if (_viewData == null) return;

            _sr.sprite = _viewData.DefaultSprite;
            _animator.runtimeAnimatorController =  _viewData.AnimController;
            ChangeAnim( 0 );
        }
        private void Awake()
        {
            _animator   = GetComponent<Animator>( );
            _sr         = GetComponent<SpriteRenderer>( );
            
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            ApplyViewData( );
        }

        // Update is called once per frame
        void Update()
        {
        }

        public void ChangeAnim(int num)
        {
            switch (num)
            {
                case 1: 
                    SetMovement( 0f );
                    break;
                case 2: 
                    SetMovement( 0.5f );
                    break;
                case 3: 
                    SetMovement( 1.5f );
                    break;
                case 4:
                    PlayDeath( );
                    break;
                default: break;
            }
        }
        public void SetMovement(float speed)    => _animator.SetFloat( "Speed", speed );
        public void PlayDeath()                 => _animator.SetTrigger( "Die" );
    }
}
