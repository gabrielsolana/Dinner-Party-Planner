using System.Runtime.Remoting.Messaging;

namespace Dinner_Party_Planner
{
    public class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public decimal CostOfBeveragePerPerson { get; set; }
        public decimal CostOfDecorations { get; set; }
        
        public const decimal CostOfFoodPerPerson = 25M;

        public void SetHealthyOption(bool healthy)
        {
           if (healthy)
                CostOfBeveragePerPerson = 5M;
            else
                CostOfBeveragePerPerson = 20M;
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
                CostOfDecorations = 15M * NumberOfPeople + 50M;
            else
                CostOfDecorations = 7.5M * NumberOfPeople + 30M;
        }

        public decimal CalculateCost(bool healthy)
        {
            var totalCost = 0M;

            totalCost += NumberOfPeople * CostOfFoodPerPerson;
            totalCost += NumberOfPeople * CostOfBeveragePerPerson;
            totalCost += CostOfDecorations;
            if (healthy)
                totalCost = 0.95M * totalCost;
            
            return totalCost;
        }
    }
}