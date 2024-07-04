  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// Source: https://www.youtube.com/watch?v=ZBj3LBA2vUY

public class CameraController : MonoBehaviour
{

    private Vector3 offset = new Vector3(0f, 5f, -10f);
    private float smoothTime = 0.25f;

    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;


    // Update is called once per frame
    void Update()
    {

        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
