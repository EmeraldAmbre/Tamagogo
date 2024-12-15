using UnityEngine;

namespace UI_Assembly {
    public class CustomCursor : MonoBehaviour {

        [SerializeField] Texture2D _cursorTexture;
        [SerializeField] Vector2 _hotSpot = Vector2.zero;
        [SerializeField] CursorMode _cursorMode = CursorMode.Auto;

        void Awake() {
            Cursor.SetCursor(_cursorTexture, _hotSpot, _cursorMode);
        }

        public void SetCustomCursor(Texture2D newCursorTexture) {
            Cursor.SetCursor(newCursorTexture, _hotSpot, _cursorMode);
        }

        public void ResetCursor() {
            Cursor.SetCursor(null, Vector2.zero, _cursorMode);
        }
    }
}
