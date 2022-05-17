using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public void StartGame()
    {
        Debug.Log(SceneManager.GetActiveScene().buildIndex.ToString());
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
