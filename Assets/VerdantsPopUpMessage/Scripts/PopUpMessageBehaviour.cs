using TMPro;
using UnityEngine;

public class PopUpMessageBehaviour : MonoBehaviour
{
    private TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.color -= new Color(0, 0, 0, Time.deltaTime / 2);

        text.transform.position += new Vector3(0,Time.deltaTime * 2,0);

        if (text.color.a <= 0)
            Destroy(gameObject);
    }
}
