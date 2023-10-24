using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.EventSystems.EventTrigger;

public class Information : MonoBehaviour
{

    public struct person
    {
        public bool isMale;
        public string name;
        public Color hairColor;
        public Color skinColor;
        public Color tshirtColor;
        public Color pantsColor;
        public float energy;
        public int points;
    }

    public person[] users = new person[50];
    public int countUsers = 0;
    public person currentUser;
    public string username;

    // Start is called before the first frame update
    void Start()
    {
        var dontDestroyInScenes = FindObjectsOfType<Information>();
        if (dontDestroyInScenes.Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public int SearchUser(string username)
    {
        for (int i = 0; i < countUsers; i++)
        {
            if (users[i].name == username)
            {
                currentUser = users[i];
                return 1;
            }
        }

        return 0;
    }

    public void CreateNewUser(bool isMale, string username, Color hair, Color skin, Color tshirt, Color pants, int points, float energy)
    {
        person newU = new person();
        newU.isMale = isMale;
        newU.name = username;
        newU.hairColor = hair;
        newU.skinColor = skin;
        newU.tshirtColor = tshirt;
        newU.pantsColor = pants;
        newU.points = points;
        newU.energy = energy;
        this.users[countUsers] = newU;
        this.countUsers++;
        this.username = newU.name;
        this.Enter();
    }

    public void SetUserName(string name)
    {
        username = name;
    }

    public void Enter()
    {
        for(int i=0; i<countUsers; i++)
        {
            if (users[i].name == username)
            {
                currentUser = users[i];
                this.ChangeScene("Home");
                break;
            }
        }
    }

    public void ResetCurrentUser()
    {
        currentUser = new person();
        username = "";
        this.ChangeScene("Login");
    }

    public void SetCurrentUserPoint(int points)
    {
        int id = -1;
        for (int i = 0; i < countUsers; i++)
        {
            if (users[i].name == username)
            {
                id = i;
            }
        }
        users[id].points += points;
        currentUser = users[id];
    }

    public void SetPointsSpecificUser(int id, int points)
    {
        users[id].points += points;
        currentUser = users[id];
    }

    public void SetCurrentUserEnergy(float energy)
    {
        int id = -1;
        for (int i = 0; i < countUsers; i++)
        {
            if (users[i].name == username)
            {
                id = i;
            }
        }
        users[id].energy += energy;
        currentUser = users[id];
    }

}
