using UnityEngine;

namespace MonkePhone.UI
{
    internal class UIButton : MonoBehaviour
    {
        public App app;
        private float LastPressTime;
        private void OnTriggerEnter(Collider collider)
        {
            if (LastPressTime + 0.3f < Time.time && collider.GetComponentInParent<GorillaTriggerColliderHandIndicator>() != null)
            {
                LastPressTime = Time.time;
                GorillaTagger.Instance.StartVibration(false, 10, 0.1f);
                app.onClick.Invoke();
            }
        }
    }
}