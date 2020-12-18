using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform objTransform;
    [SerializeField] private float cameraOffsetY;
    [SerializeField] private float cameraOffsetX;
    [SerializeField] private float cameraOffsetZ;
    private Vector3 fullOffSet;
    // Start is called before the first frame update
    void Start()
    {
        fullOffSet = new Vector3(cameraOffsetX, cameraOffsetY, cameraOffsetZ);
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.position = objTransform.transform.position + fullOffSet;
    }
}
