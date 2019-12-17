using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPill : MonoBehaviour
{
    private GameController GameController;

    // Start is called before the first frame update
    void Start()
    {
        this.LoadValues();   
    }

    void LoadValues()
    {
        GameObject gameController = GameObject.Find("GameController");

        this.GameController = gameController.GetComponent<GameController>();
    }

    void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.tag == "Player") {
            this.GameController.AddScore();
            Destroy(this.gameObject);
        }
    }
}
