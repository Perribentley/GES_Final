using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float Speed = 10f;
    [SerializeField] float TurnSpeed = 30f;
    private float HorizontalInput;
    private float ForwardInput;

    private Rigidbody RBPlayer;

    //private int Damage;
    private int HealthCount = 100;
    [SerializeField] Text Health;

    public string NewGameScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get player input
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");

        //Move player forward
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * ForwardInput);
        //Turn player
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * HorizontalInput);
    }

    private void OnCollisionEnter(Collision collision)
    {
        RBPlayer = GetComponent<Rigidbody>();

        if (collision.gameObject.name == "House")
        {
            RBPlayer.velocity = Vector3.zero;
        }

        if (collision.gameObject.name == "Street 3 Prefab")
        {
            RBPlayer.velocity = Vector3.zero;
        }

        if (collision.gameObject.name == "Walls")
        {
            RBPlayer.velocity = Vector3.zero;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Enemy")
        {
            HealthCount -= 10;
            Debug.Log(Health);
            SetHealthText();
            if(HealthCount == 0)
            {
                NewGame();
            }
        }
    }

    public void SetHealthText()
    {
        Health.text = "Health: " + HealthCount.ToString();
    }
    public void NewGame()
    {
        SceneManager.LoadScene(NewGameScene);
    }
}
