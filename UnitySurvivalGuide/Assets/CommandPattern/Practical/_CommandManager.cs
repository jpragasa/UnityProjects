using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class _CommandManager : MonoBehaviour
{

    private static _CommandManager _instance;
   
    public static _CommandManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("Command Manager is NULL");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    private List<ICommands> _commandBuffer = new List<ICommands>();

    public void AddCommand(ICommands command)
    {
        _commandBuffer.Add(command);
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }

    IEnumerator RewindRoutine()
    {
        foreach(var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undo();
            yield return new WaitForEndOfFrame();
        }
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        foreach (var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForEndOfFrame();
        }
    }
}
