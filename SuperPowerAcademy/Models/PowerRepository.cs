namespace SuperPowerAcademy.Models
{
    public class PowerRepository:IPowerRepository
    {
        private readonly ApplicationDbContext _db;
        public PowerRepository(ApplicationDbContext db)
        {
            _db = db;
           
            if (_db.SuperPowers.FirstOrDefault() == null)
            {
                _db.SuperPowers.Add(new SuperPower { HeroesPower = 0, VillainsPower = 0 });
                _db.SaveChanges();
            }
                   
        }

        public SuperPower AddHeroesPower(int x)
        {
            SuperPower power = GetSuperPower();
            power.HeroesPower += x;
             _db.SuperPowers.Update(power);
            _db.SaveChanges();

            return power;
        }

        public SuperPower AddVillainsPower(int x)
        {
            SuperPower power = GetSuperPower();
            power.VillainsPower += x;
            _db.SuperPowers.Update(power);
            _db.SaveChanges();

            return power;
        }

        public SuperPower GetSuperPower()
        {
                     
            return _db.SuperPowers.FirstOrDefault();
            
        }
    }
}
