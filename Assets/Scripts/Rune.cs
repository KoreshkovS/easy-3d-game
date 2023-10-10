using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rune : MonoBehaviour
{
    [SerializeField] private int _requiredOrbs = 1;

    private Player _player;

    private void Start()
    {
        _player = GameObject.Find("FirstPersonController").GetComponent<Player>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FirstPersonController")
        {
            if (_player.Orbs >= _requiredOrbs)
            {
                Debug.Log("You Win");
            }
        }
    }
}
