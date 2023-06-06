using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class object_click : MonoBehaviour
{
    Animator m_Animator;
    public GameObject UiButton;
    public Text sceneName1;
    Scene m_Scene;
    string sceneName;
    void Start()
    {
        m_Scene = SceneManager.GetActiveScene();
        sceneName = m_Scene.name;
        m_Animator = gameObject.GetComponent<Animator>();
        m_Animator.speed = 0;
    }
    public void GoToScene()
    {
        if (m_Scene.name == "first_scene")
        {
            SceneManager.LoadScene("second_scene");
            
        }
        if (m_Scene.name == "second_scene")
        {
            SceneManager.LoadScene("first_scene");
           
        }

       

    }
    void OnMouseDown()
    {
        if (gameObject.name == "hero_01" )
        {
            m_Animator.speed = 1;

        }
        if (gameObject.name == "hero_02")
        {
            m_Animator.speed = 1;

        }
        if (gameObject.name == "tree_07")
        {
            UiButton.SetActive(true);

        }
    }

   
}
