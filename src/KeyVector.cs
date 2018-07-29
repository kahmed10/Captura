using System;

public class KeyVector
{
   
    public bool wPressed;
    public bool aPressed;
    public bool sPressed;
    public bool dPressed;
    private string _fileName;
    public string FileName
    {
        get { return _fileName; }
        set { _fileName = value; }
    }
    public KeyVector()
    {
        wPressed = false;
        aPressed = false;
        sPressed = false;
        dPressed = false;
    }

}
