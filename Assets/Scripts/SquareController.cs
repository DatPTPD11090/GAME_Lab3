using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SquareController : MonoBehaviour
{
    public float timeReaining = 60;
    public Text countdownText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
    }
    IEnumerator Countdown()
    {
        while (timeReaining > 0)
        {
            yield return new WaitForSeconds(1);
            timeReaining--;
            countdownText.text = "Time: " + timeReaining.ToString();
        }
        countdownText.text = "Time's up!";
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        transform.Translate(movement * 2f * Time.deltaTime);
        
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Circle"))
        {
            Debug.Log("YOU DIE!!!");
            Vector2 fistPosition = new Vector2(-5.5f, 0);
            transform.position = fistPosition;
        }
        if (collision.gameObject.name.Equals("Box"))
        {
            Debug.Log("YOU WIN!!!");
            LoadNextScene();
        }
        if (collision.gameObject.tag.Equals("X"))
        {
            Vector2 fistPosition = new Vector2(-9, 1);
            transform.position = fistPosition;
        }
    }
}
