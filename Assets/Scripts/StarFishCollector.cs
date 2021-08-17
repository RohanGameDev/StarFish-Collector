using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StarFishCollector : MonoBehaviour
{

    public Text starFishText;
    private int starFishTotal;
    // Start is called before the first frame update
     public void Start()
    {
        GameObject[] starFishArray = GameObject.FindGameObjectsWithTag("Star");
        starFishTotal = starFishArray.Length;
        starFishText.text = "Star-Fish Remaining " + starFishTotal;

     }
    public void Counter()
    {
        starFishTotal -= 1;
        starFishText.text = "Star-Fish Remaining " + starFishTotal;

        if(starFishTotal == 0)
        {
            SceneManager.LoadScene("Credits");
        }    
    }

}
