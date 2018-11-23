#region Usings

using JetBrains.Annotations;
using UnityEngine;
// ReSharper disable MemberCanBePrivate.Global

#endregion

namespace Assets.Scripts.UI_Scripts
{
    public class UiAutoResize : MonoBehaviour
    {
        public bool ActiveUpdate = false;
        public Vector2 ElementSize = new Vector2(25, 25);

        private RectTransform _rectTransform;

        [UsedImplicitly]
        private void Start()
        {
            _rectTransform = gameObject.GetComponent<RectTransform>();

            Vector2 sizeVector2 = new Vector2((ElementSize.x / 100) * Screen.width, (ElementSize.y / 100) * Screen.height);

            _rectTransform.sizeDelta = sizeVector2;
        }

        [UsedImplicitly]
        private void Update()
        {
            if(ActiveUpdate)
                Start();
        }
    }
}