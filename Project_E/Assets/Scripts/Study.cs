using UnityEngine;

public class Study : MonoBehaviour
{
    public string say = "";
    public char text = 'a';
    public int var01 = 1;
    public float var02 = 0.4f;
    public double var03 = 0.5;
    public bool var04 = true;
    private bool var05 = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
        Debug.Log(this.say);
        Debug.Log(this.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
