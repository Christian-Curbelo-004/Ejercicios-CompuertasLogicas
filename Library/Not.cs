namespace Library;


public class Not : IGate
{
    public bool input1;
    
    public bool Output { get; set; }

    public void SetInputs(bool input1)
    {
        input1 = input1;
    }
}
