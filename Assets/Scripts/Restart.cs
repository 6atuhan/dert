using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartGameBir()
    {
        SceneManager.LoadScene("ilksahne"); // loads current scene
    }
    public void RestartGameIki()
    {
        SceneManager.LoadScene("ikikisilik"); // loads current scene
    }
    public void TekKisilik()
    {
        SceneManager.LoadScene("ilksahne");
    }
    public void IkiKisilik()
    {
        SceneManager.LoadScene("ikikisilik");
    }
    public void AnaSayfa()
    {
        SceneManager.LoadScene("anasayfa");
    }
}
