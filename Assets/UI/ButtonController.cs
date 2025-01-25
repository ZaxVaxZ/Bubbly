using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonController : MonoBehaviour
{
    [SerializeField] UnityEvent _StartGame;
    [SerializeField] UnityEvent _Options;
    [SerializeField] UnityEvent _Credits;

    private bool AllowActions;
    private float _timeStamp;
    [SerializeField] float _cooldown;

    void Start()
    {
        AllowActions = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!AllowActions && Time.time > _timeStamp + _cooldown)
            AllowActions = true;
    }

    public void setActive(int id)
    {
        if (!AllowActions)
            return;
        AllowActions = false;
        _timeStamp = Time.time;
        Debug.Log("action");
        switch (id)
        {
            case 0:
                StartGame(); break;
            case 1:
                Options(); break;
            case 2:
                Credits(); break;
            case 3:
                QuitGame(); break;
            default:
                break;
        }
    }

    void StartGame()
    {
        _StartGame.Invoke();
    }

    void Options()
    {
        _Options.Invoke();
    }
    void Credits()
    {
        _Credits.Invoke();
    }
    void QuitGame()
    {
        Application.Quit();
    }
}
