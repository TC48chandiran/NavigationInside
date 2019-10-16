using UnityEngine;
using UnityEngine.SceneManagement;

public class switchmenu : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("canva");
    }

    // public void GotoMenuScene()
    // {
    //SceneManager.LoadScene("intro");
    // }
}