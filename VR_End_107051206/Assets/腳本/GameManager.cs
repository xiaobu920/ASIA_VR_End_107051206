using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新遊戲
    /// </summary>
    public void RestartGame()
    {
        SceneManager.LoadScene("VR場景");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
