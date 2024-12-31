using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void ChangeScene(string _sceneName) // On appelle la fonction gr�ce � un event, donc la fonction est publique
    {
        SceneManager.LoadScene( _sceneName );
    }

    public void Quit()
    {
        Application.Quit();
    }
}
