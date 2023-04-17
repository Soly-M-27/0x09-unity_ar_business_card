using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButtons : MonoBehaviour
{
    
    public Animator PinterestB;
    public Animator GitHubB;
    public Animator TwitterB;
    public Animator LinkednB;
    public Animator NameB;
    public Animator TitleB;

    // Start is called before the first frame update
    void Start()
    {

    }

    //Add Button Component to any GameObject you used as the button icon. 
    //Once this script is added into each button as a coponent as well, it
    //will communicate the methods according to the button components available
    //methods. Add Audio source in each button and quickly access the component
    //in each button.
    public void Pinterest()
    {
        PinterestB.SetBool("trigger", true);
        Application.OpenURL("https://www.pinterest.com/solymar227/");
    }

    public void GitHub()
    {
        GitHubB.SetBool("trigger", true);
        Application.OpenURL("https://github.com/Soly-M-27");
    }

    public void Twitter()
    {
        TwitterB.SetBool("trigger", true);
        Application.OpenURL("https://twitter.com/Michi_or_Skully");
    }

    public void Linkdn()
    {
        LinkednB.SetBool("trigger", true);
        Application.OpenURL("https://www.linkedin.com/in/solymar-sánchez-molina-094572220/");
    }

    public void Name() {
        NameB.SetBool("trigger", true);
    }
    public void Title() {
        TitleB.SetBool("trigger", true);
    }
}
