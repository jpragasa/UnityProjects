using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManager : MonoBehaviour
{
    private static CommandManager _instance;
    public static CommandManager Instance
    {
        get
        {
            if(_instance == null)
            {
                Debug.LogError("command manager is null");
            }
            return _instance;
        }
    }

    private List<ICommand> _commandBuffer = new List<ICommand>();


    private void Awake()
    {
        _instance = this;
    }

    public void addToBuffer(ICommand obj)
    {
        _commandBuffer.Add(obj);
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        foreach(var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForSeconds(1f);
        }
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
            yield return new WaitForSeconds(1f);
        }
    }

    public void Done()
    {
        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach(var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    public void Reset()
    {
        _commandBuffer.Clear();
    }

}
