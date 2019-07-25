using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileInfoAPI.Models
{
    public static class SamplePhoneSpec
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MobileInfoAPIContext(serviceProvider.GetRequiredService<DbContextOptions<MobileInfoAPIContext>>()))
            {
                // Look for any listed models.
                if (context.MobileSpecs.Count() > 0)
                {
                    return;   // Database has been selected
                }

                MobileSpecs sampleSpec = new MobileSpecs
                {
                    Id = 1,
                    ModelNumber = "A1723",
                    ModelName = "IPhone SE",
                    Company = "Apple",
                    Processor = "A9 APL0898",
                    BatteryRating = 1642,
                    PhoneLength = 58.6,
                    PhoneWidth = 123.8,
                    ScreenLength = 49.87,
                    ScreenWidth = 88.52
                };

                context.MobileSpecs.AddRange(sampleSpec);
                context.SaveChanges();
            }
        }
    }
}
