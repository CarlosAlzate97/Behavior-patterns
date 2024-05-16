namespace CoR.CoR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHandler externalConsult = new ExternalConsult();
            IHandler primaryCare = new PrimaryCare();
            IHandler emergency = new Emergency();

            externalConsult.setNextFloor(primaryCare);
            primaryCare.setNextFloor(emergency);

            CriticalValue criticalResult1 = new CriticalValue("Red", "Paciente con troponinas elevadas, riesgo inminente de infarto");
            externalConsult.handleCriticalvalue(criticalResult1);





        }
    }
}