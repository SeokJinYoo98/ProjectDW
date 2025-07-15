using UnityEditor.Animations;

using UnityEngine;

namespace Character.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Animator))]
    public class PlayerCharacterView : MonoBehaviour
    {
        [SerializeField] private PlayerCharacterViewData _viewData;
        private Animator        _animator;
        private SpriteRenderer  _sr;
        private Rigidbody2D     _rb;
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
        }
        private void Awake()
        {
            _animator   = GetComponent<Animator>( );
            _sr         = GetComponent<SpriteRenderer>( );
            _rb         = GetComponent<Rigidbody2D>( );
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

        public void SetSpeed(float speed)    => _animator.SetFloat( "Speed", speed );
        public void PlayDeath()                 => _animator.SetTrigger( "Die" );
        public void Move(Vector2 moveDir, float speed)
        {
            _rb.linearVelocity = moveDir * speed;
            SetSpeed( speed );
        }
    }
}
