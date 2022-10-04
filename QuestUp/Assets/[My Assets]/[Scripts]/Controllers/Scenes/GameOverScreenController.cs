using UnityEngine;

namespace QuestUp
{
    public class GameOverScreenController : MonoBehaviour
    {
        public void GoToMainMenu()
        {
            TransitionManager.Instance.NextLevel("MainMenu");
        }
    }
}
