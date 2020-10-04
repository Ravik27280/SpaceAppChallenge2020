using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechanger : MonoBehaviour
{
   public void mainmanu()
    {
        SceneManager.LoadScene("mainmanu");
    }
    public void SpaceShip()
    {
        SceneManager.LoadScene("SpaceShip");
    }
    public void moon()
    {
        SceneManager.LoadScene("moon");
    }
    //public void scene4()
    //{
    //    SceneManager.LoadScene("menu");
    //}
}
