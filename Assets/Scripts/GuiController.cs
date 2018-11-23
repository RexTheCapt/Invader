#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class GuiController : MonoBehaviour
    {
        public DataHolder DataHolder;
        public GameObject NukeChargeGameObject;
        public GameObject ShieldChargeGameObject;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            RectTransform rectTransform;
            Vector3 localScale;

            // Update the nuke charge
            rectTransform = NukeChargeGameObject.GetComponent<RectTransform>();
            localScale = rectTransform.localScale;
            localScale.y = DataHolder.NukeCharge;

            rectTransform.localScale = localScale;

            // Update the shield charge
            rectTransform = ShieldChargeGameObject.GetComponent<RectTransform>();
            localScale = rectTransform.localScale;
            localScale.y = DataHolder.ShieldCharge;

            rectTransform.localScale = localScale;
        }
    }
}