using SDProject.Models;

namespace SDProject.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
                if (!context.Admins.Any())
                {
                    context.Admins.AddRange(new List<Admin>
                    {
                        new Admin()
                        {
                            Name = "Ahmed Belhaj",
                            Email = "admin1@charity.com", 
                            Password = "123456",
                            ConfirmPassword = "123456"
                        },
                        new Admin()
                        {
                            Name = "Ahmed Sayed Zizo",
                            Email = "admin2@charity.com",
                            Password = "123456", 
                            ConfirmPassword = "123456"
                        }
                    });
                    context.SaveChanges();
                }
                /*if (!context.Inspectors.Any())
                {
                    context.Inspectors.AddRange(new List<CaseInspector>
                    {
                        new CaseInspector()
                        {
                            Name = "Mohamed Hamdy",
                            Email = "inspector1@charity.com",
                            Password = "123456",
                            Salary = 1500
                        },
                        new CaseInspector()
                        {
                            Name = "Ahmed Sayed Zizo",
                            Email = "inspector2@charity.com",
                            Password = "123456",
                            Salary = 3500
                        }
                    });
                    context.SaveChanges();
                }*/
                if (!context.Cases.Any())
                {
                    context.Cases.AddRange(new List<Case>
                    {
                        new Case()
                        {
                            FirstName = "Ali",
                            LastName = "Mostafa",
                            Address = "FCI",
                            Age = 25, 
                            CaseGender = Enums.Gender.Male,
                            FamilySize = 25,
                            GeneralNotes = "Hello World",
                            MonthlyEarnings = 1000,
                            PhoneNumber = "01112121223", 
                            InspectorId = 1
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Reports.Any())
                {
                    context.Reports.AddRange(new List<Report>
                    {
                        new Report()
                        {
                            CaseId = 1,
                            IfDataValid = true,
                            TypeOfCase = Enums.CaseType.Poor,
                            FinalConclusion = "Must be helped.",
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
