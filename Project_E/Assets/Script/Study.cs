using UnityEngine;

public class Study : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public string say = "";
    public char text = 'a';
    public int var01 = 1;
    public float var2 = 0.4f;
    public double var3 = 0.5;
    public bool var4 = true;
    void Start()
    {
        Debug.Log(this.say);
        Debug.Log(this.text);
        Debug.Log(var01);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
