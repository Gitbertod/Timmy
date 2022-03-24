using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Renderer mat;
    private Vector2 offset;
    public float speedX, speedY;

    void Start()
    {
        mat = GetComponent<Renderer>();
    }

    void Update()
    {
        offset.x = Time.time * speedX;
        offset.y = Time.time * speedY;
        mat.material.mainTextureOffset = offset;
    }


}
