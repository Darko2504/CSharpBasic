namespace Homework4.models
{
   public class Driver
    {
        public Driver(string name, int skill)
        {
            Name = name;
            Skill = skill;
        }

        public string Name { get; set; }
        public int Skill { get; set; }
    }
}
