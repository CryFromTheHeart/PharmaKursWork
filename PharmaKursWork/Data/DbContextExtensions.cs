using Microsoft.CodeAnalysis.CSharp.Syntax;
using PharmaKursWork.Models;

namespace PharmaKursWork.Data
{
    public static class DbContextExtensions
    {
        public static void EnsureDatabaseSeeded(this DataContext dataContext)
        {
            // добавление единиц измерений
            if (!dataContext.UnitMeasures.Any())
            {
                dataContext.UnitMeasures.AddRange(new UnitMeasure[] {
                    new UnitMeasure()
                    {
                        Name= "КГ",
                        Desc= "Килограммы",
                    },
                    new UnitMeasure()
                    {
                        Name= "ГМ",
                        Desc= "граммы",
                    },
                    new UnitMeasure()
                    {
                        Name= "Л",
                        Desc= "Литры",
                    },
                });
                dataContext.SaveChanges();
            }

            // добавление товарных групп
            if (!dataContext.CommodityGroups.Any())
            {
                dataContext.CommodityGroups.AddRange(new CommodityGroup[] {
                    new CommodityGroup()
                    {
                        Name = "Таблетка",
                        Desc = "твердое",
                    },
                    new CommodityGroup()
                    {
                        Name = "Сироп",
                        Desc = "жидкое",
                    },
                    new CommodityGroup()
                    {
                        Name = "Гармоны",
                        Desc = "????",
                    },
                });
                dataContext.SaveChanges();
            }

            // добавление лабораторий
            if (!dataContext.Laboratories.Any())
            {
                dataContext.Laboratories.AddRange(new Laboratory[] {
                    new Laboratory()
                    {
                        Name = "Сколково",
                        Adress = "ульяновск, радищева 126",
                    },
                    new Laboratory()
                    {
                        Name = "Улгту",
                        Adress = "северный венец 32",
                    },
                    new Laboratory()
                    {
                        Name = "Гармоны",
                        Adress = "????",
                    },
                });
                dataContext.SaveChanges();
            }

            // Добавление лекарств
            if (!dataContext.Meds.Any())
            {
                var lab = dataContext.Laboratories.FirstOrDefault();
                var commodityGroup = dataContext.CommodityGroups.FirstOrDefault();
                var unit = dataContext.UnitMeasures.FirstOrDefault();

                dataContext.Meds.AddRange(new Med[] {
                    new Med()
                    {
                        Name = "Пумизан",
                        StartExploring = DateTime.Now,
                        Expenses = 100,
                        UnitMeasureId = unit.Id,
                        CommodityGroupId = commodityGroup.Id,
                        LabratoryId = lab.Id,
                    },
                    new Med()
                    {
                        Name = "Лед",
                        StartExploring = DateTime.Now,
                        Expenses = 1022222220,
                        UnitMeasureId = unit.Id,
                        CommodityGroupId = commodityGroup.Id,
                        LabratoryId = lab.Id,
                    },
                    new Med()
                    {
                        Name = "Алтея",
                        StartExploring = DateTime.Now,
                        Expenses = 102220,
                        UnitMeasureId = unit.Id,
                        CommodityGroupId = commodityGroup.Id,
                        LabratoryId = lab.Id,
                    },
                });
                dataContext.SaveChanges();
            }

            // Добавление работников лаборатории
            if (!dataContext.LaboratoryEmployees.Any())
            {
                var lab = dataContext.Laboratories.FirstOrDefault();

                dataContext.LaboratoryEmployees.AddRange(new LaboratoryEmployee[] {
                    new LaboratoryEmployee()
                    {
                        FirstName = "Сергей",
                        LastName = "Сазонов",
                        PhoneNumber = "+79053480050",
                        Email = "nik@mail.ru",
                        Adress = "Ульяновск",
                        LabratoryId = lab.Id,
                    },
                    new LaboratoryEmployee()
                    {
                        FirstName = "Сергей2",
                        LastName = "Сазонов2",
                        PhoneNumber = "+79053480050",
                        Email = "nik@mail.com",
                        Adress = "Ульяновск",
                        LabratoryId = lab.Id,
                    },
                    new LaboratoryEmployee()
                    {
                        FirstName = "Сергей3",
                        LastName = "Сазонов3",
                        PhoneNumber = "+79053480050",
                        Email = "nik@mail.org",
                        Adress = "Ульяновск",
                        LabratoryId = lab.Id,
                    },
                    new LaboratoryEmployee()
                    {
                        FirstName = "Сергей4",
                        LastName = "Сазонов4",
                        PhoneNumber = "+79053480050",
                        Email = "nik@mail.ru",
                        Adress = "Ульяновск",
                        LabratoryId = lab.Id,
                    },
                });
                dataContext.SaveChanges();

                var labEmployeers = (from l in dataContext.LaboratoryEmployees select l).ToList();

                dataContext.Scientists.AddRange(new Scientist[]
                {
                    new Scientist()
                    {
                        LaboratoryEmployeeId = labEmployeers[0].Id,
                        ResponsibleForDevice = "Прибор1",
                        DirectionDevelopment = "Таблетки",
                    },
                    new Scientist()
                    {
                        LaboratoryEmployeeId = labEmployeers[1].Id,
                        ResponsibleForDevice = "Прибор2",
                        DirectionDevelopment = "Жидкости",
                    }
                });

                dataContext.TechStaffs.AddRange(new TechStaff[]
                {
                    new TechStaff()
                    {
                        LaboratoryEmployeeId = labEmployeers[2].Id,
                        MaintainsDevice = "Прибор1",
                        HasYourInstruments = true,
                    },
                    new TechStaff()
                    {
                        LaboratoryEmployeeId = labEmployeers[3].Id,
                        MaintainsDevice = "Прибор2",
                        HasYourInstruments = false,
                    },
                });
                dataContext.SaveChanges();
            }


            if (!dataContext.Users.Any())
            {
                dataContext.Users.AddRange(new User[]
                {
                    new User()
                    {
                        Username = "admin",
                        Password = "123456",
                        authenticationKey = new Guid(),
                        isAdmin= true,
                    },
                    new User()
                    {
                        Username = "UserUser",
                        Password = "123456",
                        authenticationKey = new Guid(),
                        isAdmin= false,
                    }
                });

                dataContext.SaveChanges();
            }

            if (!dataContext.Challenges.Any())
            {
                var med = dataContext.Meds.FirstOrDefault();
                var scientist = dataContext.Scientists.FirstOrDefault();
                var techStaff = dataContext.TechStaffs.FirstOrDefault();


                dataContext.Challenges.AddRange(new Challenge[]
                {
                    new Challenge()
                    {
                        Name = "Испытание",
                        ChallegesStart = DateTime.Now,
                        MedsId = med.Id,
                        ScientistId = scientist.LaboratoryEmployeeId,
                        TechStaffId = techStaff.LaboratoryEmployeeId,
                    },
                    new Challenge()
                    {
                        Name = "Испытание2",
                        ChallegesStart = DateTime.Now,
                        MedsId = med.Id,
                        ScientistId = scientist.LaboratoryEmployeeId,
                        TechStaffId = techStaff.LaboratoryEmployeeId,
                    }
                });

                dataContext.SaveChanges();
            }

        }
    }
}
