using UnityEditor.Animations;

using UnityEngine;

namespace Character.Player
{
    [CreateAssetMenu( menuName = "Character/PlayerCharacterViewData" )]
    public class PlayerCharacterViewData : ScriptableObject
    {
        [SerializeField] string                      _name;
        [SerializeField] AnimatorOverrideController  _animController;
        [SerializeField] Sprite                      _defaultSprite;

        public string                     Name           => _name;
        public AnimatorOverrideController AnimController => _animController;
        public Sprite                     DefaultSprite  => _defaultSprite;
    }

}