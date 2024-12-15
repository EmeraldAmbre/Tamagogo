using UnityEngine;

namespace GameManagerAssembly {
    public class GameTimer : MonoBehaviour
    {
        #region Private Variables
        private static GameTimer instance;
        private float _elapsedTime = 0f;
        private bool _isTiming = false;
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

        void Start()
        {
            _isTiming = true;
        }

        void Update()
        {
            if (_isTiming)
            {
                _elapsedTime += Time.deltaTime;
                // Setting the time every second in PlayerPrefs
                if (Mathf.FloorToInt(_elapsedTime) % 1 == 0)
                {
                    SaveTime();
                }
            }
        }
        #endregion

        #region Private Methods
        private void SaveTime()
        {
            PlayerPrefs.SetFloat("GameTimer", _elapsedTime);
            PlayerPrefs.Save();
        }
        #endregion

        #region Public Methods
        public void StopTimer()
        {
            _isTiming = false;
            SaveTime();
        }

        public void ResetTimer()
        {
            _elapsedTime = 0f;
            PlayerPrefs.SetFloat("GameTimer", _elapsedTime);
            PlayerPrefs.Save();
        }

        public float GetElapsedTime()
        {
            return _elapsedTime;
        }
        #endregion

    }
}
