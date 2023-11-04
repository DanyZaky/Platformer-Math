using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Transform dari karakter pemain yang ingin diikuti
    public float smoothSpeed = 5f; // Kecepatan pergerakan kamera

    private Vector3 offset; // Jarak antara kamera dan karakter pemain

    void Start()
    {
        offset = transform.position - target.position; // Menghitung jarak awal antara kamera dan karakter pemain
    }

    void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset; // Menentukan posisi target yang diikuti oleh kamera
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime); // Menggerakkan kamera menuju posisi target dengan smoothing
    }
}
