using UnityEngine;
using TMPro;

public class MathGenerator : MonoBehaviour
{
    int FirstRandomnumber;
    int SecondRandomnumber;
    [SerializeField] TMP_Text displayNumber1;
    [SerializeField] TMP_Text displayNumber2;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            CreateRandomNumber();
        }
    }

    public void CreateRandomNumber()
    {
        FirstRandomnumber = Random.Range(1, 201);
        SecondRandomnumber = Random.Range(1, 201);
        displayNumber1.text = FirstRandomnumber.ToString();
        displayNumber2.text = SecondRandomnumber.ToString();
    }
}
