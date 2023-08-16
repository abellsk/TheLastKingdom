using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementMain : MonoBehaviour
{
    //Variables
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;

    //References
    private CharacterController controller;
}
