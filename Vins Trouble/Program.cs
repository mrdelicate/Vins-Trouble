Arrow arrow = new();
arrow.OrderArrow();

class Arrow
{
    private ArrowHead arrowHead;
    private int shaft;
    private FletchingType fletching;
    private float cost;

    //public Arrow()
    //{
    //    this.arrowHead = SetArrowHead();
    //    this.shaft = SetArrowShaft();
    //    this.fletching = SetFletchingType();
    //    this.cost = GetCost();
    //}

    public void OrderArrow()
    {
        while (true)
        {
            Console.WriteLine("Press any key to start your arrow order!");
            Console.ReadKey();
            this.arrowHead = SetArrowHead();
            this.shaft = SetArrowShaft();
            this.fletching = SetFletchingType();
            this.cost = GetCost();
            Console.WriteLine($"That will be {this.cost} gold!  Pleasure doing business with you!");
            Console.ReadKey();
        }
    }

    ArrowHead GetArrowHead()
    {
        return this.arrowHead;
    }

    ArrowHead SetArrowHead()
    {
        while (true)
        {
            Console.Write("Select the number of the Arrowhead you want: 1)Steel 2)Wood 3)Obsidian. ");
            string input = Console.ReadLine();
            bool valid = int.TryParse(input, out int selection);
            if (valid && (selection == 1 || selection == 2 || selection == 3))
            {
                if (selection == 1)
                    return ArrowHead.Steel;
                else if (selection == 2)
                    return ArrowHead.Wood;
                else if (selection == 3)
                    return ArrowHead.Obsidian;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                continue;
            }
        }
    }

    int GetArrowShaft()
    {
        return this.shaft;
    }

    int SetArrowShaft()
    {
        while (true)
        {
            Console.Write("Select the shaft length in cm you want between 60 and 100: ");
            string input = Console.ReadLine();
            bool valid = int.TryParse(input, out int selection);
            if (valid && selection >= 60 && selection <= 100)
            {
                return selection;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                continue;
            }
        }
    }

    FletchingType GetFletchingType()
    {
        return this.fletching;
    }

    FletchingType SetFletchingType()
    {
        while (true)
        {
            Console.Write("Select the number of the fletching you want: 1)Plastic 2)Turkey Feathers 3)Goose Feathers. ");
            string input = Console.ReadLine();
            bool valid = int.TryParse(input, out int selection);
            if (valid && (selection == 1 || selection == 2 || selection == 3))
            {
                if (selection == 1)
                    return FletchingType.Plastic;
                else if (selection == 2)
                    return FletchingType.TurkeyFeathers;
                else if (selection == 3)
                    return FletchingType.GooseFeathers;
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                continue;
            }
        }
    }

    float GetCost()
    {
        float cost = 0;
        if (GetArrowHead() == ArrowHead.Steel)
            cost += 10;
        else if (GetArrowHead() == ArrowHead.Wood)
            cost += 3;
        else if (GetArrowHead() == ArrowHead.Obsidian)
            cost += 5;
        cost += .05f * GetArrowShaft();
        if (GetFletchingType() == FletchingType.Plastic)
            cost += 10;
        else if (GetFletchingType() == FletchingType.TurkeyFeathers)
            cost += 5;
        else if (GetFletchingType() == FletchingType.GooseFeathers)
            cost += 3;
        return cost;
    }
}

enum ArrowHead
{
    Steel,
    Wood,
    Obsidian
}

enum FletchingType
{
    Plastic,
    TurkeyFeathers,
    GooseFeathers
}
