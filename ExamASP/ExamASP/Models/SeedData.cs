using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace ExamASP.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            DataContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<DataContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Tom Holland",
                        ImgUrl= "https://upload.wikimedia.org/wikipedia/commons/2/25/Tom_Holland_MTV_2018_%2801%29.jpg",                        
                        Age = 25
                    },
                    new Employee
                    {
                        Name = "Samuel L. Jackson",
                        ImgUrl= "https://cdn.britannica.com/77/191077-050-63262B99/Samuel-L-Jackson.jpg",                        
                        Age = 22
                    },
                     new Employee
                     {
                         Name = "Jennifer Lawrence",
                         ImgUrl = "https://pyxis.nymag.com/v1/imgs/2ed/dbe/0820fa9512cd237db5830c32c68cc3b0bd-jennifer-lawrence.rvertical.w1200.jpg",
                         Age = 20
                     },
                      new Employee
                      {
                          Name = "Chris Hemsworth",
                          ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/e/e8/Chris_Hemsworth_by_Gage_Skidmore_2_%28cropped%29.jpg",
                          Age = 21
                      },
                       new Employee
                       {
                           Name = "Kristen Stewart",
                           ImgUrl = "https://m.media-amazon.com/images/M/MV5BMTQxMjUyOTY0Ml5BMl5BanBnXkFtZTcwNjI2MjA2Mw@@._V1_.jpg",
                           Age = 28
                       }
                );
                context.SaveChanges();
            }
        }
    }
}
