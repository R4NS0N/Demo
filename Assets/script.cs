
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
   
    public void OnStartClick()
    {
        SceneManager.LoadScene("Первая");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR 
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
