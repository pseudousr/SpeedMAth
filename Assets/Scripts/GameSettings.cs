using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{


    public enum EGameMode
    {
        NOT_SET,
        ADD,
        SUB,
        MUL,
        DIV
    }
    // Start is called before the first frame update

    public static GameSettings Instance;

    private void Awake()
    {
        _Paused = false;

        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;

        }
        else
            Destroy(this);
    }
    private EGameMode _GameMode;
    private bool _Paused = false;

    public void SetPaused(bool paused) { _Paused = paused; }
    public bool GetPaused() { return _Paused; }


    void Start()
    {
        _GameMode = EGameMode.NOT_SET;
        //_continuePreviousGame = false;
    }
    public void SetGameMode(EGameMode mode)
    {
        _GameMode = mode;
    }
    public void SetGameMode(string mode)
    {
        if (mode == "Addition") SetGameMode(EGameMode.ADD);
        else if (mode == "Subtraction") SetGameMode(EGameMode.SUB);
        else if (mode == "Multiplication") SetGameMode(EGameMode.MUL);
        else if (mode == "Division") SetGameMode(EGameMode.DIV);
        SetGameMode(EGameMode.NOT_SET);
    }

    public string GetGameMode()
    {
        switch (_GameMode)
        {
            case EGameMode.ADD: return "Addition";
            case EGameMode.SUB: return "Subtraction";
            case EGameMode.MUL: return "Multiplication";
            case EGameMode.DIV: return "Division";
        }
        Debug.LogError("ERROR: Game Level is not set");
        return " ";

    }
}
