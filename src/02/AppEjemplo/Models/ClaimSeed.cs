using Bogus;
using System;

namespace AppEjemplo.Models
{
    public static class ClaimSeed
    {
        public static Claims[] GenerateData()
        {            
            var claims = new Faker<Claims>()               
            .RuleFor(c=> c.PracticeAssociationId, f => f.Random.Number(1, 10))
            .RuleFor(c => c.ClaimStatus, f => (short)f.Random.Number(1, 10))
            .RuleFor(c => c.ClaimType, f => (short)f.Random.Number(1, 10))
            .RuleFor(c => c.RelatedClaimId, f => f.Random.Number(1, 10))
            .RuleFor(c => c.IsEpsdt, f => f.Random.Bool())
            .RuleFor(c => c.AuthorizationNumber, f => f.Random.AlphaNumeric(25))
            .RuleFor(c => c.InsurerId, f => f.Random.Number(1, 10))
            .RuleFor(c => c.InsurerName, f => f.Name.FullName())
            .RuleFor(c => c.InsurerAddress1, f => f.Address.Direction())
            .RuleFor(c => c.InsurerAddress2, f => f.Address.SecondaryAddress())
            .RuleFor(c => c.InsurerCity, f => f.Address.City())
            .RuleFor(c => c.InsurerState, f => f.Address.StateAbbr())
            .RuleFor(c => c.InsurerZip, f => f.Address.ZipCode())

            .RuleFor(c => c.SubscriberFirstName, f => f.Name.FirstName())
            .RuleFor(c => c.SubscriberLastName, f => f.Name.LastName())
            .RuleFor(c => c.SubscriberMiddleInitial, f => 'T')
            .RuleFor(c => c.SubscriberAddress1, f => f.Address.Direction())
            .RuleFor(c => c.SubscriberAddress2, f => f.Address.SecondaryAddress())
            .RuleFor(c => c.SubscriberCity, f => f.Address.City())
            .RuleFor(c => c.SubscriberState, f => f.Address.StateAbbr())
            .RuleFor(c => c.SubscriberZip, f => f.Address.ZipCode())
            .RuleFor(c => c.SubscriberDOB, f => f.Date.Between(DateTime.Now, DateTime.Now.AddDays(25)))
            .RuleFor(c => c.SubscriberGender, f => f.Random.Char('F','M'))

            .RuleFor(c => c.SubscriberPlanGroupNumber, f => f.Random.AlphaNumeric(20))
            .RuleFor(c => c.SubscriberEmployerName, f => f.Name.FullName())
            .RuleFor(c => c.SubscriberId, f => f.Random.AlphaNumeric(20))
            .Generate(50000);

            return claims.ToArray();
        }
    }
}
