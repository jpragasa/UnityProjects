using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPractical : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    private void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            // Move Up
            ICommands moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
            _CommandManager.Instance.AddCommand(moveUp);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            // Move Down
            ICommands moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
            _CommandManager.Instance.AddCommand(moveDown);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            // Move Left
            ICommands moveLeft = new MoveLeftCommand(this.transform, _speed);
            moveLeft.Execute();
            _CommandManager.Instance.AddCommand(moveLeft);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            // Move Right
            ICommands moveRight = new MoveRightCommand(this.transform, _speed);
            moveRight.Execute();
            _CommandManager.Instance.AddCommand(moveRight);
        }
    }
}
