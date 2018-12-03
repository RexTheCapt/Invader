#region Usings

using JetBrains.Annotations;
using UnityEngine;

#endregion

namespace Assets.Scripts
{
    public class GuiController : MonoBehaviour
    {
        [UsedImplicitly] public ArenaController DataHolder;
        [UsedImplicitly] public GameObject NukeChargeGameObject;
        [UsedImplicitly] public GameObject ShieldChargeGameObject;

        // Use this for initialization
        [UsedImplicitly]
        private void Start()
        {
        }

        // Update is called once per frame
        [UsedImplicitly]
        private void Update()
        {
            // Update the nuke charge
            RectTransform rectTransform = NukeChargeGameObject.GetComponent<RectTransform>();
            Vector3 localScale = rectTransform.localScale;
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