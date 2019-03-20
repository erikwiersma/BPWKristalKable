using UnityEngine.SceneManagement;
using UnityEngine;

public class levelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene(). ("kasteel 2") );
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }

}
