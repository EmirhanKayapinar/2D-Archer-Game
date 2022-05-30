using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loginregister : MonoBehaviour
{
    public void StartOnclick()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }

}
