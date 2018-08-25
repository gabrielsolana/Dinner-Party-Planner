using System.Runtime.Remoting.Messaging;

namespace Dinner_Party_Planner
{
    public class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecoration { get; set; }
        public bool HealthyOption { get; set; }

        public decimal Cost
        {
            get
            {
                return CalculateCost();
            }
        }

        public const decimal CostOfFoodPerPerson = 25M;

        public DinnerParty(int numberOfPeople, bool fancyDecoration, bool healthyOption)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecoration = fancyDecoration;
            HealthyOption = healthyOption;
        }

        public decimal CalculateCostOfBeveragesPePerson()
        {
            return HealthyOption ? 5M : 20M;
        }

        public decimal CalculateCostOfDecorations()
        {
            return FancyDecoration ? 15M * NumberOfPeople + 50M : 7.5M * NumberOfPeople + 30M;
        }

        private decimal CalculateCost()
        {
            var totalCost = 0M;

            totalCost += NumberOfPeople * CostOfFoodPerPerson;
            totalCost += NumberOfPeople * CalculateCostOfBeveragesPePerson();
            totalCost += CalculateCostOfDecorations();
            if (HealthyOption)
                totalCost = 0.95M * totalCost;

            return totalCost;
        }
    }
}