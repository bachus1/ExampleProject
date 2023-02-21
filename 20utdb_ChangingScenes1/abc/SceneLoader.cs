using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace utdb20_ChangingScenes1
{
    public class SceneLoader : MonoBehaviour
    {
        static bool sceneFlag = false;
        public Button button;

        private void Start()
        {
            button.onClick.AddListener(OnButtonClickHandler);
        }

        private void OnButtonClickHandler()
        {
            sceneFlag = !sceneFlag;
            int sceneIndexToLoad = GetSceneIndex();
            SceneManager.LoadScene(sceneIndexToLoad);
        }

        private static int GetSceneIndex()
        {
            if (sceneFlag)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
