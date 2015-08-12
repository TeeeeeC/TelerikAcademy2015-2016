namespace _01.Chef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = this.GetBowl();
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
           
            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(potato);
            bowl.Add(carrot);
        }

        private Potato GetPotato()
        {
            var newPotato = new Potato();

            return newPotato;
        }

        private Bowl GetBowl()
        {
            var newBowl = new Bowl();

            return newBowl;
        }

        private Carrot GetCarrot()
        {
            var newCarrot = new Carrot();

            return newCarrot;
        }

        private void Cut(Vegetable vegetable)
        {
            ////...
        }

        private void Peel(Vegetable vegetable)
        {
            ////...
        }
    }
}
