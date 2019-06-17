using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public GameObject Cubik;
    public int Score;
    public Text ScoreText;

    public GameObject[] GameObjects;
    // Start is called before the first frame update
    void Start()


    {
        Instantiate(Cubik);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cubik.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            if (Cubik.transform.localScale.x >= 3.5f)
            {
                Destroy(Cubik);
                Score += 10;
                ScoreText.text = Score.ToString();
            }
        }
    }
}