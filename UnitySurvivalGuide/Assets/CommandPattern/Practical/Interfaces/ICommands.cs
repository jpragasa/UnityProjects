using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommands
{
    void Execute();
    void Undo();
}
