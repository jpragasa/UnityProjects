using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCommand : ICommand
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private Color _color;
    [SerializeField] private Color _previousColor;
    public ClickCommand(GameObject cube, Color color)
    {
        this._cube = cube;
        this._color = color;
    }
    public void Execute()
    {
        // Change the color of the cube to a random color
        _previousColor = _cube.GetComponent<MeshRenderer>().material.color;
        _cube.GetComponent<MeshRenderer>().material.color = _color;
    }

    public void Undo()
    {
        _cube.GetComponent<MeshRenderer>().material.color = _previousColor;
    }
}
