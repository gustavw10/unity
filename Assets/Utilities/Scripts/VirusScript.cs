using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VirusScript : MonoBehaviour
{
    public Scene scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.name == "Player")
        {
            Debug.Log("Minus 1 life");
            other.GetComponent<PlayerControl>().life--; // life damaged 
            Destroy(gameObject); // This destroys
        }
        if (other.GetComponent<PlayerControl>().life < 1)
        {
            Debug.Log("Dead");
            Application.LoadLevel(scene.name);
            Debug.Log("Scene reloaded");
        }
    }
}
