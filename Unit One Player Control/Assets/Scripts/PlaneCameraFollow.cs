using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCameraFollow : MonoBehaviour
{
    [SerializeField] private Transform objTransform;
    [SerializeField] private float cameraOffsetY;
    [SerializeField] private float cameraOffsetX;
    [SerializeField] private float cameraOffsetZ;
    private Vector3 fullOffSet;
    private Quaternion quaternionOffset;
    [SerializeField] private float qOffsetX;
    [SerializeField] private float qOffsetY;
    [SerializeField] private float qOffsetZ;
    [SerializeField] private float qOffsetW;
    // Start is called before the first frame update
    void Start()
    {
        fullOffSet = new Vector3(cameraOffsetX, cameraOffsetY, cameraOffsetZ);
        quaternionOffset = new Quaternion(qOffsetX, qOffsetY, qOffsetZ, qOffsetW);
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.position = objTransform.transform.position + fullOffSet;
        transform.rotation = quaternionOffset;
    }
}
