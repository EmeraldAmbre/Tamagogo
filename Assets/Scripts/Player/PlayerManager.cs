using GameManagerAssembly;
using UnityEditor.Build.Content;
using UnityEngine;

namespace PlayerAssembly {
    public class PlayerManager : MonoBehaviour {

        #region Public Variables
        public bool IsHungry { get; private set; }
        public bool IsThirsty { get; private set; }
        public bool NeedPoop { get; private set; }
        #endregion

        #region Private Variables
        private static PlayerManager instance;
        [SerializeField] GameManager _gameManager;
        [SerializeField] GameTimer _gameTimer;
        #endregion

        #region Unity API
        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        void Update()
        {

        }
        #endregion

        #region Private Methods
        void Death() {
            _gameManager.ModifyUiDeathPanelVisibility(true);
        }

        void BecomingHungry() {
            IsHungry = true;
        }

        void BecomingThirsty() {
            IsThirsty = true;
        }

        void NeedPooping() {
            NeedPoop = true;
        }
        #endregion
    }
}
