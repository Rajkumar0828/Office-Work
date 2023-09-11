using System;

abstract class Hosptial_Diagnosis
{
    public abstract void Heart();
    public abstract void neural();
    public abstract void ENT();
    
}

class Diagnosis:Hosptial_Diagnosis
{
    public override void Heart()
    {
        Console.WriteLine("HEAR speacialist");
    }

    public override void neural()
    {
        Console.WriteLine("Neural specialist");
    }

    public override void ENT()
    {
        Console.WriteLine(" ENT Specialist");
    }
}

class program
{
    public static void Main(string[] args)
    {
        Diagnosis specialist1 = new Diagnosis();
        specialist1.Heart();

        Diagnosis specialist2 = new Diagnosis();
        specialist2.neural();
    }
}