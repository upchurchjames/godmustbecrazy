using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    private Camera m_camera;

    private Vector2 m_DesiredPosition;

    // Start is called before the first frame update
    void Awake()
    {
        m_camera = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetStartPositionAndSize()
    {
        FindAveragePosition();

        transform.position = m_DesiredPosition;

        m_camera.orthographicSize = FindRequiredSize();
    }

}
