using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
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