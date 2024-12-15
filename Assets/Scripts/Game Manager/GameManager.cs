using UnityEngine;

namespace GameManagerAssembly
{
    public class GameManager : MonoBehaviour
    {
        #region Private Variables
        [SerializeField] GameTimer _gameTimer;
        [SerializeField] GameObject _uiDeathPanel;
        [SerializeField] GameObject _uiStatusPanel;

        bool _isStatusPanelActive = false;
        #endregion

        #region Unity API
        void Update() {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ToggleMenu();
            }
        }
        #endregion

        #region Public Methods
        public void ModifyUiDeathPanelVisibility(bool isVisible) {
            _uiDeathPanel.SetActive(isVisible);
        }

        public void ExitGameButton() {
            Application.Quit();
        }
        #endregion

        #region Private Methods
        void ToggleMenu() {
            _isStatusPanelActive = !_isStatusPanelActive;

            if (_uiStatusPanel != null) {
                _uiStatusPanel.SetActive(_isStatusPanelActive);
            }

            if (_isStatusPanelActive)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
        #endregion
    }
}
