using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _playerToFollow;
    [SerializeField] private float _cameraYOffset;
    [SerializeField] private float _cameraXOffset;
    [SerializeField] private float _cameraZOffset;

    private void FixedUpdate()
    {
        transform.position = new Vector3(_playerToFollow.transform.position.x + _cameraXOffset,
                                         _playerToFollow.transform.position.y + _cameraYOffset,
                                         _playerToFollow.transform.position.z + _cameraZOffset);
    }
}
