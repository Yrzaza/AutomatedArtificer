using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GAME_DestroyPanels : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Panel"))
        {
            other.gameObject.SetActive(false);
            Debug.Log("that bitch got thrown");
        }
    }
}
