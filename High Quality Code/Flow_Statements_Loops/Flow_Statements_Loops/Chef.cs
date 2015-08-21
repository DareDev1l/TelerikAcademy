using Flow_Statements_Loops;

public class Chef
{
    public void Cook()
    {
        Potato potato = this.GetPotato();
        Carrot carrot = this.GetCarrot();
        Bowl bowl = this.GetBowl();

        this.Peel(potato);
        this.Peel(carrot);

        this.Cut(potato);
        this.Cut(carrot);

        bowl.Add(carrot);
        bowl.Add(potato);
    }

    private Bowl GetBowl()
    {
        return new Bowl(10);
    }

    private Carrot GetCarrot()
    {
        return new Carrot(1);
    }

    private Potato GetPotato()
    {
        return new Potato(1.5);
    }

    private void Peel(Vegetable vegetable)
    {
        // Peel the vegetable
    }

    private void Cut(Vegetable vegetable)
    {
        // Cut the vegetable
    }
}