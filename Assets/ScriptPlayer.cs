using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlayer : MonoBehaviour
{
    private Rigidbody Rigidbody;
    private bool Died;

    public float Velocity = 15;
    public float RotationVelocity = 150;

    // Start is called before the first frame update
    void Start()
    {
        this.LoadValues();
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.Died) {
            this.HandleMovement();
        }
    }

    void LoadValues()
    {
        this.Rigidbody = this.GetComponent<Rigidbody>();
        this.Died = false;
    }

    void HandleMovement()
    {
        float z = Input.GetAxis("Vertical");
        float x = Input.GetAxis("Horizontal");
        int rotate = 0;

        if (Input.GetKey(KeyCode.Q)) {
            rotate = -1;
        } else if (Input.GetKey(KeyCode.E)) {
            rotate = 1;
        }

        transform.Rotate(new Vector3(0, rotate * this.RotationVelocity * Time.deltaTime, 0));

        Vector3 velocity = transform.TransformDirection(new Vector3(
            x * this.Velocity,
            this.Rigidbody.velocity.y,
            z * this.Velocity
        ));

        this.Rigidbody.velocity = velocity;
    }

    public void Die()
    {
        Transform player = this.transform.Find("Player");

        this.Died = true;

        if (player) {
            Destroy(player.gameObject);
        }
    }
}
