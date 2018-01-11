using UnityEngine;
using UnityEngine.SceneManagement; //untuk menggunakan fungsi2 scene.

public class GameManager : MonoBehaviour {

    public GameObject completeLevelUI;
    public void RestarLevel ()
    {
        Invoke("restart", 1f);
    }

    public void LevelComplete ()
    {
        completeLevelUI.SetActive(true);
    }

    void restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
