using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtons : MonoBehaviour
{
    
    private Animator PinterestB;
    private Animator GitHubB;
    private Animator TwitterB;
    private Animator LinkednB;
    private Animator NameB;
    private Animator TitleB;

    // Start is called before the first frame update
    void Start()
    {
        PinterestB = GetComponent<PinterestA>();     
    }

    //Add Button Component to any GameObject you used as the button icon. 
    //Once this script is added into each button as a coponent as well, it
    //will communicate the methods according to the button components available
    //methods. Add Audio source in each button and quickly access the component
    //in each button.
    public void Pinterest()
    {
        Application.OpenURL("https://www.pinterest.com/solymar227/");
    }

    public void GitHub()
    {
        Application.OpenURL("https://github.com/Soly-M-27");
    }

    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/Michi_or_Skully");
    }

    public void Linkdn()
    {
        Application.OpenURL("https://www.linkedin.com/in/solymar-sánchez-molina-094572220/");
    }
}
