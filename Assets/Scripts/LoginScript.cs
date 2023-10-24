using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginScript : MonoBehaviour
{

    private GameObject objPermanent;
    private Information informationCode;

    public GameObject alertText;
    public GameObject alertTextR;
    public string username;

    public GameObject credits;

    void Awake()
    {
        objPermanent = GameObject.Find("ObjectPermanent");
        informationCode = objPermanent.GetComponent<Information>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUserName(string name)
    {
        alertTextR.SetActive(false);
        alertText.SetActive(false);
        username = name;
        informationCode.SetUserName(name);
    }

    public void Enter()
    {
        if(username != null && username != "")
        {
            if(username == "ADMIN")
            {
                this.ChangeScene("HomeAdmin");
            }
            else
            {
                int exists = informationCode.SearchUser(username);
                if(exists == 0) 
                {
                    alertTextR.SetActive(true);
                }
                else
                {
                    alertTextR.SetActive(false);
                    informationCode.Enter();
                }
            }
        }
        else
        {
            alertText.SetActive(true);
        }
    }

    public void ChangeScene(string scene)
    {
        informationCode.ChangeScene(scene);
    }

    public void CloseApp()
    {
        Application.Quit();
    }

    public void ChangeCredits(bool option)
    {
        if(option)
        {
            credits.SetActive(true);
        }else 
        {
            credits.SetActive(false);
        }
    }
}
