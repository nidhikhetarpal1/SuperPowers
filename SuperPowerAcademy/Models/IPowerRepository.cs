namespace SuperPowerAcademy.Models
{
    public interface IPowerRepository
    {
        public SuperPower AddHeroesPower(int x);

        public SuperPower AddVillainsPower(int x);


        public SuperPower GetSuperPower();
        
    }
}
